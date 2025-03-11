namespace Projet_Atlantik
{
    partial class FormAjouterPort
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
            this.tbxAjouterPort = new System.Windows.Forms.TextBox();
            this.btnAjouterPort = new System.Windows.Forms.Button();
            this.lblNomPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxAjouterPort
            // 
            this.tbxAjouterPort.Location = new System.Drawing.Point(336, 200);
            this.tbxAjouterPort.Name = "tbxAjouterPort";
            this.tbxAjouterPort.Size = new System.Drawing.Size(100, 20);
            this.tbxAjouterPort.TabIndex = 0;
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.Location = new System.Drawing.Point(387, 298);
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPort.TabIndex = 1;
            this.btnAjouterPort.Text = "Ajouter";
            this.btnAjouterPort.UseVisualStyleBackColor = true;
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // lblNomPort
            // 
            this.lblNomPort.AutoSize = true;
            this.lblNomPort.Location = new System.Drawing.Point(204, 206);
            this.lblNomPort.Name = "lblNomPort";
            this.lblNomPort.Size = new System.Drawing.Size(51, 13);
            this.lblNomPort.TabIndex = 2;
            this.lblNomPort.Text = "Nom Port";
            // 
            // FormAjouterPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomPort);
            this.Controls.Add(this.btnAjouterPort);
            this.Controls.Add(this.tbxAjouterPort);
            this.Name = "FormAjouterPort";
            this.Text = "FormAjouterPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAjouterPort;
        private System.Windows.Forms.Button btnAjouterPort;
        private System.Windows.Forms.Label lblNomPort;
    }
}