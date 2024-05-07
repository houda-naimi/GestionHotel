namespace Hotel.View
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClient = new System.Windows.Forms.Button();
            this.btnChambre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnCltt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientControl2 = new Hotel.View.ClientControl.ClientControl();
            this.clientControl1 = new Hotel.View.ClientControl.ClientControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1042, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "hello";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.Location = new System.Drawing.Point(1210, 164);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(75, 25);
            this.BtnClient.TabIndex = 2;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // btnChambre
            // 
            this.btnChambre.Location = new System.Drawing.Point(1087, 164);
            this.btnChambre.Name = "btnChambre";
            this.btnChambre.Size = new System.Drawing.Size(117, 25);
            this.btnChambre.TabIndex = 3;
            this.btnChambre.Text = "Chambre";
            this.btnChambre.UseVisualStyleBackColor = true;
            this.btnChambre.Click += new System.EventHandler(this.btnChambre_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnPromotion);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnCltt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 753);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Location = new System.Drawing.Point(20, 190);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 41);
            this.panel6.TabIndex = 6;
            // 
            // btnPromotion
            // 
            this.btnPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromotion.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPromotion.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromotion.Location = new System.Drawing.Point(34, 408);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(155, 60);
            this.btnPromotion.TabIndex = 5;
            this.btnPromotion.Text = "    Promotion";
            this.btnPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRoom.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(34, 353);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(155, 60);
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "    Chambre";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservation.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(34, 290);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(155, 60);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "    Reservation";
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnCltt
            // 
            this.btnCltt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCltt.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnCltt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCltt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCltt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCltt.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnCltt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCltt.Location = new System.Drawing.Point(34, 234);
            this.btnCltt.Name = "btnCltt";
            this.btnCltt.Size = new System.Drawing.Size(155, 60);
            this.btnCltt.TabIndex = 2;
            this.btnCltt.Text = "    Client";
            this.btnCltt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCltt.UseVisualStyleBackColor = true;
            this.btnCltt.Click += new System.EventHandler(this.btnCltt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 161);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application de Gestion Hotel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.View.Properties.Resources.icons8_home_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(71, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(34, 180);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(155, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(243, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 158);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.labelDate);
            this.panel5.Controls.Add(this.labelLogOut);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1132, 70);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 45);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 17);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label4";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Location = new System.Drawing.Point(761, 45);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(92, 17);
            this.labelLogOut.TabIndex = 1;
            this.labelLogOut.Text = "déconnexion";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.View.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(705, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(243, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 43);
            this.panel2.TabIndex = 5;
            // 
            // clientControl2
            // 
            this.clientControl2.BackColor = System.Drawing.Color.White;
            this.clientControl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientControl2.Location = new System.Drawing.Point(338, 290);
            this.clientControl2.Margin = new System.Windows.Forms.Padding(4);
            this.clientControl2.Name = "clientControl2";
            this.clientControl2.Size = new System.Drawing.Size(807, 488);
            this.clientControl2.TabIndex = 7;
            this.clientControl2.Load += new System.EventHandler(this.clientControl2_Load);
            // 
            // clientControl1
            // 
            this.clientControl1.BackColor = System.Drawing.Color.White;
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientControl1.Location = new System.Drawing.Point(243, 158);
            this.clientControl1.Margin = new System.Windows.Forms.Padding(4);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(1132, 552);
            this.clientControl1.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 753);
            this.Controls.Add(this.clientControl2);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChambre);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application de Gestion Hotel | Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button btnChambre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnCltt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPromotion;
        private ClientControl.ClientControl clientControl1;
        private ChambreControl chambreControl;
        private ChambreControl chambreControl1;
        private ClientControl.ClientControl clientControl2;
    }
}