namespace Hotel.View
{
    partial class FormFacture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacture));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacture = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnCltt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.facturesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GestionHotelDataSet2 = new Hotel.View.DB_GestionHotelDataSet2();
            this.facturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionHotelDataSet = new Hotel.View.GestionHotelDataSet();
            this.facturesTableAdapter = new Hotel.View.GestionHotelDataSetTableAdapters.FacturesTableAdapter();
            this.tableAdapterManager = new Hotel.View.GestionHotelDataSetTableAdapters.TableAdapterManager();
            this.facturesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facturesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facturesTableAdapter1 = new Hotel.View.DB_GestionHotelDataSet2TableAdapters.FacturesTableAdapter();
            this.tableAdapterManager1 = new Hotel.View.DB_GestionHotelDataSet2TableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GestionHotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingNavigator)).BeginInit();
            this.facturesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnFacture);
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
            this.panel1.Size = new System.Drawing.Size(243, 634);
            this.panel1.TabIndex = 11;
            // 
            // btnFacture
            // 
            this.btnFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacture.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacture.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.btnFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacture.Location = new System.Drawing.Point(34, 436);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(155, 60);
            this.btnFacture.TabIndex = 7;
            this.btnFacture.Text = "    Facture";
            this.btnFacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacture.UseVisualStyleBackColor = true;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
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
            this.btnPromotion.Location = new System.Drawing.Point(34, 379);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(155, 60);
            this.btnPromotion.TabIndex = 5;
            this.btnPromotion.Text = "    Promotion";
            this.btnPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromotion.UseVisualStyleBackColor = true;
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
            this.btnRoom.Location = new System.Drawing.Point(34, 329);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(155, 60);
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "    Chambre";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
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
            this.btnReservation.Location = new System.Drawing.Point(34, 276);
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
            this.btnCltt.Location = new System.Drawing.Point(34, 224);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(288, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 585);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.facturesDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion des Promotions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // facturesDataGridView
            // 
            this.facturesDataGridView.AutoGenerateColumns = false;
            this.facturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.facturesDataGridView.DataSource = this.facturesBindingSource1;
            this.facturesDataGridView.Location = new System.Drawing.Point(116, 156);
            this.facturesDataGridView.Name = "facturesDataGridView";
            this.facturesDataGridView.Size = new System.Drawing.Size(492, 220);
            this.facturesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdFacture";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdFacture";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateFacture";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateFacture";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReservationId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ReservationId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // facturesBindingSource1
            // 
            this.facturesBindingSource1.DataMember = "Factures";
            this.facturesBindingSource1.DataSource = this.dB_GestionHotelDataSet2;
            // 
            // dB_GestionHotelDataSet2
            // 
            this.dB_GestionHotelDataSet2.DataSetName = "DB_GestionHotelDataSet2";
            this.dB_GestionHotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturesBindingSource
            // 
            this.facturesBindingSource.DataMember = "Factures";
            this.facturesBindingSource.DataSource = this.gestionHotelDataSet;
            // 
            // gestionHotelDataSet
            // 
            this.gestionHotelDataSet.DataSetName = "GestionHotelDataSet";
            this.gestionHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturesTableAdapter
            // 
            this.facturesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambresTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.DisponibilitesTableAdapter = null;
            this.tableAdapterManager.FacturesTableAdapter = this.facturesTableAdapter;
            this.tableAdapterManager.PromotionsTableAdapter = null;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.View.GestionHotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // facturesBindingNavigator
            // 
            this.facturesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facturesBindingNavigator.BindingSource = this.facturesBindingSource;
            this.facturesBindingNavigator.CanOverflow = false;
            this.facturesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.facturesBindingNavigatorSaveItem});
            this.facturesBindingNavigator.Location = new System.Drawing.Point(243, 0);
            this.facturesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturesBindingNavigator.Name = "facturesBindingNavigator";
            this.facturesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturesBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.facturesBindingNavigator.TabIndex = 15;
            this.facturesBindingNavigator.Text = "bindingNavigator1";
            this.facturesBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // facturesBindingNavigatorSaveItem
            // 
            this.facturesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturesBindingNavigatorSaveItem.Image")));
            this.facturesBindingNavigatorSaveItem.Name = "facturesBindingNavigatorSaveItem";
            this.facturesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.facturesBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturesBindingNavigatorSaveItem_Click);
            // 
            // facturesTableAdapter1
            // 
            this.facturesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChambresTableAdapter = null;
            this.tableAdapterManager1.ClientsTableAdapter = null;
            this.tableAdapterManager1.DisponibilitesTableAdapter = null;
            this.tableAdapterManager1.FacturesTableAdapter = this.facturesTableAdapter1;
            this.tableAdapterManager1.PromotionsTableAdapter = null;
            this.tableAdapterManager1.ReservationsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Hotel.View.DB_GestionHotelDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 634);
            this.Controls.Add(this.facturesBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFacture";
            this.Text = "FormFacture";
            this.Load += new System.EventHandler(this.FormFacture_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GestionHotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingNavigator)).EndInit();
            this.facturesBindingNavigator.ResumeLayout(false);
            this.facturesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnCltt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private GestionHotelDataSet gestionHotelDataSet;
        private System.Windows.Forms.BindingSource facturesBindingSource;
        private GestionHotelDataSetTableAdapters.FacturesTableAdapter facturesTableAdapter;
        private GestionHotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facturesBindingNavigatorSaveItem;
        private DB_GestionHotelDataSet2 dB_GestionHotelDataSet2;
        private System.Windows.Forms.BindingSource facturesBindingSource1;
        private DB_GestionHotelDataSet2TableAdapters.FacturesTableAdapter facturesTableAdapter1;
        private DB_GestionHotelDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView facturesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}