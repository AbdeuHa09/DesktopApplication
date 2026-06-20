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
            lblTitre = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            tableLayout = new TableLayoutPanel();
            panelCenter = new Panel();
            tableLayout.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();
            //
            // lblTitre
            //
            lblTitre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(11, 188, 105);
            lblTitre.Location = new Point(40, 28);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(534, 49);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MEDICONNECT";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitle
            //
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(40, 82);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(534, 26);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Connexion Pharmacien";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(40, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";
            //
            // txtEmail
            //
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 162);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(534, 25);
            txtEmail.TabIndex = 3;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(40, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mot de passe :";
            //
            // txtPassword
            //
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(40, 228);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(534, 25);
            txtPassword.TabIndex = 5;
            //
            // btnLogin
            //
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(11, 188, 105);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 160, 90);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 135, 75);
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 288);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(534, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "SE CONNECTER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            //
            // tableLayout
            //
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayout.Controls.Add(panelCenter, 1, 1);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Margin = new Padding(3, 2, 3, 2);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayout.Size = new Size(788, 450);
            tableLayout.TabIndex = 0;
            //
            // panelCenter
            //
            panelCenter.BackColor = Color.White;
            panelCenter.BorderStyle = BorderStyle.FixedSingle;
            panelCenter.Controls.Add(btnLogin);
            panelCenter.Controls.Add(txtPassword);
            panelCenter.Controls.Add(lblPassword);
            panelCenter.Controls.Add(txtEmail);
            panelCenter.Controls.Add(lblEmail);
            panelCenter.Controls.Add(lblSubtitle);
            panelCenter.Controls.Add(lblTitre);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(160, 69);
            panelCenter.Margin = new Padding(3, 2, 3, 2);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(614, 311);
            panelCenter.TabIndex = 0;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(788, 450);
            Controls.Add(tableLayout);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(527, 385);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEDICONNECT - Pharmacien";
            tableLayout.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }
    }
}