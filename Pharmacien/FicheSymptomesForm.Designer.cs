namespace Pharmacien
{
    partial class FicheSymptomesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Button btnProposer;
        private System.Windows.Forms.Button btnFermer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblAllergies = new Label();
            txtAllergies = new TextBox();
            btnProposer = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(11, 188, 105);
            lblTitle.Location = new Point(29, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(501, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fiche des symptômes du patient";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(29, 117);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(133, 28);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Symptômes :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(29, 160);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(684, 150);
            txtDescription.TabIndex = 2;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAllergies.Location = new Point(29, 340);
            lblAllergies.Margin = new Padding(4, 0, 4, 0);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(106, 28);
            lblAllergies.TabIndex = 3;
            lblAllergies.Text = "Allergies :";
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(29, 383);
            txtAllergies.Margin = new Padding(4, 5, 4, 5);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.ReadOnly = true;
            txtAllergies.Size = new Size(684, 120);
            txtAllergies.TabIndex = 4;
            // 
            // btnProposer
            // 
            btnProposer.BackColor = Color.FromArgb(139, 92, 246);
            btnProposer.FlatStyle = FlatStyle.Flat;
            btnProposer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProposer.ForeColor = Color.White;
            btnProposer.Location = new Point(29, 550);
            btnProposer.Margin = new Padding(4, 5, 4, 5);
            btnProposer.Name = "btnProposer";
            btnProposer.Size = new Size(314, 60);
            btnProposer.TabIndex = 5;
            btnProposer.Text = "💊 Proposer médicaments";
            btnProposer.UseVisualStyleBackColor = false;
            btnProposer.Click += btnProposer_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Gray;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(371, 550);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(143, 60);
            btnFermer.TabIndex = 6;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // FicheSymptomesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 660);
            Controls.Add(btnFermer);
            Controls.Add(btnProposer);
            Controls.Add(txtAllergies);
            Controls.Add(lblAllergies);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FicheSymptomesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fiche des symptômes";
            Load += FicheSymptomesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}