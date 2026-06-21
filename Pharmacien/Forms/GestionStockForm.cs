using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pharmacien.Models;
using Pharmacien.Services;

namespace Pharmacien.Forms
{
    public partial class GestionStockForm : Form
    {
        private ApiService _apiService;
        private List<Medicament> _medicaments;
        private int _ancienneQuantite; // ← stocke la valeur AVANT modification

        public GestionStockForm(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            LoadMedicaments();

            // Attacher les événements
            dgvMedicaments.CellBeginEdit += DgvMedicaments_CellBeginEdit;
            dgvMedicaments.CellEndEdit += DgvMedicaments_CellEndEdit;
        }

        private async void LoadMedicaments()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _medicaments = await _apiService.GetMedicaments();
                dgvMedicaments.DataSource = null;
                dgvMedicaments.DataSource = _medicaments;

                // Configurer les colonnes
                if (dgvMedicaments.Columns.Contains("id"))
                    dgvMedicaments.Columns["id"].Visible = false;
                if (dgvMedicaments.Columns.Contains("nom"))
                    dgvMedicaments.Columns["nom"].HeaderText = "Médicament";
                if (dgvMedicaments.Columns.Contains("prix_unitaire"))
                {
                    dgvMedicaments.Columns["prix_unitaire"].HeaderText = "Prix (MAD)";
                    dgvMedicaments.Columns["prix_unitaire"].DefaultCellStyle.Format = "F2";
                }
                if (dgvMedicaments.Columns.Contains("quantite_stock"))
                {
                    dgvMedicaments.Columns["quantite_stock"].HeaderText = "Stock";
                    dgvMedicaments.Columns["quantite_stock"].ReadOnly = false;  // ← MODIFIABLE
                }
                if (dgvMedicaments.Columns.Contains("description"))
                    dgvMedicaments.Columns["description"].Visible = false;
                if (dgvMedicaments.Columns.Contains("necessite_ordonnance"))
                    dgvMedicaments.Columns["necessite_ordonnance"].HeaderText = "Ordonnance";
                if (dgvMedicaments.Columns.Contains("pharmacien_id"))
                    dgvMedicaments.Columns["pharmacien_id"].Visible = false;
                if (dgvMedicaments.Columns.Contains("created_at"))
                    dgvMedicaments.Columns["created_at"].Visible = false;
                if (dgvMedicaments.Columns.Contains("updated_at"))
                    dgvMedicaments.Columns["updated_at"].Visible = false;

                // Rendre toutes les colonnes en lecture seule sauf quantite_stock
                foreach (DataGridViewColumn col in dgvMedicaments.Columns)
                {
                    if (col.Name != "quantite_stock")
                        col.ReadOnly = true;
                }

                // Activer l'édition
                dgvMedicaments.EditMode = DataGridViewEditMode.EditOnEnter;

                lblTotal.Text = $"Total: {_medicaments.Count} médicaments";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // ========== CAPTURER L'ANCIENNE VALEUR AVANT MODIFICATION ==========
        private void DgvMedicaments_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex < 0 || dgvMedicaments.Columns[e.ColumnIndex].Name != "quantite_stock")
                return;

            var row = dgvMedicaments.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var medicament = (Medicament)row.DataBoundItem;
            _ancienneQuantite = medicament.quantite_stock; // ← sauvegarde AVANT que le binding écrase la valeur
        }

        // ========== MODIFICATION DIRECTE DANS LE DATAGRID ==========
        private async void DgvMedicaments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que c'est bien la colonne "quantite_stock"
            if (e.ColumnIndex < 0 || dgvMedicaments.Columns[e.ColumnIndex].Name != "quantite_stock")
                return;

            var row = dgvMedicaments.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var medicament = (Medicament)row.DataBoundItem;
            var nouvelleValeur = row.Cells[e.ColumnIndex].Value;

            if (nouvelleValeur == null || !int.TryParse(nouvelleValeur.ToString(), out int nouvelleQuantite) || nouvelleQuantite < 0)
            {
                row.Cells[e.ColumnIndex].Value = _ancienneQuantite;
                medicament.quantite_stock = _ancienneQuantite;
                MessageBox.Show("Veuillez saisir un nombre valide (0 ou plus)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Comparer avec l'ancienne valeur sauvegardée (pas medicament.quantite_stock qui a déjà changé)
            if (nouvelleQuantite == _ancienneQuantite) return;

            var result = MessageBox.Show($"Modifier le stock de '{medicament.nom}' de {_ancienneQuantite} à {nouvelleQuantite} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = await _apiService.UpdateStock(medicament.id, nouvelleQuantite);
                    if (success)
                    {
                        medicament.quantite_stock = nouvelleQuantite;
                        MessageBox.Show("Stock mis à jour !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        row.Cells[e.ColumnIndex].Value = _ancienneQuantite;
                        medicament.quantite_stock = _ancienneQuantite;
                        MessageBox.Show("Erreur lors de la mise à jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    row.Cells[e.ColumnIndex].Value = _ancienneQuantite;
                    medicament.quantite_stock = _ancienneQuantite;
                    MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                row.Cells[e.ColumnIndex].Value = _ancienneQuantite;
                medicament.quantite_stock = _ancienneQuantite;
            }
        }

        // ========== BOUTON MODIFIER (manuel) ==========
        private async void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var medicament = (Medicament)dgvMedicaments.SelectedRows[0].DataBoundItem;

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Stock actuel de {medicament.nom}: {medicament.quantite_stock}",
                "Modifier le stock",
                medicament.quantite_stock.ToString()
            );

            if (!int.TryParse(input, out int nouvelleQuantite) || nouvelleQuantite < 0)
            {
                MessageBox.Show("Veuillez saisir un nombre valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Modifier le stock de '{medicament.nom}' de {medicament.quantite_stock} à {nouvelleQuantite} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = await _apiService.UpdateStock(medicament.id, nouvelleQuantite);
                    if (success)
                    {
                        medicament.quantite_stock = nouvelleQuantite;
                        dgvMedicaments.Refresh();
                        MessageBox.Show("Stock mis à jour !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la mise à jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========== BOUTONS EXISTANTS ==========
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            LoadMedicaments();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterMedicamentForm form = new AjouterMedicamentForm(_apiService);
            if (form.ShowDialog() == DialogResult.OK)
                LoadMedicaments();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.ToLower();
            if (string.IsNullOrWhiteSpace(recherche))
                dgvMedicaments.DataSource = _medicaments;
            else
            {
                var resultats = _medicaments.Where(m => m.nom.ToLower().Contains(recherche)).ToList();
                dgvMedicaments.DataSource = resultats;
            }
        }

        private void GestionStockForm_Load(object sender, EventArgs e)
        {
        }
    }
}