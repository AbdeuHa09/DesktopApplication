namespace Pharmacien
{
    partial class ProposerMedicamentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvMedicaments = new DataGridView();
            btnValider = new Button();
            btnAnnuler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicaments.ColumnHeadersHeight = 34;
            dgvMedicaments.Location = new Point(10, 9);
            dgvMedicaments.Margin = new Padding(3, 2, 3, 2);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.Size = new Size(490, 225);
            dgvMedicaments.TabIndex = 0;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.Green;
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(306, 248);
            btnValider.Margin = new Padding(3, 2, 3, 2);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(88, 30);
            btnValider.TabIndex = 1;
            btnValider.Text = "✓ Envoyer";
            btnValider.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(402, 248);
            btnAnnuler.Margin = new Padding(3, 2, 3, 2);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(88, 30);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // ProposerMedicamentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 286);
            Controls.Add(btnAnnuler);
            Controls.Add(btnValider);
            Controls.Add(dgvMedicaments);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProposerMedicamentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proposer des médicaments";
            Load += ProposerMedicamentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            ResumeLayout(false);
        }
    }
}