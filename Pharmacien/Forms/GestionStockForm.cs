using System;
using System.Collections.Generic;
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

        public GestionStockForm(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            LoadMedicaments();
        }

        private async void LoadMedicaments()
        {
            try
            {
                _medicaments = await _apiService.GetMedicaments();
                dgvMedicaments.DataSource = null;
                dgvMedicaments.DataSource = _medicaments;
                lblTotal.Text = $"Total: {_medicaments.Count} médicaments";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

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
    }
}