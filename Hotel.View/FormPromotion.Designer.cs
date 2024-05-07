namespace Hotel.View
{
    partial class FormPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromotion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnValider = new System.Windows.Forms.Button();
            this.comboBoxTypePromo = new System.Windows.Forms.ComboBox();
            this.promotionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionHotelDataSet = new Hotel.View.GestionHotelDataSet();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacture = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnCltt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.promotionsTableAdapter = new Hotel.View.GestionHotelDataSetTableAdapters.PromotionsTableAdapter();
            this.tableAdapterManager = new Hotel.View.GestionHotelDataSetTableAdapters.TableAdapterManager();
            this.promotionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.promotionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionHotelDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingNavigator)).BeginInit();
            this.promotionsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(292, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 585);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnValider);
            this.tabPage1.Controls.Add(this.comboBoxTypePromo);
            this.tabPage1.Controls.Add(this.promotionsDataGridView);
            this.tabPage1.Controls.Add(this.btnSupprimer);
            this.tabPage1.Controls.Add(this.btnModifier);
            this.tabPage1.Controls.Add(this.btnAddPromo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtRemise);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion des Promotions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(694, 134);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 31);
            this.btnValider.TabIndex = 28;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // comboBoxTypePromo
            // 
            this.comboBoxTypePromo.FormattingEnabled = true;
            this.comboBoxTypePromo.Location = new System.Drawing.Point(261, 98);
            this.comboBoxTypePromo.Name = "comboBoxTypePromo";
            this.comboBoxTypePromo.Size = new System.Drawing.Size(272, 25);
            this.comboBoxTypePromo.TabIndex = 27;
            // 
            // promotionsDataGridView
            // 
            this.promotionsDataGridView.AutoGenerateColumns = false;
            this.promotionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.promotionsDataGridView.DataSource = this.promotionsBindingSource;
            this.promotionsDataGridView.Location = new System.Drawing.Point(83, 249);
            this.promotionsDataGridView.Name = "promotionsDataGridView";
            this.promotionsDataGridView.Size = new System.Drawing.Size(736, 220);
            this.promotionsDataGridView.TabIndex = 26;
            this.promotionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.promotionsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPromotion";
            this.dataGridViewTextBoxColumn1.HeaderText = "idPromotion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypePromotion";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypePromotion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remise";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remise";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // promotionsBindingSource
            // 
            this.promotionsBindingSource.DataMember = "Promotions";
            this.promotionsBindingSource.DataSource = this.gestionHotelDataSet;
            // 
            // gestionHotelDataSet
            // 
            this.gestionHotelDataSet.DataSetName = "GestionHotelDataSet";
            this.gestionHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(694, 171);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 31);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(694, 95);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 31);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddPromo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPromo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPromo.Location = new System.Drawing.Point(694, 51);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.Size = new System.Drawing.Size(111, 31);
            this.btnAddPromo.TabIndex = 12;
            this.btnAddPromo.Text = "Ajouter";
            this.btnAddPromo.UseVisualStyleBackColor = false;
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remise : ";
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(261, 167);
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(272, 23);
            this.txtRemise.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type de Promotion : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnFacture);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnCltt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 634);
            this.panel1.TabIndex = 12;
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
            this.btnFacture.Location = new System.Drawing.Point(34, 456);
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Hotel.View.Properties.Resources.icons8_dashboard_20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(34, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "    Promotion";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // promotionsTableAdapter
            // 
            this.promotionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambresTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.DisponibilitesTableAdapter = null;
            this.tableAdapterManager.FacturesTableAdapter = null;
            this.tableAdapterManager.PromotionsTableAdapter = this.promotionsTableAdapter;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.View.GestionHotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // promotionsBindingNavigator
            // 
            this.promotionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.promotionsBindingNavigator.BindingSource = this.promotionsBindingSource;
            this.promotionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.promotionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.promotionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.promotionsBindingNavigatorSaveItem});
            this.promotionsBindingNavigator.Location = new System.Drawing.Point(243, 0);
            this.promotionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.promotionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.promotionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.promotionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.promotionsBindingNavigator.Name = "promotionsBindingNavigator";
            this.promotionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.promotionsBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.promotionsBindingNavigator.TabIndex = 14;
            this.promotionsBindingNavigator.Text = "bindingNavigator1";
            this.promotionsBindingNavigator.RefreshItems += new System.EventHandler(this.promotionsBindingNavigator_RefreshItems);
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
            // promotionsBindingNavigatorSaveItem
            // 
            this.promotionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.promotionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("promotionsBindingNavigatorSaveItem.Image")));
            this.promotionsBindingNavigatorSaveItem.Name = "promotionsBindingNavigatorSaveItem";
            this.promotionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.promotionsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.promotionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.promotionsBindingNavigatorSaveItem_Click);
            // 
            // FormPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 634);
            this.Controls.Add(this.promotionsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPromotion";
            this.Text = "FormPromotion";
            this.Load += new System.EventHandler(this.FormPromotion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionHotelDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingNavigator)).EndInit();
            this.promotionsBindingNavigator.ResumeLayout(false);
            this.promotionsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnCltt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private GestionHotelDataSet gestionHotelDataSet;
        private System.Windows.Forms.BindingSource promotionsBindingSource;
        private GestionHotelDataSetTableAdapters.PromotionsTableAdapter promotionsTableAdapter;
        private GestionHotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator promotionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton promotionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView promotionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBoxTypePromo;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFacture;
    }
}