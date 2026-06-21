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
            lblEnCours = new Label();
            lblEnLivraison = new Label();
            lblRefusees = new Label();
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
            dgvCommandes.ColumnHeadersHeight = 34;
            dgvCommandes.Location = new Point(13, 217);
            dgvCommandes.Margin = new Padding(4, 3, 4, 3);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.RowTemplate.Height = 29;
            dgvCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandes.Size = new Size(1323, 333);
            dgvCommandes.TabIndex = 0;
            dgvCommandes.CellContentClick += dgvCommandes_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(14, 25);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: 0";
            // 
            // lblEnAttente
            // 
            lblEnAttente.AutoSize = true;
            lblEnAttente.Location = new Point(14, 63);
            lblEnAttente.Margin = new Padding(4, 0, 4, 0);
            lblEnAttente.Name = "lblEnAttente";
            lblEnAttente.Size = new Size(110, 25);
            lblEnAttente.TabIndex = 2;
            lblEnAttente.Text = "En attente: 0";
            // 
            // lblValidees
            // 
            lblValidees.AutoSize = true;
            lblValidees.Location = new Point(214, 63);
            lblValidees.Margin = new Padding(4, 0, 4, 0);
            lblValidees.Name = "lblValidees";
            lblValidees.Size = new Size(95, 25);
            lblValidees.TabIndex = 4;
            lblValidees.Text = "Validées: 0";
            // 
            // lblLivrees
            // 
            lblLivrees.AutoSize = true;
            lblLivrees.Location = new Point(429, 63);
            lblLivrees.Margin = new Padding(4, 0, 4, 0);
            lblLivrees.Name = "lblLivrees";
            lblLivrees.Size = new Size(84, 25);
            lblLivrees.TabIndex = 6;
            lblLivrees.Text = "Livrées: 0";
            // 
            // lblEnCours
            // 
            lblEnCours.AutoSize = true;
            lblEnCours.Location = new Point(14, 102);
            lblEnCours.Margin = new Padding(4, 0, 4, 0);
            lblEnCours.Name = "lblEnCours";
            lblEnCours.Size = new Size(98, 25);
            lblEnCours.TabIndex = 3;
            lblEnCours.Text = "En cours: 0";
            // 
            // lblEnLivraison
            // 
            lblEnLivraison.AutoSize = true;
            lblEnLivraison.Location = new Point(214, 102);
            lblEnLivraison.Margin = new Padding(4, 0, 4, 0);
            lblEnLivraison.Name = "lblEnLivraison";
            lblEnLivraison.Size = new Size(120, 25);
            lblEnLivraison.TabIndex = 5;
            lblEnLivraison.Text = "En livraison: 0";
            // 
            // lblRefusees
            // 
            lblRefusees.AutoSize = true;
            lblRefusees.Location = new Point(429, 102);
            lblRefusees.Margin = new Padding(4, 0, 4, 0);
            lblRefusees.Name = "lblRefusees";
            lblRefusees.Size = new Size(100, 25);
            lblRefusees.TabIndex = 7;
            lblRefusees.Text = "Refusées: 0";
            // 
            // btnActualiser
            // 
            btnActualiser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActualiser.Location = new Point(14, 567);
            btnActualiser.Margin = new Padding(4, 3, 4, 3);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(150, 43);
            btnActualiser.TabIndex = 8;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeconnexion.Location = new Point(1187, 567);
            btnDeconnexion.Margin = new Padding(4, 3, 4, 3);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(150, 43);
            btnDeconnexion.TabIndex = 9;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGestionStock.Location = new Point(590, 567);
            btnGestionStock.Margin = new Padding(4, 3, 4, 3);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(150, 43);
            btnGestionStock.TabIndex = 10;
            btnGestionStock.Text = "Gestion Stock";
            btnGestionStock.UseVisualStyleBackColor = true;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // lblStatutPharmacie
            // 
            lblStatutPharmacie.AutoSize = true;
            lblStatutPharmacie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatutPharmacie.Location = new Point(714, 25);
            lblStatutPharmacie.Margin = new Padding(4, 0, 4, 0);
            lblStatutPharmacie.Name = "lblStatutPharmacie";
            lblStatutPharmacie.Size = new Size(193, 25);
            lblStatutPharmacie.TabIndex = 11;
            lblStatutPharmacie.Text = "Statut: Chargement...";
            lblStatutPharmacie.Click += lblStatutPharmacie_Click;
            // 
            // btnToggleStatut
            // 
            btnToggleStatut.Location = new Point(363, 20);
            btnToggleStatut.Margin = new Padding(4, 5, 4, 5);
            btnToggleStatut.Name = "btnToggleStatut";
            btnToggleStatut.Size = new Size(214, 43);
            btnToggleStatut.TabIndex = 12;
            btnToggleStatut.Text = "Changer statut";
            btnToggleStatut.UseVisualStyleBackColor = true;
            btnToggleStatut.Click += btnToggleStatut_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 633);
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
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(743, 479);
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