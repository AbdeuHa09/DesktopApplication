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
        private System.Windows.Forms.Label lblEnCours;        // ← AJOUTÉ
        private System.Windows.Forms.Label lblEnLivraison;    // ← AJOUTÉ
        private System.Windows.Forms.Label lblRefusees;       // ← AJOUTÉ
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
            lblEnCours = new Label();           // ← AJOUTÉ
            lblEnLivraison = new Label();       // ← AJOUTÉ
            lblRefusees = new Label();          // ← AJOUTÉ
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
            dgvCommandes.Location = new Point(9, 130);
            dgvCommandes.Margin = new Padding(3, 2, 3, 2);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.RowTemplate.Height = 29;
            dgvCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandes.Size = new Size(926, 200);
            dgvCommandes.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(10, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 15);
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
            // lblEnCours
            // 
            lblEnCours.AutoSize = true;
            lblEnCours.Location = new Point(10, 61);
            lblEnCours.Name = "lblEnCours";
            lblEnCours.Size = new Size(65, 15);
            lblEnCours.TabIndex = 3;
            lblEnCours.Text = "En cours: 0";
            // 
            // lblValidees
            // 
            lblValidees.AutoSize = true;
            lblValidees.Location = new Point(150, 38);
            lblValidees.Name = "lblValidees";
            lblValidees.Size = new Size(61, 15);
            lblValidees.TabIndex = 4;
            lblValidees.Text = "Validées: 0";
            // 
            // lblEnLivraison
            // 
            lblEnLivraison.AutoSize = true;
            lblEnLivraison.Location = new Point(150, 61);
            lblEnLivraison.Name = "lblEnLivraison";
            lblEnLivraison.Size = new Size(85, 15);
            lblEnLivraison.TabIndex = 5;
            lblEnLivraison.Text = "En livraison: 0";
            // 
            // lblLivrees
            // 
            lblLivrees.AutoSize = true;
            lblLivrees.Location = new Point(300, 38);
            lblLivrees.Name = "lblLivrees";
            lblLivrees.Size = new Size(55, 15);
            lblLivrees.TabIndex = 6;
            lblLivrees.Text = "Livrées: 0";
            // 
            // lblRefusees
            // 
            lblRefusees.AutoSize = true;
            lblRefusees.Location = new Point(300, 61);
            lblRefusees.Name = "lblRefusees";
            lblRefusees.Size = new Size(65, 15);
            lblRefusees.TabIndex = 7;
            lblRefusees.Text = "Refusées: 0";
            // 
            // btnActualiser
            // 
            btnActualiser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActualiser.Location = new Point(10, 340);
            btnActualiser.Margin = new Padding(3, 2, 3, 2);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(105, 26);
            btnActualiser.TabIndex = 8;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeconnexion.Location = new Point(831, 340);
            btnDeconnexion.Margin = new Padding(3, 2, 3, 2);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(105, 26);
            btnDeconnexion.TabIndex = 9;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGestionStock.Location = new Point(452, 340);
            btnGestionStock.Margin = new Padding(3, 2, 3, 2);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(105, 26);
            btnGestionStock.TabIndex = 10;
            btnGestionStock.Text = "Gestion Stock";
            btnGestionStock.UseVisualStyleBackColor = true;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // lblStatutPharmacie
            // 
            lblStatutPharmacie.AutoSize = true;
            lblStatutPharmacie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatutPharmacie.Location = new Point(500, 15);
            lblStatutPharmacie.Name = "lblStatutPharmacie";
            lblStatutPharmacie.Size = new Size(120, 15);
            lblStatutPharmacie.TabIndex = 11;
            lblStatutPharmacie.Text = "Statut: Chargement...";
            lblStatutPharmacie.Click += lblStatutPharmacie_Click;
            // 
            // btnToggleStatut
            // 
            btnToggleStatut.Location = new Point(254, 12);
            btnToggleStatut.Name = "btnToggleStatut";
            btnToggleStatut.Size = new Size(150, 26);
            btnToggleStatut.TabIndex = 12;
            btnToggleStatut.Text = "Changer statut";
            btnToggleStatut.UseVisualStyleBackColor = true;
            btnToggleStatut.Click += btnToggleStatut_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 380);
            Controls.Add(btnGestionStock);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnActualiser);
            Controls.Add(lblRefusees);
            Controls.Add(lblEnLivraison);
            Controls.Add(lblLivrees);
            Controls.Add(lblEnCours);
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