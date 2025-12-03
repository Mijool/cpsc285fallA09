namespace VS_a09
{
    partial class frmDrivingSchool
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
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label cNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label staffIDLabel;
            System.Windows.Forms.Label sNameLabel;
            System.Windows.Forms.Label sTypeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sNameLabel1;
            System.Windows.Forms.Label sTypeLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label cNameLabel1;
            System.Windows.Forms.Label ageLabel1;
            System.Windows.Forms.Label genderLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivingSchool));
            this.tabControl_DONotEDIT = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnScheduleClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoMonthClients = new System.Windows.Forms.RadioButton();
            this.rdoWeekClients = new System.Windows.Forms.RadioButton();
            this.rdoTodayClients = new System.Windows.Forms.RadioButton();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f25_285ADataSet = new VS_a09.F25_285ADataSet();
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
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.tabInstructors = new System.Windows.Forms.TabPage();
            this.btnScheduleClass_1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoMonthInstructors = new System.Windows.Forms.RadioButton();
            this.rdoWeekInstructors = new System.Windows.Forms.RadioButton();
            this.rdoTodayInstructors = new System.Windows.Forms.RadioButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.classesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sTypeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.tabAddClients = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddClientToDBO = new System.Windows.Forms.Button();
            this.tabScheduleClass = new System.Windows.Forms.TabPage();
            this.btnInsertScheduledClass = new System.Windows.Forms.Button();
            this.cNameComboBox = new System.Windows.Forms.ComboBox();
            this.ageTextBox1 = new System.Windows.Forms.TextBox();
            this.genderTextBox1 = new System.Windows.Forms.TextBox();
            this.sNameComboBox = new System.Windows.Forms.ComboBox();
            this.sTypeTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new VS_a09.F25_285ADataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new VS_a09.F25_285ADataSetTableAdapters.TableAdapterManager();
            this.classesTableAdapter = new VS_a09.F25_285ADataSetTableAdapters.ClassesTableAdapter();
            this.staffTableAdapter = new VS_a09.F25_285ADataSetTableAdapters.StaffTableAdapter();
            clientIDLabel = new System.Windows.Forms.Label();
            cNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            staffIDLabel = new System.Windows.Forms.Label();
            sNameLabel = new System.Windows.Forms.Label();
            sTypeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sNameLabel1 = new System.Windows.Forms.Label();
            sTypeLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            cNameLabel1 = new System.Windows.Forms.Label();
            ageLabel1 = new System.Windows.Forms.Label();
            genderLabel1 = new System.Windows.Forms.Label();
            this.tabControl_DONotEDIT.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f25_285ADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.tabInstructors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            this.tabAddClients.SuspendLayout();
            this.tabScheduleClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(32, 42);
            clientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 0;
            clientIDLabel.Text = "Client ID:";
            // 
            // cNameLabel
            // 
            cNameLabel.AutoSize = true;
            cNameLabel.Location = new System.Drawing.Point(32, 65);
            cNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cNameLabel.Name = "cNameLabel";
            cNameLabel.Size = new System.Drawing.Size(45, 13);
            cNameLabel.TabIndex = 2;
            cNameLabel.Text = "CName:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(32, 88);
            ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(32, 110);
            genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(34, 50);
            staffIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(46, 13);
            staffIDLabel.TabIndex = 0;
            staffIDLabel.Text = "Staff ID:";
            // 
            // sNameLabel
            // 
            sNameLabel.AutoSize = true;
            sNameLabel.Location = new System.Drawing.Point(34, 72);
            sNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sNameLabel.Name = "sNameLabel";
            sNameLabel.Size = new System.Drawing.Size(45, 13);
            sNameLabel.TabIndex = 2;
            sNameLabel.Text = "SName:";
            // 
            // sTypeLabel
            // 
            sTypeLabel.AutoSize = true;
            sTypeLabel.Location = new System.Drawing.Point(34, 95);
            sTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sTypeLabel.Name = "sTypeLabel";
            sTypeLabel.Size = new System.Drawing.Size(41, 13);
            sTypeLabel.TabIndex = 4;
            sTypeLabel.Text = "SType:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(34, 118);
            phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // sNameLabel1
            // 
            sNameLabel1.AutoSize = true;
            sNameLabel1.Location = new System.Drawing.Point(113, 132);
            sNameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sNameLabel1.Name = "sNameLabel1";
            sNameLabel1.Size = new System.Drawing.Size(45, 13);
            sNameLabel1.TabIndex = 2;
            sNameLabel1.Text = "SName:";
            // 
            // sTypeLabel1
            // 
            sTypeLabel1.AutoSize = true;
            sTypeLabel1.Location = new System.Drawing.Point(113, 156);
            sTypeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sTypeLabel1.Name = "sTypeLabel1";
            sTypeLabel1.Size = new System.Drawing.Size(41, 13);
            sTypeLabel1.TabIndex = 4;
            sTypeLabel1.Text = "SType:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(113, 179);
            phoneLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 6;
            phoneLabel1.Text = "Phone:";
            // 
            // cNameLabel1
            // 
            cNameLabel1.AutoSize = true;
            cNameLabel1.Location = new System.Drawing.Point(463, 134);
            cNameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cNameLabel1.Name = "cNameLabel1";
            cNameLabel1.Size = new System.Drawing.Size(45, 13);
            cNameLabel1.TabIndex = 10;
            cNameLabel1.Text = "CName:";
            // 
            // ageLabel1
            // 
            ageLabel1.AutoSize = true;
            ageLabel1.Location = new System.Drawing.Point(463, 158);
            ageLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ageLabel1.Name = "ageLabel1";
            ageLabel1.Size = new System.Drawing.Size(29, 13);
            ageLabel1.TabIndex = 12;
            ageLabel1.Text = "Age:";
            // 
            // genderLabel1
            // 
            genderLabel1.AutoSize = true;
            genderLabel1.Location = new System.Drawing.Point(463, 181);
            genderLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            genderLabel1.Name = "genderLabel1";
            genderLabel1.Size = new System.Drawing.Size(45, 13);
            genderLabel1.TabIndex = 14;
            genderLabel1.Text = "Gender:";
            // 
            // tabControl_DONotEDIT
            // 
            this.tabControl_DONotEDIT.Controls.Add(this.tabClients);
            this.tabControl_DONotEDIT.Controls.Add(this.tabInstructors);
            this.tabControl_DONotEDIT.Controls.Add(this.tabAddClients);
            this.tabControl_DONotEDIT.Controls.Add(this.tabScheduleClass);
            this.tabControl_DONotEDIT.Location = new System.Drawing.Point(4, 3);
            this.tabControl_DONotEDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl_DONotEDIT.Name = "tabControl_DONotEDIT";
            this.tabControl_DONotEDIT.SelectedIndex = 0;
            this.tabControl_DONotEDIT.Size = new System.Drawing.Size(783, 496);
            this.tabControl_DONotEDIT.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.AutoScroll = true;
            this.tabClients.Controls.Add(this.btnAddClient);
            this.tabClients.Controls.Add(this.btnScheduleClass);
            this.tabClients.Controls.Add(this.groupBox1);
            this.tabClients.Controls.Add(this.clientsBindingNavigator);
            this.tabClients.Controls.Add(this.classesDataGridView);
            this.tabClients.Controls.Add(clientIDLabel);
            this.tabClients.Controls.Add(this.clientIDTextBox);
            this.tabClients.Controls.Add(cNameLabel);
            this.tabClients.Controls.Add(this.cNameTextBox);
            this.tabClients.Controls.Add(ageLabel);
            this.tabClients.Controls.Add(this.ageTextBox);
            this.tabClients.Controls.Add(genderLabel);
            this.tabClients.Controls.Add(this.genderTextBox);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabClients.Size = new System.Drawing.Size(775, 470);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(364, 46);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(83, 35);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Add a new Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnScheduleClass
            // 
            this.btnScheduleClass.Location = new System.Drawing.Point(364, 102);
            this.btnScheduleClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScheduleClass.Name = "btnScheduleClass";
            this.btnScheduleClass.Size = new System.Drawing.Size(83, 32);
            this.btnScheduleClass.TabIndex = 10;
            this.btnScheduleClass.Text = "Schedule Class";
            this.btnScheduleClass.UseVisualStyleBackColor = true;
            this.btnScheduleClass.Click += new System.EventHandler(this.btnScheduleClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoMonthClients);
            this.groupBox1.Controls.Add(this.rdoWeekClients);
            this.groupBox1.Controls.Add(this.rdoTodayClients);
            this.groupBox1.Location = new System.Drawing.Point(467, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Client\'s classes scheduled for:";
            // 
            // rdoMonthClients
            // 
            this.rdoMonthClients.AutoSize = true;
            this.rdoMonthClients.Checked = true;
            this.rdoMonthClients.Location = new System.Drawing.Point(61, 100);
            this.rdoMonthClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMonthClients.Name = "rdoMonthClients";
            this.rdoMonthClients.Size = new System.Drawing.Size(78, 17);
            this.rdoMonthClients.TabIndex = 2;
            this.rdoMonthClients.TabStop = true;
            this.rdoMonthClients.Text = "This Month";
            this.rdoMonthClients.UseVisualStyleBackColor = true;
            this.rdoMonthClients.CheckedChanged += new System.EventHandler(this.rdoMonthClients_CheckedChanged);
            // 
            // rdoWeekClients
            // 
            this.rdoWeekClients.AutoSize = true;
            this.rdoWeekClients.Location = new System.Drawing.Point(61, 69);
            this.rdoWeekClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoWeekClients.Name = "rdoWeekClients";
            this.rdoWeekClients.Size = new System.Drawing.Size(77, 17);
            this.rdoWeekClients.TabIndex = 1;
            this.rdoWeekClients.Text = "This Week";
            this.rdoWeekClients.UseVisualStyleBackColor = true;
            this.rdoWeekClients.CheckedChanged += new System.EventHandler(this.rdoWeekClients_CheckedChanged);
            // 
            // rdoTodayClients
            // 
            this.rdoTodayClients.AutoSize = true;
            this.rdoTodayClients.Location = new System.Drawing.Point(61, 38);
            this.rdoTodayClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTodayClients.Name = "rdoTodayClients";
            this.rdoTodayClients.Size = new System.Drawing.Size(55, 17);
            this.rdoTodayClients.TabIndex = 0;
            this.rdoTodayClients.Text = "Today";
            this.rdoTodayClients.UseVisualStyleBackColor = true;
            this.rdoTodayClients.CheckedChanged += new System.EventHandler(this.rdoTodayClients_CheckedChanged);
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(2, 2);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(771, 27);
            this.clientsBindingNavigator.TabIndex = 1;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.f25_285ADataSet;
            // 
            // f25_285ADataSet
            // 
            this.f25_285ADataSet.DataSetName = "F25_285ADataSet";
            this.f25_285ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // classesDataGridView
            // 
            this.classesDataGridView.AutoGenerateColumns = false;
            this.classesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.classesDataGridView.DataSource = this.classesBindingSource;
            this.classesDataGridView.Location = new System.Drawing.Point(34, 176);
            this.classesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classesDataGridView.Name = "classesDataGridView";
            this.classesDataGridView.RowHeadersWidth = 51;
            this.classesDataGridView.RowTemplate.Height = 24;
            this.classesDataGridView.Size = new System.Drawing.Size(642, 256);
            this.classesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "CTime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn5.HeaderText = "StaffID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "FK_Classes_Client";
            this.classesBindingSource.DataSource = this.clientsBindingSource;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(84, 40);
            this.clientIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.clientIDTextBox.TabIndex = 1;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "CName", true));
            this.cNameTextBox.Location = new System.Drawing.Point(84, 63);
            this.cNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.ReadOnly = true;
            this.cNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.cNameTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(84, 85);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(76, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(84, 108);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(76, 20);
            this.genderTextBox.TabIndex = 7;
            // 
            // tabInstructors
            // 
            this.tabInstructors.Controls.Add(this.btnScheduleClass_1);
            this.tabInstructors.Controls.Add(this.groupBox2);
            this.tabInstructors.Controls.Add(this.bindingNavigator1);
            this.tabInstructors.Controls.Add(this.classesDataGridView1);
            this.tabInstructors.Controls.Add(staffIDLabel);
            this.tabInstructors.Controls.Add(this.staffIDTextBox);
            this.tabInstructors.Controls.Add(sNameLabel);
            this.tabInstructors.Controls.Add(this.sNameTextBox);
            this.tabInstructors.Controls.Add(sTypeLabel);
            this.tabInstructors.Controls.Add(this.sTypeTextBox);
            this.tabInstructors.Controls.Add(phoneLabel);
            this.tabInstructors.Controls.Add(this.phoneTextBox);
            this.tabInstructors.Location = new System.Drawing.Point(4, 22);
            this.tabInstructors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInstructors.Name = "tabInstructors";
            this.tabInstructors.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInstructors.Size = new System.Drawing.Size(775, 470);
            this.tabInstructors.TabIndex = 1;
            this.tabInstructors.Text = "Instructors";
            this.tabInstructors.UseVisualStyleBackColor = true;
            // 
            // btnScheduleClass_1
            // 
            this.btnScheduleClass_1.Location = new System.Drawing.Point(406, 85);
            this.btnScheduleClass_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScheduleClass_1.Name = "btnScheduleClass_1";
            this.btnScheduleClass_1.Size = new System.Drawing.Size(83, 32);
            this.btnScheduleClass_1.TabIndex = 12;
            this.btnScheduleClass_1.Text = "Schedule Class";
            this.btnScheduleClass_1.UseVisualStyleBackColor = true;
            this.btnScheduleClass_1.Click += new System.EventHandler(this.btnScheduleClass_1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdoMonthInstructors);
            this.groupBox2.Controls.Add(this.rdoWeekInstructors);
            this.groupBox2.Controls.Add(this.rdoTodayInstructors);
            this.groupBox2.Location = new System.Drawing.Point(510, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(218, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Instructors\' classes scheduled for:";
            // 
            // rdoMonthInstructors
            // 
            this.rdoMonthInstructors.AutoSize = true;
            this.rdoMonthInstructors.Checked = true;
            this.rdoMonthInstructors.Location = new System.Drawing.Point(61, 100);
            this.rdoMonthInstructors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMonthInstructors.Name = "rdoMonthInstructors";
            this.rdoMonthInstructors.Size = new System.Drawing.Size(78, 17);
            this.rdoMonthInstructors.TabIndex = 2;
            this.rdoMonthInstructors.TabStop = true;
            this.rdoMonthInstructors.Text = "This Month";
            this.rdoMonthInstructors.UseVisualStyleBackColor = true;
            this.rdoMonthInstructors.CheckedChanged += new System.EventHandler(this.rdoMonthInstructors_CheckedChanged);
            // 
            // rdoWeekInstructors
            // 
            this.rdoWeekInstructors.AutoSize = true;
            this.rdoWeekInstructors.Location = new System.Drawing.Point(61, 69);
            this.rdoWeekInstructors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoWeekInstructors.Name = "rdoWeekInstructors";
            this.rdoWeekInstructors.Size = new System.Drawing.Size(77, 17);
            this.rdoWeekInstructors.TabIndex = 1;
            this.rdoWeekInstructors.Text = "This Week";
            this.rdoWeekInstructors.UseVisualStyleBackColor = true;
            this.rdoWeekInstructors.CheckedChanged += new System.EventHandler(this.rdoWeekInstructors_CheckedChanged);
            // 
            // rdoTodayInstructors
            // 
            this.rdoTodayInstructors.AutoSize = true;
            this.rdoTodayInstructors.Location = new System.Drawing.Point(61, 38);
            this.rdoTodayInstructors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTodayInstructors.Name = "rdoTodayInstructors";
            this.rdoTodayInstructors.Size = new System.Drawing.Size(55, 17);
            this.rdoTodayInstructors.TabIndex = 0;
            this.rdoTodayInstructors.Text = "Today";
            this.rdoTodayInstructors.UseVisualStyleBackColor = true;
            this.rdoTodayInstructors.CheckedChanged += new System.EventHandler(this.rdoTodayInstructors_CheckedChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.staffBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 2);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(771, 27);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "staffBindingNavigator";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.f25_285ADataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // classesDataGridView1
            // 
            this.classesDataGridView1.AutoGenerateColumns = false;
            this.classesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.classesDataGridView1.DataSource = this.classesBindingSource1;
            this.classesDataGridView1.Location = new System.Drawing.Point(37, 167);
            this.classesDataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classesDataGridView1.Name = "classesDataGridView1";
            this.classesDataGridView1.RowHeadersWidth = 51;
            this.classesDataGridView1.RowTemplate.Height = 24;
            this.classesDataGridView1.Size = new System.Drawing.Size(691, 287);
            this.classesDataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "CDate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "CTime";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn10.HeaderText = "StaffID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // classesBindingSource1
            // 
            this.classesBindingSource1.DataMember = "FK_Classes_Staff";
            this.classesBindingSource1.DataSource = this.staffBindingSource;
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(82, 47);
            this.staffIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.staffIDTextBox.TabIndex = 1;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "SName", true));
            this.sNameTextBox.Location = new System.Drawing.Point(82, 70);
            this.sNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.ReadOnly = true;
            this.sNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.sNameTextBox.TabIndex = 3;
            // 
            // sTypeTextBox
            // 
            this.sTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "SType", true));
            this.sTypeTextBox.Location = new System.Drawing.Point(82, 93);
            this.sTypeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sTypeTextBox.Name = "sTypeTextBox";
            this.sTypeTextBox.ReadOnly = true;
            this.sTypeTextBox.Size = new System.Drawing.Size(76, 20);
            this.sTypeTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(82, 115);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(76, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // tabAddClients
            // 
            this.tabAddClients.Controls.Add(this.label6);
            this.tabAddClients.Controls.Add(this.label5);
            this.tabAddClients.Controls.Add(this.label4);
            this.tabAddClients.Controls.Add(this.label3);
            this.tabAddClients.Controls.Add(this.txtLastName);
            this.tabAddClients.Controls.Add(this.cboGender);
            this.tabAddClients.Controls.Add(this.txtAge);
            this.tabAddClients.Controls.Add(this.txtFirstName);
            this.tabAddClients.Controls.Add(this.btnAddClientToDBO);
            this.tabAddClients.Location = new System.Drawing.Point(4, 22);
            this.tabAddClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAddClients.Name = "tabAddClients";
            this.tabAddClients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAddClients.Size = new System.Drawing.Size(775, 470);
            this.tabAddClients.TabIndex = 2;
            this.tabAddClients.Text = "Add Client";
            this.tabAddClients.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(259, 168);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(114, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cboGender.Location = new System.Drawing.Point(259, 233);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(92, 21);
            this.cboGender.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(259, 201);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(45, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(259, 136);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnAddClientToDBO
            // 
            this.btnAddClientToDBO.Location = new System.Drawing.Point(440, 173);
            this.btnAddClientToDBO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClientToDBO.Name = "btnAddClientToDBO";
            this.btnAddClientToDBO.Size = new System.Drawing.Size(86, 37);
            this.btnAddClientToDBO.TabIndex = 0;
            this.btnAddClientToDBO.Text = "Add Client";
            this.btnAddClientToDBO.UseVisualStyleBackColor = true;
            this.btnAddClientToDBO.Click += new System.EventHandler(this.btnAddClientToDBO_Click);
            // 
            // tabScheduleClass
            // 
            this.tabScheduleClass.Controls.Add(this.btnInsertScheduledClass);
            this.tabScheduleClass.Controls.Add(cNameLabel1);
            this.tabScheduleClass.Controls.Add(this.cNameComboBox);
            this.tabScheduleClass.Controls.Add(ageLabel1);
            this.tabScheduleClass.Controls.Add(this.ageTextBox1);
            this.tabScheduleClass.Controls.Add(genderLabel1);
            this.tabScheduleClass.Controls.Add(this.genderTextBox1);
            this.tabScheduleClass.Controls.Add(sNameLabel1);
            this.tabScheduleClass.Controls.Add(this.sNameComboBox);
            this.tabScheduleClass.Controls.Add(sTypeLabel1);
            this.tabScheduleClass.Controls.Add(this.sTypeTextBox1);
            this.tabScheduleClass.Controls.Add(phoneLabel1);
            this.tabScheduleClass.Controls.Add(this.phoneTextBox1);
            this.tabScheduleClass.Location = new System.Drawing.Point(4, 22);
            this.tabScheduleClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabScheduleClass.Name = "tabScheduleClass";
            this.tabScheduleClass.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabScheduleClass.Size = new System.Drawing.Size(775, 470);
            this.tabScheduleClass.TabIndex = 3;
            this.tabScheduleClass.Text = "Schedule Class";
            this.tabScheduleClass.UseVisualStyleBackColor = true;
            // 
            // btnInsertScheduledClass
            // 
            this.btnInsertScheduledClass.Location = new System.Drawing.Point(311, 127);
            this.btnInsertScheduledClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertScheduledClass.Name = "btnInsertScheduledClass";
            this.btnInsertScheduledClass.Size = new System.Drawing.Size(104, 65);
            this.btnInsertScheduledClass.TabIndex = 16;
            this.btnInsertScheduledClass.Text = "Schedule this class";
            this.btnInsertScheduledClass.UseVisualStyleBackColor = true;
            this.btnInsertScheduledClass.Click += new System.EventHandler(this.btnInsertScheduledClass_Click);
            // 
            // cNameComboBox
            // 
            this.cNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "CName", true));
            this.cNameComboBox.FormattingEnabled = true;
            this.cNameComboBox.Location = new System.Drawing.Point(512, 132);
            this.cNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cNameComboBox.Name = "cNameComboBox";
            this.cNameComboBox.Size = new System.Drawing.Size(92, 21);
            this.cNameComboBox.TabIndex = 11;
            // 
            // ageTextBox1
            // 
            this.ageTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Age", true));
            this.ageTextBox1.Location = new System.Drawing.Point(512, 156);
            this.ageTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTextBox1.Name = "ageTextBox1";
            this.ageTextBox1.Size = new System.Drawing.Size(92, 20);
            this.ageTextBox1.TabIndex = 13;
            // 
            // genderTextBox1
            // 
            this.genderTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Gender", true));
            this.genderTextBox1.Location = new System.Drawing.Point(512, 179);
            this.genderTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderTextBox1.Name = "genderTextBox1";
            this.genderTextBox1.Size = new System.Drawing.Size(92, 20);
            this.genderTextBox1.TabIndex = 15;
            // 
            // sNameComboBox
            // 
            this.sNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "SName", true));
            this.sNameComboBox.FormattingEnabled = true;
            this.sNameComboBox.Location = new System.Drawing.Point(160, 129);
            this.sNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sNameComboBox.Name = "sNameComboBox";
            this.sNameComboBox.Size = new System.Drawing.Size(92, 21);
            this.sNameComboBox.TabIndex = 3;
            // 
            // sTypeTextBox1
            // 
            this.sTypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "SType", true));
            this.sTypeTextBox1.Location = new System.Drawing.Point(160, 154);
            this.sTypeTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sTypeTextBox1.Name = "sTypeTextBox1";
            this.sTypeTextBox1.Size = new System.Drawing.Size(92, 20);
            this.sTypeTextBox1.TabIndex = 5;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(160, 176);
            this.phoneTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(92, 20);
            this.phoneTextBox1.TabIndex = 7;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = VS_a09.F25_285ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // frmDrivingSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.tabControl_DONotEDIT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDrivingSchool";
            this.Text = "A09 - Driving School";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_DONotEDIT.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f25_285ADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.tabInstructors.ResumeLayout(false);
            this.tabInstructors.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            this.tabAddClients.ResumeLayout(false);
            this.tabAddClients.PerformLayout();
            this.tabScheduleClass.ResumeLayout(false);
            this.tabScheduleClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_DONotEDIT;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabInstructors;
        private System.Windows.Forms.TabPage tabAddClients;
        private System.Windows.Forms.TabPage tabScheduleClass;
        private F25_285ADataSet f25_285ADataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private F25_285ADataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private F25_285ADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private F25_285ADataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.DataGridView classesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private F25_285ADataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.DataGridView classesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource classesBindingSource1;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox sTypeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMonthClients;
        private System.Windows.Forms.RadioButton rdoWeekClients;
        private System.Windows.Forms.RadioButton rdoTodayClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScheduleClass;
        private System.Windows.Forms.Button btnScheduleClass_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoMonthInstructors;
        private System.Windows.Forms.RadioButton rdoWeekInstructors;
        private System.Windows.Forms.RadioButton rdoTodayInstructors;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddClientToDBO;
        private System.Windows.Forms.Button btnInsertScheduledClass;
        private System.Windows.Forms.ComboBox cNameComboBox;
        private System.Windows.Forms.TextBox ageTextBox1;
        private System.Windows.Forms.TextBox genderTextBox1;
        private System.Windows.Forms.ComboBox sNameComboBox;
        private System.Windows.Forms.TextBox sTypeTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}

