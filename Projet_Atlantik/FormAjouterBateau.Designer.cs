namespace Projet_Atlantik
{
    partial class FormAjouterBateau
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
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.btnAjouterBateau = new System.Windows.Forms.Button();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(114, 85);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBateau.TabIndex = 0;
            // 
            // btnAjouterBateau
            // 
            this.btnAjouterBateau.Location = new System.Drawing.Point(99, 346);
            this.btnAjouterBateau.Name = "btnAjouterBateau";
            this.btnAjouterBateau.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterBateau.TabIndex = 1;
            this.btnAjouterBateau.Text = "Ajouter";
            this.btnAjouterBateau.UseVisualStyleBackColor = true;
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(26, 91);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomBateau.TabIndex = 2;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // FormAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.btnAjouterBateau);
            this.Controls.Add(this.tbxNomBateau);
            this.Name = "FormAjouterBateau";
            this.Text = "Ajouter un bateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Button btnAjouterBateau;
        private System.Windows.Forms.Label lblNomBateau;
    }
}