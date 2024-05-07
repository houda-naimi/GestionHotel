namespace Hotel.View
{
    partial class ChambreControl
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
            this.tabControlChambre = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixAjouté = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlChambre.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChambre
            // 
            this.tabControlChambre.CausesValidation = false;
            this.tabControlChambre.Controls.Add(this.tabPage1);
            this.tabControlChambre.Controls.Add(this.tabPage2);
            this.tabControlChambre.Location = new System.Drawing.Point(64, 44);
            this.tabControlChambre.Name = "tabControlChambre";
            this.tabControlChambre.SelectedIndex = 0;
            this.tabControlChambre.Size = new System.Drawing.Size(709, 400);
            this.tabControlChambre.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAjouterChambre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPrixAjouté);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(305, 108);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(203, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ajouter une chambre";
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterChambre.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterChambre.ForeColor = System.Drawing.Color.White;
            this.btnAjouterChambre.Location = new System.Drawing.Point(71, 144);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(91, 35);
            this.btnAjouterChambre.TabIndex = 16;
            this.btnAjouterChambre.Text = "Ajouter";
            this.btnAjouterChambre.UseVisualStyleBackColor = false;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type chambre : ";
            // 
            // txtPrixAjouté
            // 
            this.txtPrixAjouté.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrixAjouté.Location = new System.Drawing.Point(71, 109);
            this.txtPrixAjouté.Name = "txtPrixAjouté";
            this.txtPrixAjouté.Size = new System.Drawing.Size(203, 20);
            this.txtPrixAjouté.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prix par séjour :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChambreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlChambre);
            this.Name = "ChambreControl";
            this.Size = new System.Drawing.Size(792, 494);
            this.Load += new System.EventHandler(this.ChambreControl_Load);
            this.tabControlChambre.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChambre;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixAjouté;
        private System.Windows.Forms.Label label2;
    }
}
