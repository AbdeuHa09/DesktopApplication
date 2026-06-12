namespace Pharmacien
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEnAttente;
        private System.Windows.Forms.Label lblValidees;
        private System.Windows.Forms.Label lblLivrees;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblStatutPharmacie;
        private System.Windows.Forms.Button btnToggleStatut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCommandes = new DataGridView();
            lblTotal = new Label();
            lblEnAttente = new Label();
            lblValidees = new Label();
            lblLivrees = new Label();
            btnActualiser = new Button();
            btnDeconnexion = new Button();
            btnGestionStock = new Button();
            lblStatutPharmacie = new Label();
            btnToggleStatut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommandes.Location = new Point(9, 109);
            dgvCommandes.Margin = new Padding(3, 2, 3, 2);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.RowTemplate.Height = 29;
            dgvCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandes.Size = new Size(926, 214);
            dgvCommandes.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(10, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: 0";
            // 
            // lblEnAttente
            // 
            lblEnAttente.AutoSize = true;
            lblEnAttente.Location = new Point(10, 38);
            lblEnAttente.Name = "lblEnAttente";
            lblEnAttente.Size = new Size(72, 15);
            lblEnAttente.TabIndex = 2;
            lblEnAttente.Text = "En attente: 0";
            // 
            // lblValidees
            // 
            lblValidees.AutoSize = true;
            lblValidees.Location = new Point(10, 60);
            lblValidees.Name = "lblValidees";
            lblValidees.Size = new Size(61, 15);
            lblValidees.TabIndex = 3;
            lblValidees.Text = "Validées: 0";
            // 
            // lblLivrees
            // 
            lblLivrees.AutoSize = true;
            lblLivrees.Location = new Point(10, 82);
            lblLivrees.Name = "lblLivrees";
            lblLivrees.Size = new Size(55, 15);
            lblLivrees.TabIndex = 4;
            lblLivrees.Text = "Livrées: 0";
            // 
            // btnActualiser
            // 
            btnActualiser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActualiser.Location = new Point(10, 327);
            btnActualiser.Margin = new Padding(3, 2, 3, 2);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(105, 26);
            btnActualiser.TabIndex = 5;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeconnexion.Location = new Point(831, 327);
            btnDeconnexion.Margin = new Padding(3, 2, 3, 2);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(105, 26);
            btnDeconnexion.TabIndex = 6;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGestionStock.Location = new Point(452, 327);
            btnGestionStock.Margin = new Padding(3, 2, 3, 2);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(105, 26);
            btnGestionStock.TabIndex = 7;
            btnGestionStock.Text = "Gestion Stock";
            btnGestionStock.UseVisualStyleBackColor = true;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // lblStatutPharmacie
            // 
            lblStatutPharmacie.AutoSize = true;
            lblStatutPharmacie.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatutPharmacie.Location = new Point(410, 15);
            lblStatutPharmacie.Name = "lblStatutPharmacie";
            lblStatutPharmacie.Size = new Size(158, 20);
            lblStatutPharmacie.TabIndex = 8;
            lblStatutPharmacie.Text = "Statut: Chargement...";
            lblStatutPharmacie.Click += lblStatutPharmacie_Click;
            // 
            // btnToggleStatut
            // 
            btnToggleStatut.Location = new Point(254, 12);
            btnToggleStatut.Name = "btnToggleStatut";
            btnToggleStatut.Size = new Size(150, 26);
            btnToggleStatut.TabIndex = 9;
            btnToggleStatut.Text = "Changer statut";
            btnToggleStatut.UseVisualStyleBackColor = true;
            btnToggleStatut.Click += btnToggleStatut_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 364);
            Controls.Add(btnGestionStock);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnActualiser);
            Controls.Add(lblLivrees);
            Controls.Add(lblValidees);
            Controls.Add(lblEnAttente);
            Controls.Add(lblTotal);
            Controls.Add(dgvCommandes);
            Controls.Add(lblStatutPharmacie);
            Controls.Add(btnToggleStatut);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(527, 310);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Pharmacien";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnGestionStock;
    }
}