using System;
using System.Windows.Forms;
using Pharmacien.Models;
using Pharmacien.Services;

namespace Pharmacien
{
    public partial class FicheSymptomesForm : Form
    {
        private ApiService _apiService;
        private Commande _commande;
        private Symptome _symptome;

        public FicheSymptomesForm(ApiService apiService, Commande commande, Symptome symptome)
        {
            InitializeComponent();
            _apiService = apiService;
            _commande = commande;
            _symptome = symptome;
            ChargerInfos();
        }

        private void ChargerInfos()
        {
            if (_symptome != null)
            {
                // Description des symptômes
                txtDescription.Text = string.IsNullOrEmpty(_symptome.description)
                    ? "Aucune description des symptômes"
                    : _symptome.description;

                // Allergies
                txtAllergies.Text = string.IsNullOrEmpty(_symptome.allergies)
                    ? "Aucune allergie signalée"
                    : _symptome.allergies;
            }
            else
            {
                txtDescription.Text = "Aucune information disponible";
                txtAllergies.Text = "Aucune information disponible";
            }
        }

        private void btnProposer_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire de proposition de medicaments
            ProposerMedicamentsForm proposerForm = new ProposerMedicamentsForm(_apiService, _commande);
            var result = proposerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Proposition envoyée au client !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FicheSymptomesForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}