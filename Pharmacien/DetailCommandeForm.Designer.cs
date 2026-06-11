namespace Pharmacien
{
    partial class DetailCommandeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbLivreur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRefuser;
        private System.Windows.Forms.Label lblJustification;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Button btnVoirOrdonnance;
        private System.Windows.Forms.Button btnVoirSymptomes;  // ← AJOUTÉ

        // Nouveaux contrôles pour les symptômes
        private System.Windows.Forms.Label lblSymptomes;
        private System.Windows.Forms.TextBox txtSymptomes;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtAllergies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNumero = new Label();
            lblDate = new Label();
            lblStatut = new Label();
            lblType = new Label();
            lblClient = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            lblAdresse = new Label();
            dgvMedicaments = new DataGridView();
            lblTotal = new Label();
            cmbLivreur = new ComboBox();
            btnValider = new Button();
            btnRefuser = new Button();
            lblJustification = new Label();
            txtJustification = new TextBox();
            btnVoirOrdonnance = new Button();
            btnVoirSymptomes = new Button();
            lblSymptomes = new Label();
            txtSymptomes = new TextBox();
            lblAllergies = new Label();
            txtAllergies = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNumero.Location = new Point(20, 20);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 38);
            lblNumero.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 25);
            lblDate.TabIndex = 1;
            // 
            // lblStatut
            // 
            lblStatut.AutoSize = true;
            lblStatut.Location = new Point(20, 80);
            lblStatut.Name = "lblStatut";
            lblStatut.Padding = new Padding(5);
            lblStatut.Size = new Size(10, 35);
            lblStatut.TabIndex = 2;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 110);
            lblType.Name = "lblType";
            lblType.Size = new Size(0, 25);
            lblType.TabIndex = 3;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClient.Location = new Point(20, 150);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(0, 28);
            lblClient.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 25);
            lblEmail.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(20, 210);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(0, 25);
            lblTel.TabIndex = 6;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(20, 240);
            lblAdresse.MaximumSize = new Size(300, 0);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(0, 25);
            lblAdresse.TabIndex = 7;
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicaments.ColumnHeadersHeight = 34;
            dgvMedicaments.Location = new Point(350, 20);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = true;
            dgvMedicaments.RowHeadersWidth = 62;
            dgvMedicaments.Size = new Size(420, 300);
            dgvMedicaments.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(350, 330);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 9;
            // 
            // cmbLivreur
            // 
            cmbLivreur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLivreur.Location = new Point(20, 320);
            cmbLivreur.Name = "cmbLivreur";
            cmbLivreur.Size = new Size(250, 33);
            cmbLivreur.TabIndex = 10;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.Green;
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(20, 359);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(120, 40);
            btnValider.TabIndex = 11;
            btnValider.Text = "✓ Valider";
            btnValider.UseVisualStyleBackColor = false;
            btnValider.Click += btnValider_Click;
            // 
            // btnRefuser
            // 
            btnRefuser.BackColor = Color.Red;
            btnRefuser.ForeColor = Color.White;
            btnRefuser.Location = new Point(177, 358);
            btnRefuser.Name = "btnRefuser";
            btnRefuser.Size = new Size(120, 40);
            btnRefuser.TabIndex = 12;
            btnRefuser.Text = "✗ Refuser";
            btnRefuser.UseVisualStyleBackColor = false;
            btnRefuser.Click += btnRefuser_Click;
            // 
            // lblJustification
            // 
            lblJustification.AutoSize = true;
            lblJustification.Location = new Point(148, 408);
            lblJustification.Name = "lblJustification";
            lblJustification.Size = new Size(183, 25);
            lblJustification.TabIndex = 13;
            lblJustification.Text = "Justification du refus :";
            lblJustification.Visible = false;
            lblJustification.Click += lblJustification_Click;
            // 
            // txtJustification
            // 
            txtJustification.Location = new Point(20, 440);
            txtJustification.Multiline = true;
            txtJustification.Name = "txtJustification";
            txtJustification.ReadOnly = true;
            txtJustification.Size = new Size(750, 80);
            txtJustification.TabIndex = 14;
            txtJustification.Visible = false;
            // 
            // btnVoirOrdonnance
            // 
            btnVoirOrdonnance.BackColor = Color.FromArgb(59, 130, 246);
            btnVoirOrdonnance.ForeColor = Color.White;
            btnVoirOrdonnance.Location = new Point(350, 360);
            btnVoirOrdonnance.Name = "btnVoirOrdonnance";
            btnVoirOrdonnance.Size = new Size(150, 40);
            btnVoirOrdonnance.TabIndex = 15;
            btnVoirOrdonnance.Text = "📄 Voir ordonnance";
            btnVoirOrdonnance.UseVisualStyleBackColor = false;
            btnVoirOrdonnance.Visible = false;
            btnVoirOrdonnance.Click += btnVoirOrdonnance_Click;
            // 
            // btnVoirSymptomes
            // 
            btnVoirSymptomes.BackColor = Color.FromArgb(59, 130, 246);
            btnVoirSymptomes.ForeColor = Color.White;
            btnVoirSymptomes.Location = new Point(350, 410);
            btnVoirSymptomes.Name = "btnVoirSymptomes";
            btnVoirSymptomes.Size = new Size(150, 40);
            btnVoirSymptomes.TabIndex = 21;
            btnVoirSymptomes.Text = "\U0001fa7a Voir symptômes";
            btnVoirSymptomes.UseVisualStyleBackColor = false;
            btnVoirSymptomes.Visible = false;
            btnVoirSymptomes.Click += btnVoirSymptomes_Click;
            // 
            // lblSymptomes
            // 
            lblSymptomes.AutoSize = true;
            lblSymptomes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSymptomes.Location = new Point(20, 270);
            lblSymptomes.Name = "lblSymptomes";
            lblSymptomes.Size = new Size(133, 28);
            lblSymptomes.TabIndex = 16;
            lblSymptomes.Text = "Symptômes :";
            lblSymptomes.Visible = false;
            // 
            // txtSymptomes
            // 
            txtSymptomes.Location = new Point(20, 300);
            txtSymptomes.Multiline = true;
            txtSymptomes.Name = "txtSymptomes";
            txtSymptomes.ReadOnly = true;
            txtSymptomes.Size = new Size(300, 60);
            txtSymptomes.TabIndex = 17;
            txtSymptomes.Visible = false;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAllergies.Location = new Point(20, 406);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(106, 28);
            lblAllergies.TabIndex = 18;
            lblAllergies.Text = "Allergies :";
            lblAllergies.Visible = false;
            lblAllergies.Click += lblAllergies_Click;
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(20, 440);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.ReadOnly = true;
            txtAllergies.Size = new Size(300, 50);
            txtAllergies.TabIndex = 19;
            txtAllergies.Visible = false;
            // 
            // DetailCommandeForm
            // 
            ClientSize = new Size(800, 550);
            Controls.Add(btnVoirSymptomes);
            Controls.Add(txtAllergies);
            Controls.Add(lblAllergies);
            Controls.Add(txtSymptomes);
            Controls.Add(lblSymptomes);
            Controls.Add(btnVoirOrdonnance);
            Controls.Add(lblNumero);
            Controls.Add(lblDate);
            Controls.Add(lblStatut);
            Controls.Add(lblType);
            Controls.Add(lblClient);
            Controls.Add(lblEmail);
            Controls.Add(lblTel);
            Controls.Add(lblAdresse);
            Controls.Add(dgvMedicaments);
            Controls.Add(lblTotal);
            Controls.Add(cmbLivreur);
            Controls.Add(btnValider);
            Controls.Add(btnRefuser);
            Controls.Add(lblJustification);
            Controls.Add(txtJustification);
            Name = "DetailCommandeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Détail de la commande";
            Load += DetailCommandeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}