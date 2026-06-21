using Pharmacien.Models;
using Pharmacien.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
                if (commandeDetail == null)
                {
                    MessageBox.Show($"Commande #{_commande.id} non trouvée", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

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

                btnVoirOrdonnance.Visible = (_commande.type_commande == "ordonnance" && _commande.ordonnance != null);

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

                // ========== LOGIQUE DES BOUTONS AVEC VÉRIFICATION ORDONNANCE ==========
                // Pour SELECTION : validation directe depuis "en_attente"
                // Pour ORDONNANCE : validation seulement si en_attente ET médicaments proposés
                // Pour SYMPTOMES : validation après acceptation client (statut "en_cours")

                if (_commande.type_commande == "selection")
                {
                    btnValider.Enabled = (_commande.statut == "en_attente");
                    cmbLivreur.Enabled = (_commande.statut == "en_attente");
                }
                else if (_commande.type_commande == "ordonnance")
                {
                    // Vérifier si des médicaments ont été proposés
                    bool aDesMedicaments = _commande.ligne_medicaments != null && _commande.ligne_medicaments.Count > 0;

                    btnValider.Enabled = (_commande.statut == "en_attente" && aDesMedicaments);
                    cmbLivreur.Enabled = (_commande.statut == "en_attente" && aDesMedicaments);

                    // Message d'information
                    if (_commande.statut == "en_attente" && !aDesMedicaments)
                    {
                        btnValider.Text = "⚠️ Proposez d'abord des médicaments";
                    }
                    else
                    {
                        btnValider.Text = "✓ Valider";
                    }
                }
                else // SYMPTOMES
                {
                    btnValider.Enabled = (_commande.statut == "en_cours");
                    cmbLivreur.Enabled = (_commande.statut == "en_cours");
                    btnValider.Text = "✓ Valider";
                }

                btnValider.Visible = true;
                btnRefuser.Enabled = (_commande.statut == "en_attente");
                btnRefuser.Visible = true;
                cmbLivreur.Visible = true;
                // ==========================================================

                if (_commande.statut == "refusee" && _commande.livraison != null && !string.IsNullOrEmpty(_commande.livraison.justification))
                {
                    lblJustification.Visible = true;
                    txtJustification.Visible = true;
                    txtJustification.Text = _commande.livraison.justification;
                }
                else
                {
                    lblJustification.Visible = false;
                    txtJustification.Visible = false;
                }

                if (_commande.type_commande == "symptomes")
                {
                    btnVoirSymptomes.Visible = true;
                    btnVoirSymptomes.Enabled = (_commande.symptome != null);
                    lblSymptomes.Visible = false;
                    txtSymptomes.Visible = false;
                    lblAllergies.Visible = false;
                    txtAllergies.Visible = false;
                }
                else
                {
                    btnVoirSymptomes.Visible = false;
                    lblSymptomes.Visible = false;
                    txtSymptomes.Visible = false;
                    lblAllergies.Visible = false;
                    txtAllergies.Visible = false;
                }

                // Bouton proposer médicaments
                if (_commande.type_commande == "ordonnance")
                {
                    btnProposerMedicamentsOrdonnance.Visible = true;
                    btnProposerMedicamentsOrdonnance.Enabled = (_commande.statut == "en_attente");
                    btnProposerMedicamentsOrdonnance.Text = "💊 Proposer médicaments (Ordonnance)";
                }
                else if (_commande.type_commande == "symptomes")
                {
                    btnProposerMedicamentsOrdonnance.Visible = true;
                    btnProposerMedicamentsOrdonnance.Enabled = (_commande.statut == "en_attente");
                    btnProposerMedicamentsOrdonnance.Text = "💊 Proposer médicaments (Symptômes)";
                }
                else
                {
                    btnProposerMedicamentsOrdonnance.Visible = false;
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
                cmbLivreur.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    MessageBox.Show("Commande validée et livreur assigné !", "Succès",
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

        private async void btnVoirOrdonnance_Click(object sender, EventArgs e)
        {
            try
            {
                if (_commande.ordonnance == null)
                {
                    MessageBox.Show("Aucune ordonnance associée à cette commande.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var fileData = await _apiService.DownloadOrdonnance(_commande.ordonnance.id);

                if (fileData == null)
                {
                    MessageBox.Show("Impossible de télécharger l'ordonnance.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tempFile = Path.GetTempFileName();
                string ext = Path.GetExtension(_commande.ordonnance.fichier);
                if (string.IsNullOrEmpty(ext)) ext = ".pdf";

                string finalFile = tempFile + ext;
                File.Move(tempFile, finalFile);
                File.WriteAllBytes(finalFile, fileData);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = finalFile,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStatutTexte(string statut)
        {
            return statut switch
            {
                "en_attente" => "⏳ En attente",
                "en_cours" => "🔄 En cours (attente validation)",
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
                "en_cours" => Color.LightCyan,
                "validee" => Color.LightGreen,
                "en_livraison" => Color.LightBlue,
                "livree" => Color.LightGreen,
                "refusee" => Color.LightPink,
                _ => Color.White
            };
        }

        private void btnProposerMedicamentsOrdonnance_Click(object sender, EventArgs e)
        {
            string type = _commande.type_commande == "ordonnance" ? "ordonnance" : "symptomes";
            ProposerMedicamentsForm proposerForm = new ProposerMedicamentsForm(_apiService, _commande, type);
            var result = proposerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Médicaments proposés au client !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetails();
            }
        }

        private void btnVoirSymptomes_Click(object sender, EventArgs e)
        {
            if (_commande.symptome != null)
            {
                string message = $"Symptômes: {_commande.symptome.description}\n\nAllergies: {_commande.symptome.allergies ?? "Aucune"}";
                MessageBox.Show(message, "Informations symptômes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucune information sur les symptômes disponible.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DetailCommandeForm_Load(object sender, EventArgs e)
        {
        }

        private void txtAllergies_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblAllergies_Click(object sender, EventArgs e)
        {
        }

        private void lblJustification_Click(object sender, EventArgs e)
        {
        }
    }
}