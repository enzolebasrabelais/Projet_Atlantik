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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // FormAjouterTarifsLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbxTarifsCategorieType);
            this.Name = "FormAjouterTarifsLiaison";
            this.Text = "Ajouter les tarifs pour une liaison et une période";
            this.Load += new System.EventHandler(this.FormAjouterTarifsLiaison_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarifsCategorieType;
        private System.Windows.Forms.ListBox listBox1;
    }
}