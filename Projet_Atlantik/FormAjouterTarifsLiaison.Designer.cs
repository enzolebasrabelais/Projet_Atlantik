namespace Projet_Atlantik
{
    partial class FormAjouterTarifsLiaison
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
            this.gbxTarifsCategorieType = new System.Windows.Forms.GroupBox();
            this.lbxSecteursAjouterTarifs = new System.Windows.Forms.ListBox();
            this.cmbLiaisonAjouterTarifs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gbxTarifsCategorieType
            // 
            this.gbxTarifsCategorieType.Location = new System.Drawing.Point(466, 53);
            this.gbxTarifsCategorieType.Name = "gbxTarifsCategorieType";
            this.gbxTarifsCategorieType.Size = new System.Drawing.Size(235, 236);
            this.gbxTarifsCategorieType.TabIndex = 0;
            this.gbxTarifsCategorieType.TabStop = false;
            this.gbxTarifsCategorieType.Text = "Tarifs par Catégorie-Type";
            // 
            // lbxSecteursAjouterTarifs
            // 
            this.lbxSecteursAjouterTarifs.FormattingEnabled = true;
            this.lbxSecteursAjouterTarifs.Location = new System.Drawing.Point(70, 53);
            this.lbxSecteursAjouterTarifs.Name = "lbxSecteursAjouterTarifs";
            this.lbxSecteursAjouterTarifs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteursAjouterTarifs.TabIndex = 1;
            this.lbxSecteursAjouterTarifs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteursAjouterTarifs_SelectedIndexChanged);
            // 
            // cmbLiaisonAjouterTarifs
            // 
            this.cmbLiaisonAjouterTarifs.FormattingEnabled = true;
            this.cmbLiaisonAjouterTarifs.Location = new System.Drawing.Point(70, 234);
            this.cmbLiaisonAjouterTarifs.Name = "cmbLiaisonAjouterTarifs";
            this.cmbLiaisonAjouterTarifs.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonAjouterTarifs.TabIndex = 2;
            // 
            // FormAjouterTarifsLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLiaisonAjouterTarifs);
            this.Controls.Add(this.lbxSecteursAjouterTarifs);
            this.Controls.Add(this.gbxTarifsCategorieType);
            this.Name = "FormAjouterTarifsLiaison";
            this.Text = "Ajouter les tarifs pour une liaison et une période";
            this.Load += new System.EventHandler(this.FormAjouterTarifsLiaison_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarifsCategorieType;
        private System.Windows.Forms.ListBox lbxSecteursAjouterTarifs;
        private System.Windows.Forms.ComboBox cmbLiaisonAjouterTarifs;
    }
}