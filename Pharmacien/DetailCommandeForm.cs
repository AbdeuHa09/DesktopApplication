using Pharmacien.Models;
using Pharmacien.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pharmacien
{
    public partial class DetailCommandeForm : Form
    {
        private ApiService _apiService;
        private Commande _commande;
        private List<Livreur> _livreurs;

        public DetailCommandeForm(ApiService apiService, Commande commande)
        {
            InitializeComponent();
            _apiService = apiService;
            _commande = commande;
            LoadDetails();
            LoadLivreurs();
        }

        private async void LoadDetails()
        {
            try
            {
                var commandeDetail = await _apiService.GetCommande(_commande.id);
                _commande = commandeDetail;

                lblNumero.Text = $"#{_commande.id}";
                lblDate.Text = _commande.date_commande.ToString("dd/MM/yyyy HH:mm");
                lblStatut.Text = GetStatutTexte(_commande.statut);
                lblStatut.BackColor = GetStatutCouleur(_commande.statut);

                string typeTexte = _commande.type_commande switch
                {
                    "ordonnance" => "📄 Ordonnance",
                    "selection" => "💊 Sélection",
                    "symptomes" => "🤒 Symptômes",
                    _ => _commande.type_commande
                };
                lblType.Text = typeTexte;

                if (_commande.client != null)
                {
                    lblClient.Text = $"{_commande.client.prenom} {_commande.client.name}";
                    lblEmail.Text = _commande.client.email;
                    lblTel.Text = _commande.client.tel;
                    lblAdresse.Text = _commande.client.adresse;
                }

                if (_commande.ligne_medicaments != null && _commande.ligne_medicaments.Any())
                {
                    var medicamentsList = _commande.ligne_medicaments.Select(l => new
                    {
                        Médicament = l.medicament?.nom,
                        Quantité = l.quantite,
                        PrixUnitaire = (l.prix_total / (double)l.quantite).ToString("F2") + " MAD",
                        Total = l.prix_total.ToString("F2") + " MAD"
                    }).ToList();
                    dgvMedicaments.DataSource = medicamentsList;

                    double total = _commande.ligne_medicaments.Sum(l => l.prix_total);
                    lblTotal.Text = $"{total:F2} MAD";
                }

                btnValider.Enabled = _commande.statut == "en_attente";
                btnRefuser.Enabled = _commande.statut == "en_attente";

                if (_commande.statut == "refusee" && _commande.livraison != null)
                {
                    lblJustification.Visible = true;
                    txtJustification.Visible = true;
                    txtJustification.Text = _commande.livraison.justification ?? "Aucune justification";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadLivreurs()
        {
            try
            {
                _livreurs = await _apiService.GetLivreurs();
                cmbLivreur.DataSource = _livreurs;
                cmbLivreur.DisplayMember = "prenom";
                cmbLivreur.ValueMember = "id";
                cmbLivreur.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur chargement livreurs: {ex.Message}");
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            if (cmbLivreur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un livreur", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Valider cette commande ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int livreurId = (int)cmbLivreur.SelectedValue;
                    await _apiService.ValiderCommande(_commande.id, livreurId);
                    MessageBox.Show("Commande validée avec succès !", "Succès",
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

        private async void btnRefuser_Click(object sender, EventArgs e)
        {
            string justification = Interaction.InputBox(
                "Justification du refus :",
                "Refus de commande",
                "");

            if (string.IsNullOrWhiteSpace(justification))
            {
                MessageBox.Show("Veuillez fournir une justification", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Refuser cette commande ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await _apiService.RefuserCommande(_commande.id, justification);
                    MessageBox.Show("Commande refusée", "Succès",
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

        private string GetStatutTexte(string statut)
        {
            return statut switch
            {
                "en_attente" => "⏳ En attente",
                "validee" => "✅ Validée",
                "en_livraison" => "🚚 En livraison",
                "livree" => "🏠 Livrée",
                "refusee" => "❌ Refusée",
                _ => statut
            };
        }

        private Color GetStatutCouleur(string statut)
        {
            return statut switch
            {
                "en_attente" => Color.LightYellow,
                "validee" => Color.LightGreen,
                "en_livraison" => Color.LightBlue,
                "livree" => Color.LightGreen,
                "refusee" => Color.LightPink,
                _ => Color.White
            };
        }

        private void DetailCommandeForm_Load(object sender, EventArgs e)
        {
        }
    }
}