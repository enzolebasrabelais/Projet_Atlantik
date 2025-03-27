namespace Projet_Atlantik
{
    partial class FormModifierBateau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbNomBateauModif = new System.Windows.Forms.ComboBox();
            this.btnModifierBateau = new System.Windows.Forms.Button();
            this.gbxModifierBateau = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbNomBateauModif
            // 
            this.cmbNomBateauModif.FormattingEnabled = true;
            this.cmbNomBateauModif.Location = new System.Drawing.Point(101, 57);
            this.cmbNomBateauModif.Name = "cmbNomBateauModif";
            this.cmbNomBateauModif.Size = new System.Drawing.Size(121, 21);
            this.cmbNomBateauModif.TabIndex = 0;
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Location = new System.Drawing.Point(80, 308);
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(75, 23);
            this.btnModifierBateau.TabIndex = 1;
            this.btnModifierBateau.Text = "Modifier";
            this.btnModifierBateau.UseVisualStyleBackColor = true;
            this.btnModifierBateau.Click += new System.EventHandler(this.btnModifierBateau_Click);
            // 
            // gbxModifierBateau
            // 
            this.gbxModifierBateau.Location = new System.Drawing.Point(520, 58);
            this.gbxModifierBateau.Name = "gbxModifierBateau";
            this.gbxModifierBateau.Size = new System.Drawing.Size(225, 273);
            this.gbxModifierBateau.TabIndex = 2;
            this.gbxModifierBateau.TabStop = false;
            this.gbxModifierBateau.Text = "Capacités Maximales";
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxModifierBateau);
            this.Controls.Add(this.btnModifierBateau);
            this.Controls.Add(this.cmbNomBateauModif);
            this.Name = "FormModifierBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNomBateauModif;
        private System.Windows.Forms.Button btnModifierBateau;
        private System.Windows.Forms.GroupBox gbxModifierBateau;
    }
}