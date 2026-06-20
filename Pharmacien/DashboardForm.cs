using Pharmacien.Forms;
using Pharmacien.Models;
using Pharmacien.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Pharmacien
{
    public partial class DashboardForm : Form
    {
        private ApiService _apiService;
        private User _user;
        private List<Commande> _commandes;

        public DashboardForm(ApiService apiService, User user)
        {
            InitializeComponent();

            // Désactive la génération automatique des colonnes
            // -> on définit nous-mêmes uniquement les colonnes nécessaires
            dgvCommandes.AutoGenerateColumns = false;

            dgvCommandes.CellDoubleClick += dgvCommandes_CellDoubleClick;

            Button btnGestionStock = new Button();
            btnGestionStock.Text = "📦 Gestion Stock";
            btnGestionStock.Location = new Point(150, 460);
            btnGestionStock.Size = new Size(150, 35);
            btnGestionStock.Click += (s, e) => new GestionStockForm(_apiService).ShowDialog();
            this.Controls.Add(btnGestionStock);

            _apiService = apiService;
            _user = user;
            LoadCommandes();
            LoadStats();
            LoadStatutPharmacie();
        }

        /// <summary>
        /// Définit les colonnes à afficher dans le DataGridView des commandes.
        /// Seules les informations nécessaires sont affichées : N°, Date, Type, Statut.
        /// </summary>
        private void ConfigurerColonnesCommandes()
        {
            dgvCommandes.Columns.Clear();

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                DataPropertyName = "id",
                HeaderText = "N°",
                Width = 50
            });

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "date_commande",
                DataPropertyName = "date_commande",
                HeaderText = "Date",
                Width = 150
            });

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "type_commande",
                DataPropertyName = "type_commande",
                HeaderText = "Type",
                Width = 120
            });

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "statut",
                DataPropertyName = "statut",
                HeaderText = "Statut",
                Width = 120
            });
        }

        private async Task LoadCommandes()
        {
            try
            {
                _commandes = await _apiService.GetCommandes();

                if (dgvCommandes.Columns.Count == 0)
                    ConfigurerColonnesCommandes();

                dgvCommandes.DataSource = null;
                dgvCommandes.DataSource = _commandes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadStats()
        {
            try
            {
                var commandes = await _apiService.GetCommandes();
                lblTotal.Text = $"Total: {commandes.Count}";
                lblEnAttente.Text = $"En attente: {commandes.Count(c => c.statut == "en_attente")}";
                lblValidees.Text = $"Validées: {commandes.Count(c => c.statut == "validee")}";
                lblLivrees.Text = $"Livrées: {commandes.Count(c => c.statut == "livree")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur stats: {ex.Message}");
            }
        }

        private async void dgvCommandes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var commande = dgvCommandes.Rows[e.RowIndex].DataBoundItem as Commande;
                if (commande == null) return;

                DetailCommandeForm detailForm = new DetailCommandeForm(_apiService, commande);
                var result = detailForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await LoadCommandes();
                    await LoadStats();
                }
            }
        }

        private async void btnActualiser_Click(object sender, EventArgs e)
        {
            await LoadCommandes();
            await LoadStats();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            GestionStockForm stockForm = new GestionStockForm(_apiService);
            stockForm.ShowDialog();
        }
        private async void LoadStatutPharmacie()
        {
            try
            {
                string statut = await _apiService.GetStatutPharmacie();
                UpdateStatutAffichage(statut);
            }
            catch (Exception ex)
            {
                lblStatutPharmacie.Text = "❌ Statut: Erreur";
                Console.WriteLine($"Erreur: {ex.Message}");
            }
        }

        private void UpdateStatutAffichage(string statut)
        {
            if (statut == "ouvert")
            {
                lblStatutPharmacie.Text = "🟢 Statut: Ouvert";
                lblStatutPharmacie.ForeColor = System.Drawing.Color.Green;
                btnToggleStatut.Text = "🔴 Fermer la pharmacie";
                btnToggleStatut.BackColor = System.Drawing.Color.Green;
                btnToggleStatut.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                lblStatutPharmacie.Text = "🔴 Statut: Fermé";
                lblStatutPharmacie.ForeColor = System.Drawing.Color.Red;
                btnToggleStatut.Text = "🟢 Ouvrir la pharmacie";
                btnToggleStatut.BackColor = System.Drawing.Color.Red;
                btnToggleStatut.ForeColor = System.Drawing.Color.White;
            }
        }

        private async void btnToggleStatut_Click(object sender, EventArgs e)
        {
            try
            {
                string statutActuel = await _apiService.GetStatutPharmacie();
                string nouveauStatut = statutActuel == "ouvert" ? "ferme" : "ouvert";

                bool success = await _apiService.UpdateStatutPharmacie(nouveauStatut);

                if (success)
                {
                    UpdateStatutAffichage(nouveauStatut);
                    MessageBox.Show($"Pharmacie {nouveauStatut}", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors du changement de statut", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblStatutPharmacie_Click(object sender, EventArgs e)
        {

        }

        private void dgvCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}