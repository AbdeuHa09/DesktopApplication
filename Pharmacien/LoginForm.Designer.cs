namespace Pharmacien
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel panelCenter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitre = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            tableLayout = new System.Windows.Forms.TableLayoutPanel();
            panelCenter = new System.Windows.Forms.Panel();

            tableLayout.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();

            // tableLayout — occupe toute la fenêtre
            tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayout.Controls.Add(panelCenter, 1, 1);

            // panelCenter — contient tous les contrôles
            panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCenter.BackColor = System.Drawing.Color.White;
            panelCenter.Controls.Add(btnLogin);
            panelCenter.Controls.Add(txtPassword);
            panelCenter.Controls.Add(lblPassword);
            panelCenter.Controls.Add(txtEmail);
            panelCenter.Controls.Add(lblEmail);
            panelCenter.Controls.Add(lblSubtitle);
            panelCenter.Controls.Add(lblTitre);

            // lblTitre
            lblTitre.AutoSize = false;
            lblTitre.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitre.ForeColor = System.Drawing.Color.FromArgb(11, 188, 105);
            lblTitre.Dock = System.Windows.Forms.DockStyle.None;
            lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitre.Size = new System.Drawing.Size(500, 65);
            lblTitre.Location = new System.Drawing.Point(0, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.TabIndex = 0;
            lblTitre.Text = "PharmaConnect";
            lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left
                            | System.Windows.Forms.AnchorStyles.Right;

            // lblSubtitle
            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSubtitle.Size = new System.Drawing.Size(500, 35);
            lblSubtitle.Location = new System.Drawing.Point(0, 100);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Connexion Pharmacien";
            lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top
                               | System.Windows.Forms.AnchorStyles.Left
                               | System.Windows.Forms.AnchorStyles.Right;

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(0, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";

            // txtEmail
            txtEmail.Location = new System.Drawing.Point(0, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(500, 31);
            txtEmail.TabIndex = 3;
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left
                            | System.Windows.Forms.AnchorStyles.Right;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(0, 255);
            lblPassword.Name = "lblPassword";
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mot de passe :";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(0, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(500, 31);
            txtPassword.TabIndex = 5;
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
                               | System.Windows.Forms.AnchorStyles.Left
                               | System.Windows.Forms.AnchorStyles.Right;

            // btnLogin
            btnLogin.BackColor = System.Drawing.Color.FromArgb(11, 188, 105);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(0, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(500, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "SE CONNECTER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left
                            | System.Windows.Forms.AnchorStyles.Right;

            // LoginForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(900, 600);
            MinimumSize = new System.Drawing.Size(600, 500);
            Controls.Add(tableLayout);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PharmaConnect - Pharmacien";

            tableLayout.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }
    }
}