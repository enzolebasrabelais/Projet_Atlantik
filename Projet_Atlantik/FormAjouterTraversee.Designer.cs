namespace Projet_Atlantik
{
    partial class FormAjouterTraversee
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
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivee = new System.Windows.Forms.DateTimePicker();
            this.lbxSecteursTraversee = new System.Windows.Forms.ListBox();
            this.cmbLiaisonsTraversee = new System.Windows.Forms.ComboBox();
            this.cmbBateauTraversee = new System.Windows.Forms.ComboBox();
            this.btnAjouterTraversee = new System.Windows.Forms.Button();
            this.lblSecteursTraversee = new System.Windows.Forms.Label();
            this.lblLiaisonTraversee = new System.Windows.Forms.Label();
            this.lblBateauTraversee = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "yyyy/MM/dd  HH:mm:00";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.Location = new System.Drawing.Point(490, 240);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 0;
            // 
            // dtpArrivee
            // 
            this.dtpArrivee.CustomFormat = "yyyy/MM/dd  HH:mm:00";
            this.dtpArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivee.Location = new System.Drawing.Point(490, 286);
            this.dtpArrivee.Name = "dtpArrivee";
            this.dtpArrivee.Size = new System.Drawing.Size(200, 20);
            this.dtpArrivee.TabIndex = 1;
            // 
            // lbxSecteursTraversee
            // 
            this.lbxSecteursTraversee.FormattingEnabled = true;
            this.lbxSecteursTraversee.Location = new System.Drawing.Point(70, 71);
            this.lbxSecteursTraversee.Name = "lbxSecteursTraversee";
            this.lbxSecteursTraversee.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteursTraversee.TabIndex = 2;
            this.lbxSecteursTraversee.SelectedIndexChanged += new System.EventHandler(this.lbxSecteursTraversee_SelectedIndexChanged);
            // 
            // cmbLiaisonsTraversee
            // 
            this.cmbLiaisonsTraversee.FormattingEnabled = true;
            this.cmbLiaisonsTraversee.Location = new System.Drawing.Point(70, 325);
            this.cmbLiaisonsTraversee.Name = "cmbLiaisonsTraversee";
            this.cmbLiaisonsTraversee.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonsTraversee.TabIndex = 3;
            // 
            // cmbBateauTraversee
            // 
            this.cmbBateauTraversee.FormattingEnabled = true;
            this.cmbBateauTraversee.Location = new System.Drawing.Point(490, 46);
            this.cmbBateauTraversee.Name = "cmbBateauTraversee";
            this.cmbBateauTraversee.Size = new System.Drawing.Size(121, 21);
            this.cmbBateauTraversee.TabIndex = 4;
            // 
            // btnAjouterTraversee
            // 
            this.btnAjouterTraversee.Location = new System.Drawing.Point(461, 343);
            this.btnAjouterTraversee.Name = "btnAjouterTraversee";
            this.btnAjouterTraversee.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTraversee.TabIndex = 5;
            this.btnAjouterTraversee.Text = "Ajouter";
            this.btnAjouterTraversee.UseVisualStyleBackColor = true;
            this.btnAjouterTraversee.Click += new System.EventHandler(this.btnAjouterTraversee_Click);
            // 
            // lblSecteursTraversee
            // 
            this.lblSecteursTraversee.AutoSize = true;
            this.lblSecteursTraversee.Location = new System.Drawing.Point(70, 31);
            this.lblSecteursTraversee.Name = "lblSecteursTraversee";
            this.lblSecteursTraversee.Size = new System.Drawing.Size(55, 13);
            this.lblSecteursTraversee.TabIndex = 6;
            this.lblSecteursTraversee.Text = "Secteurs :";
            // 
            // lblLiaisonTraversee
            // 
            this.lblLiaisonTraversee.AutoSize = true;
            this.lblLiaisonTraversee.Location = new System.Drawing.Point(73, 286);
            this.lblLiaisonTraversee.Name = "lblLiaisonTraversee";
            this.lblLiaisonTraversee.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonTraversee.TabIndex = 7;
            this.lblLiaisonTraversee.Text = "Liaison :";
            // 
            // lblBateauTraversee
            // 
            this.lblBateauTraversee.AutoSize = true;
            this.lblBateauTraversee.Location = new System.Drawing.Point(403, 53);
            this.lblBateauTraversee.Name = "lblBateauTraversee";
            this.lblBateauTraversee.Size = new System.Drawing.Size(71, 13);
            this.lblBateauTraversee.TabIndex = 8;
            this.lblBateauTraversee.Text = "Nom bateau :";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(347, 240);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(111, 13);
            this.lblDateDepart.TabIndex = 9;
            this.lblDateDepart.Text = "Date et heure départ :";
            // 
            // lblDateArrivee
            // 
            this.lblDateArrivee.AutoSize = true;
            this.lblDateArrivee.Location = new System.Drawing.Point(341, 292);
            this.lblDateArrivee.Name = "lblDateArrivee";
            this.lblDateArrivee.Size = new System.Drawing.Size(113, 13);
            this.lblDateArrivee.TabIndex = 10;
            this.lblDateArrivee.Text = "Date et heure arrivée :";
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateArrivee);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblBateauTraversee);
            this.Controls.Add(this.lblLiaisonTraversee);
            this.Controls.Add(this.lblSecteursTraversee);
            this.Controls.Add(this.btnAjouterTraversee);
            this.Controls.Add(this.cmbBateauTraversee);
            this.Controls.Add(this.cmbLiaisonsTraversee);
            this.Controls.Add(this.lbxSecteursTraversee);
            this.Controls.Add(this.dtpArrivee);
            this.Controls.Add(this.dtpDepart);
            this.Name = "FormAjouterTraversee";
            this.Text = "Ajouter une traversée";
            this.Load += new System.EventHandler(this.FormAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DateTimePicker dtpArrivee;
        private System.Windows.Forms.ListBox lbxSecteursTraversee;
        private System.Windows.Forms.ComboBox cmbLiaisonsTraversee;
        private System.Windows.Forms.ComboBox cmbBateauTraversee;
        private System.Windows.Forms.Button btnAjouterTraversee;
        private System.Windows.Forms.Label lblSecteursTraversee;
        private System.Windows.Forms.Label lblLiaisonTraversee;
        private System.Windows.Forms.Label lblBateauTraversee;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateArrivee;
    }
}