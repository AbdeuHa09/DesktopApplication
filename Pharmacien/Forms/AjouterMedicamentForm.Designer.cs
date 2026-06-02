namespace Pharmacien.Forms
{
    partial class AjouterMedicamentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox chkOrdonnance;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNom = new Label();
            txtNom = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblPrix = new Label();
            txtPrix = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            chkOrdonnance = new CheckBox();
            btnEnregistrer = new Button();
            btnAnnuler = new Button();
            SuspendLayout();

            // lblNom
            lblNom.AutoSize = true;
            lblNom.Location = new Point(20, 20);
            lblNom.Text = "Nom :";

            // txtNom
            txtNom.Location = new Point(20, 50);
            txtNom.Size = new Size(350, 31);

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 90);
            lblDescription.Text = "Description :";

            // txtDescription
            txtDescription.Location = new Point(20, 120);
            txtDescription.Multiline = true;
            txtDescription.Size = new Size(350, 80);

            // lblPrix
            lblPrix.AutoSize = true;
            lblPrix.Location = new Point(20, 210);
            lblPrix.Text = "Prix (MAD) :";

            // txtPrix
            txtPrix.Location = new Point(20, 240);
            txtPrix.Size = new Size(150, 31);

            // lblStock
            lblStock.AutoSize = true;
            lblStock.Location = new Point(200, 210);
            lblStock.Text = "Stock :";

            // txtStock
            txtStock.Location = new Point(200, 240);
            txtStock.Size = new Size(150, 31);

            // chkOrdonnance
            chkOrdonnance.AutoSize = true;
            chkOrdonnance.Location = new Point(20, 290);
            chkOrdonnance.Text = "Nécessite ordonnance";

            // btnEnregistrer
            btnEnregistrer.BackColor = Color.Green;
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(20, 340);
            btnEnregistrer.Size = new Size(160, 40);
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.Click += btnEnregistrer_Click;

            // btnAnnuler
            btnAnnuler.Location = new Point(190, 340);
            btnAnnuler.Size = new Size(160, 40);
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;

            // AjouterMedicamentForm
            ClientSize = new Size(400, 420);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(chkOrdonnance);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrix);
            Controls.Add(lblPrix);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Name = "AjouterMedicamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un médicament";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}