namespace Projet_Atlantik
{
    partial class FormAjouterLiaison
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
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.lbxNomSecteur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(304, 141);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(95, 21);
            this.cmbDepart.TabIndex = 1;
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(489, 141);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(118, 21);
            this.cmbArrivee.TabIndex = 2;
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(489, 250);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 3;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(409, 257);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance :";
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(489, 339);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterLiaison.TabIndex = 5;
            this.btnAjouterLiaison.Text = "Ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // lbxNomSecteur
            // 
            this.lbxNomSecteur.FormattingEnabled = true;
            this.lbxNomSecteur.Location = new System.Drawing.Point(46, 113);
            this.lbxNomSecteur.Name = "lbxNomSecteur";
            this.lbxNomSecteur.Size = new System.Drawing.Size(120, 95);
            this.lbxNomSecteur.TabIndex = 6;
            // 
            // FormAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxNomSecteur);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.cmbDepart);
            this.Name = "FormAjouterLiaison";
            this.Text = "Ajouter une liaison";
            this.Load += new System.EventHandler(this.FormAjouterLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivee;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAjouterLiaison;
        private System.Windows.Forms.ListBox lbxNomSecteur;
    }
}