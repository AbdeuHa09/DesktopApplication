using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pharmacien.Models;
using Pharmacien.Services;

namespace Pharmacien
{
    public partial class ProposerMedicamentsForm : Form
    {
        private ApiService _apiService;
        private Commande _commande;
        private List<Medicament> _medicaments;

        public ProposerMedicamentsForm(ApiService apiService, Commande commande)
        {
            InitializeComponent();
            _apiService = apiService;
            _commande = commande;
            btnValider.Click += btnValider_Click;
            btnAnnuler.Click += (s, e) => this.Close();
            LoadMedicaments();
        }

        private async void LoadMedicaments()
        {
            try
            {
                _medicaments = await _apiService.GetMedicaments();
                dgvMedicaments.DataSource = null;
                dgvMedicaments.DataSource = _medicaments;

                // Configurer les colonnes
                if (dgvMedicaments.Columns.Contains("id"))
                    dgvMedicaments.Columns["id"].Visible = false;
                if (dgvMedicaments.Columns.Contains("nom"))
                    dgvMedicaments.Columns["nom"].HeaderText = "Médicament";
                if (dgvMedicaments.Columns.Contains("prix_unitaire"))
                    dgvMedicaments.Columns["prix_unitaire"].HeaderText = "Prix (MAD)";
                if (dgvMedicaments.Columns.Contains("quantite_stock"))
                    dgvMedicaments.Columns["quantite_stock"].HeaderText = "Stock";
                if (dgvMedicaments.Columns.Contains("description"))
                    dgvMedicaments.Columns["description"].Visible = false;
                if (dgvMedicaments.Columns.Contains("necessite_ordonnance"))
                    dgvMedicaments.Columns["necessite_ordonnance"].Visible = false;

                // Ajouter colonne quantité
                if (!dgvMedicaments.Columns.Contains("Quantite"))
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.Name = "Quantite";
                    col.HeaderText = "Quantité";
                    dgvMedicaments.Columns.Add(col);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            var medicamentsProposes = new List<object>();

            for (int i = 0; i < dgvMedicaments.Rows.Count; i++)
            {
                var quantiteCell = dgvMedicaments.Rows[i].Cells["Quantite"];
                if (quantiteCell.Value != null && int.TryParse(quantiteCell.Value.ToString(), out int qte) && qte > 0)
                {
                    var medicament = _medicaments[i];
                    medicamentsProposes.Add(new { id = medicament.id, quantite = qte });
                }
            }

            if (medicamentsProposes.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un médicament", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                await _apiService.ProposerMedicaments(_commande.id, medicamentsProposes);
                MessageBox.Show("Proposition envoyée au client !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}