using System;
using System.Windows.Forms;
using Pharmacien.Services;
using Pharmacien.Models;

namespace Pharmacien
{
    public partial class LoginForm : Form
    {
        private ApiService _apiService;

        public LoginForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optionnel : pré-remplir pour le test
            // txtEmail.Text = "pharmacie@test.com";
            // txtPassword.Text = "password";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Veuillez saisir votre email et mot de passe", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Connexion...";

            try
            {
                var response = await _apiService.Login(txtEmail.Text, txtPassword.Text);

                if (response.success)
                {
                    _apiService.SetToken(response.token);

                    MessageBox.Show($"Bienvenue {response.user.prenom} {response.user.name} !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: Ouvrir DashboardForm
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email ou mot de passe incorrect", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "SE CONNECTER";
            }
        }
    }
}