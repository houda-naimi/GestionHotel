namespace Hotel.View
{
    partial class FormChambreControl
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
            this.tabControlChambre = new System.Windows.Forms.TabControl();
            this.tabPageAjouterChambre = new System.Windows.Forms.TabPage();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixAjouté = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageModifierChambre = new System.Windows.Forms.TabPage();
            this.tabPageChercherChambre = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.tabControlChambre.SuspendLayout();
            this.tabPageAjouterChambre.SuspendLayout();
            this.tabPageChercherChambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlChambre
            // 
            this.tabControlChambre.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlChambre.Controls.Add(this.tabPageAjouterChambre);
            this.tabControlChambre.Controls.Add(this.tabPageModifierChambre);
            this.tabControlChambre.Controls.Add(this.tabPageChercherChambre);
            this.tabControlChambre.Location = new System.Drawing.Point(217, 104);
            this.tabControlChambre.Name = "tabControlChambre";
            this.tabControlChambre.SelectedIndex = 0;
            this.tabControlChambre.Size = new System.Drawing.Size(850, 417);
            this.tabControlChambre.TabIndex = 0;
            // 
            // tabPageAjouterChambre
            // 
            this.tabPageAjouterChambre.Controls.Add(this.comboBoxType);
            this.tabPageAjouterChambre.Controls.Add(this.label4);
            this.tabPageAjouterChambre.Controls.Add(this.btnAjouterChambre);
            this.tabPageAjouterChambre.Controls.Add(this.label3);
            this.tabPageAjouterChambre.Controls.Add(this.txtPrixAjouté);
            this.tabPageAjouterChambre.Controls.Add(this.label2);
            this.tabPageAjouterChambre.Location = new System.Drawing.Point(4, 4);
            this.tabPageAjouterChambre.Name = "tabPageAjouterChambre";
            this.tabPageAjouterChambre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjouterChambre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageAjouterChambre.Size = new System.Drawing.Size(842, 391);
            this.tabPageAjouterChambre.TabIndex = 0;
            this.tabPageAjouterChambre.Text = "Ajouter Chambre";
            this.tabPageAjouterChambre.UseVisualStyleBackColor = true;
            this.tabPageAjouterChambre.Click += new System.EventHandler(this.tabPageAjouterChambre_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(438, 172);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(203, 21);
            this.comboBoxType.TabIndex = 12;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(43, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ajouter une chambre";
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterChambre.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterChambre.ForeColor = System.Drawing.Color.White;
            this.btnAjouterChambre.Location = new System.Drawing.Point(204, 208);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(91, 35);
            this.btnAjouterChambre.TabIndex = 10;
            this.btnAjouterChambre.Text = "Ajouter";
            this.btnAjouterChambre.UseVisualStyleBackColor = false;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type chambre : ";
            // 
            // txtPrixAjouté
            // 
            this.txtPrixAjouté.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrixAjouté.Location = new System.Drawing.Point(204, 173);
            this.txtPrixAjouté.Name = "txtPrixAjouté";
            this.txtPrixAjouté.Size = new System.Drawing.Size(203, 20);
            this.txtPrixAjouté.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix par séjour :";
            // 
            // tabPageModifierChambre
            // 
            this.tabPageModifierChambre.Location = new System.Drawing.Point(4, 4);
            this.tabPageModifierChambre.Name = "tabPageModifierChambre";
            this.tabPageModifierChambre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModifierChambre.Size = new System.Drawing.Size(842, 391);
            this.tabPageModifierChambre.TabIndex = 1;
            this.tabPageModifierChambre.Text = "Modifier Chambre";
            this.tabPageModifierChambre.UseVisualStyleBackColor = true;
            // 
            // tabPageChercherChambre
            // 
            this.tabPageChercherChambre.Controls.Add(this.dataGridView1);
            this.tabPageChercherChambre.Controls.Add(this.button1);
            this.tabPageChercherChambre.Controls.Add(this.textBox2);
            this.tabPageChercherChambre.Controls.Add(this.label5);
            this.tabPageChercherChambre.Controls.Add(this.label1);
            this.tabPageChercherChambre.Location = new System.Drawing.Point(4, 4);
            this.tabPageChercherChambre.Name = "tabPageChercherChambre";
            this.tabPageChercherChambre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChercherChambre.Size = new System.Drawing.Size(842, 391);
            this.tabPageChercherChambre.TabIndex = 2;
            this.tabPageChercherChambre.Text = "Chercher Chambre";
            this.tabPageChercherChambre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(22, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(730, 204);
            this.dataGridView1.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Chambre_IdCh";
            this.ID.HeaderText = "Réference";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Chambre_TypeChambre";
            this.Column1.HeaderText = "Type de la chambre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Chambre_PrixParJour";
            this.Column2.HeaderText = "Prix par séjour";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(85, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Référence Chambre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher une chambre";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(31, 44);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "retour ";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FormChambreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 634);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.tabControlChambre);
            this.Name = "FormChambreControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChambreControl";
            this.Load += new System.EventHandler(this.FormChambreControl_Load);
            this.tabControlChambre.ResumeLayout(false);
            this.tabPageAjouterChambre.ResumeLayout(false);
            this.tabPageAjouterChambre.PerformLayout();
            this.tabPageChercherChambre.ResumeLayout(false);
            this.tabPageChercherChambre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChambre;
        private System.Windows.Forms.TabPage tabPageAjouterChambre;
        private System.Windows.Forms.TabPage tabPageModifierChambre;
        private System.Windows.Forms.TabPage tabPageChercherChambre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixAjouté;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRetour;
    }
}