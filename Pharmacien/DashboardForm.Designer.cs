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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEnAttente = new System.Windows.Forms.Label();
            this.lblValidees = new System.Windows.Forms.Label();
            this.lblLivrees = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            this.SuspendLayout();

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: 0";
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // lblEnAttente
            this.lblEnAttente.AutoSize = true;
            this.lblEnAttente.Location = new System.Drawing.Point(12, 50);
            this.lblEnAttente.Name = "lblEnAttente";
            this.lblEnAttente.TabIndex = 2;
            this.lblEnAttente.Text = "En attente: 0";
            this.lblEnAttente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // lblValidees
            this.lblValidees.AutoSize = true;
            this.lblValidees.Location = new System.Drawing.Point(12, 80);
            this.lblValidees.Name = "lblValidees";
            this.lblValidees.TabIndex = 3;
            this.lblValidees.Text = "Validées: 0";
            this.lblValidees.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // lblLivrees
            this.lblLivrees.AutoSize = true;
            this.lblLivrees.Location = new System.Drawing.Point(12, 110);
            this.lblLivrees.Name = "lblLivrees";
            this.lblLivrees.TabIndex = 4;
            this.lblLivrees.Text = "Livrées: 0";
            this.lblLivrees.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // dgvCommandes
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommandes.Location = new System.Drawing.Point(12, 140);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.ReadOnly = true;
            this.dgvCommandes.RowHeadersWidth = 51;
            this.dgvCommandes.RowTemplate.Height = 29;
            this.dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandes.Size = new System.Drawing.Size(760, 300);
            this.dgvCommandes.TabIndex = 0;
            // S'étire dans toutes les directions sauf le bas (laisse place aux boutons)
            this.dgvCommandes.Anchor = System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Bottom
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right;

            // btnActualiser
            this.btnActualiser.Location = new System.Drawing.Point(12, 450);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(120, 35);
            this.btnActualiser.TabIndex = 5;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // Reste collé en bas à gauche
            this.btnActualiser.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            // btnDeconnexion
            this.btnDeconnexion.Location = new System.Drawing.Point(652, 450);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(120, 35);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // Reste collé en bas à droite
            this.btnDeconnexion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // DashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lblLivrees);
            this.Controls.Add(this.lblValidees);
            this.Controls.Add(this.lblEnAttente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCommandes);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Pharmacien";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}