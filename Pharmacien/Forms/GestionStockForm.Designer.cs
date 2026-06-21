namespace Pharmacien.Forms
{
    partial class GestionStockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvMedicaments = new DataGridView();
            btnAjouter = new Button();
            btnActualiser = new Button();
            lblTotal = new Label();
            txtRecherche = new TextBox();
            lblRecherche = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.AllowUserToDeleteRows = false;
            dgvMedicaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicaments.ColumnHeadersHeight = 34;
            dgvMedicaments.Location = new Point(12, 60);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = false;
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(860, 400);
            dgvMedicaments.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Green;
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(12, 470);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(120, 40);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "+ Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(752, 470);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(120, 40);
            btnActualiser.TabIndex = 2;
            btnActualiser.Text = "⟳ Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 520);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 3;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(120, 17);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(300, 31);
            txtRecherche.TabIndex = 5;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(12, 20);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(106, 25);
            lblRecherche.TabIndex = 4;
            lblRecherche.Text = "Rechercher :";
            // 
            // GestionStockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Controls.Add(lblTotal);
            Controls.Add(btnActualiser);
            Controls.Add(btnAjouter);
            Controls.Add(dgvMedicaments);
            Name = "GestionStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des médicaments";
            Load += GestionStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}