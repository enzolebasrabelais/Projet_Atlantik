namespace Projet_Atlantik
{
    partial class formAjouterSecteur
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
            this.tbxNomSecteur = new System.Windows.Forms.TextBox();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNomSecteur
            // 
            this.tbxNomSecteur.Location = new System.Drawing.Point(411, 154);
            this.tbxNomSecteur.Name = "tbxNomSecteur";
            this.tbxNomSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxNomSecteur.TabIndex = 0;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(411, 199);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSecteur.TabIndex = 1;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(292, 174);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(73, 13);
            this.lblNomSecteur.TabIndex = 2;
            this.lblNomSecteur.Text = "Nom secteur :";
            // 
            // formAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomSecteur);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.tbxNomSecteur);
            this.Name = "formAjouterSecteur";
            this.Text = "formAjouterSecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomSecteur;
        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.Label lblNomSecteur;
    }
}