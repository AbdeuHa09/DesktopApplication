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
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            this.SuspendLayout();

            // dgvMedicaments
            this.dgvMedicaments.AllowUserToAddRows = false;
            this.dgvMedicaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicaments.ColumnHeadersHeight = 34;
            this.dgvMedicaments.Location = new System.Drawing.Point(12, 12);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.Size = new System.Drawing.Size(560, 300);
            this.dgvMedicaments.TabIndex = 0;

            // btnValider
            this.btnValider.BackColor = System.Drawing.Color.Green;
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(350, 330);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 40);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "✓ Envoyer";
            this.btnValider.UseVisualStyleBackColor = false;

            // btnAnnuler
            this.btnAnnuler.Location = new System.Drawing.Point(460, 330);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 40);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;

            // ProposerMedicamentsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dgvMedicaments);
            this.Name = "ProposerMedicamentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proposer des médicaments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}