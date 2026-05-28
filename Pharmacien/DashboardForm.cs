using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Pharmacien.Services;
using Pharmacien.Models;

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
            _apiService = apiService;
            _user = user;
            this.Text = $"Dashboard - {_user.prenom} {_user.name}";
            LoadCommandes();
            LoadStats();
        }

        private async void LoadCommandes()
        {
            try
            {
                _commandes = await _apiService.GetCommandes();
                dgvCommandes.DataSource = null;
                dgvCommandes.DataSource = _commandes;

                if (dgvCommandes.Columns.Contains("id"))
                    dgvCommandes.Columns["id"].HeaderText = "N°";
                if (dgvCommandes.Columns.Contains("date_commande"))
                    dgvCommandes.Columns["date_commande"].HeaderText = "Date";
                if (dgvCommandes.Columns.Contains("type_commande"))
                    dgvCommandes.Columns["type_commande"].HeaderText = "Type";
                if (dgvCommandes.Columns.Contains("statut"))
                    dgvCommandes.Columns["statut"].HeaderText = "Statut";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadStats()
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

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            LoadCommandes();
            LoadStats();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Déjà géré dans le constructeur
        }
    }
}