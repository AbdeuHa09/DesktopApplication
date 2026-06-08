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
        }

        private async Task LoadCommandes()
        {
            try
            {
                _commandes = await _apiService.GetCommandes();
                dgvCommandes.DataSource = null;
                dgvCommandes.DataSource = _commandes;

                string[] colonnesAMasquer = { "client", "livraison", "ligne_medicaments", "ordonnance", "pharmacien" };
                foreach (var col in colonnesAMasquer)
                    if (dgvCommandes.Columns.Contains(col))
                        dgvCommandes.Columns[col].Visible = false;

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
    }
}