namespace Hotel.View.ClientControl
{
    partial class ClientControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAjouterClient = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientsTableAdapter1 = new Hotel.View.GestionHotelDataSetTableAdapters.ClientsTableAdapter();
            this.tabControlAjouterClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAjouterClient
            // 
            this.tabControlAjouterClient.Controls.Add(this.tabPage1);
            this.tabControlAjouterClient.Controls.Add(this.tabPage2);
            this.tabControlAjouterClient.Controls.Add(this.tabPage3);
            this.tabControlAjouterClient.Location = new System.Drawing.Point(37, 43);
            this.tabControlAjouterClient.Name = "tabControlAjouterClient";
            this.tabControlAjouterClient.SelectedIndex = 0;
            this.tabControlAjouterClient.Size = new System.Drawing.Size(724, 395);
            this.tabControlAjouterClient.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modifier Cient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Supprimer Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAjouterClient);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(807, 488);
            this.tabControlAjouterClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAjouterClient;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private GestionHotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter1;
    }
}
