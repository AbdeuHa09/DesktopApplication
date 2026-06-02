using System;
using System.Windows.Forms;
using Pharmacien.Models;
using Pharmacien.Services;

namespace Pharmacien.Forms
{
    public partial class AjouterMedicamentForm : Form
    {
        private ApiService _apiService;

        public AjouterMedicamentForm(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private async void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez saisir le nom", "Erreur");
                return;
            }

            if (!decimal.TryParse(txtPrix.Text, out decimal prix) || prix <= 0)
            {
                MessageBox.Show("Prix invalide", "Erreur");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock invalide", "Erreur");
                return;
            }

            btnEnregistrer.Enabled = false;
            btnEnregistrer.Text = "...";

            try
            {
                var medicament = new Medicament
                {
                    nom = txtNom.Text,
                    description = txtDescription.Text,
                    prix_unitaire = (double)prix,
                    quantite_stock = stock,
                    necessite_ordonnance = chkOrdonnance.Checked
                };

                await _apiService.AjouterMedicament(medicament);
                MessageBox.Show("Médicament ajouté !", "Succès");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
            finally
            {
                btnEnregistrer.Enabled = true;
                btnEnregistrer.Text = "Enregistrer";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}