namespace shoping
{
    partial class customer
    {
        public string Ms { get; set; }
        public static string Id { get; set; }
        public  new string Name { get; set; }
        public new string Location { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

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
            System.Windows.Forms.Label custom_idLabel;
            System.Windows.Forms.Label custom_nameLabel;
            System.Windows.Forms.Label custom_phoneLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label credit1Label;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label end_totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataSet = new shoping.advanceDataSet();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoices = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deliveries = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.custom_idTextBox = new System.Windows.Forms.TextBox();
            this.custom_nameTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.credit1TextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.end_totalTextBox = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.advanceDataSet1 = new shoping.advanceDataSet();
            this.custom_phoneTextBox = new System.Windows.Forms.TextBox();
            custom_idLabel = new System.Windows.Forms.Label();
            custom_nameLabel = new System.Windows.Forms.Label();
            custom_phoneLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            credit1Label = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            end_totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // custom_idLabel
            // 
            custom_idLabel.AutoSize = true;
            custom_idLabel.BackColor = System.Drawing.Color.DarkCyan;
            custom_idLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            custom_idLabel.ForeColor = System.Drawing.Color.White;
            custom_idLabel.Location = new System.Drawing.Point(23, 75);
            custom_idLabel.Name = "custom_idLabel";
            custom_idLabel.Size = new System.Drawing.Size(87, 31);
            custom_idLabel.TabIndex = 19;
            custom_idLabel.Text = "رقم الحساب:";
            // 
            // custom_nameLabel
            // 
            custom_nameLabel.AutoSize = true;
            custom_nameLabel.BackColor = System.Drawing.Color.DarkCyan;
            custom_nameLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            custom_nameLabel.ForeColor = System.Drawing.Color.White;
            custom_nameLabel.Location = new System.Drawing.Point(20, 109);
            custom_nameLabel.Name = "custom_nameLabel";
            custom_nameLabel.Size = new System.Drawing.Size(99, 31);
            custom_nameLabel.TabIndex = 21;
            custom_nameLabel.Text = "اسم المستخدم:";
            // 
            // custom_phoneLabel
            // 
            custom_phoneLabel.AutoSize = true;
            custom_phoneLabel.BackColor = System.Drawing.Color.DarkCyan;
            custom_phoneLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            custom_phoneLabel.ForeColor = System.Drawing.Color.White;
            custom_phoneLabel.Location = new System.Drawing.Point(634, 118);
            custom_phoneLabel.Name = "custom_phoneLabel";
            custom_phoneLabel.Size = new System.Drawing.Size(82, 31);
            custom_phoneLabel.TabIndex = 23;
            custom_phoneLabel.Text = "رقم الهاتف:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.DarkCyan;
            genderLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(710, 151);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(47, 31);
            genderLabel.TabIndex = 25;
            genderLabel.Text = "النوع:";
            genderLabel.Visible = false;
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.BackColor = System.Drawing.Color.DarkCyan;
            start_dateLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            start_dateLabel.ForeColor = System.Drawing.Color.White;
            start_dateLabel.Location = new System.Drawing.Point(584, 65);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(139, 31);
            start_dateLabel.TabIndex = 27;
            start_dateLabel.Text = "تاريخ إنشاء الحساب:";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.BackColor = System.Drawing.Color.DarkCyan;
            creditLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            creditLabel.ForeColor = System.Drawing.Color.White;
            creditLabel.Location = new System.Drawing.Point(356, 105);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(108, 31);
            creditLabel.TabIndex = 33;
            creditLabel.Text = "الحساب المدخر:";
            // 
            // credit1Label
            // 
            credit1Label.AutoSize = true;
            credit1Label.BackColor = System.Drawing.Color.DarkCyan;
            credit1Label.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            credit1Label.ForeColor = System.Drawing.Color.White;
            credit1Label.Location = new System.Drawing.Point(384, 145);
            credit1Label.Name = "credit1Label";
            credit1Label.Size = new System.Drawing.Size(61, 31);
            credit1Label.TabIndex = 35;
            credit1Label.Text = "الصافي:";
            credit1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.DarkCyan;
            statusLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(367, 71);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(94, 31);
            statusLabel.TabIndex = 48;
            statusLabel.Text = "حالة الحساب:";
            // 
            // end_totalLabel
            // 
            end_totalLabel.AutoSize = true;
            end_totalLabel.BackColor = System.Drawing.Color.DarkCyan;
            end_totalLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            end_totalLabel.ForeColor = System.Drawing.Color.White;
            end_totalLabel.Location = new System.Drawing.Point(20, 137);
            end_totalLabel.Name = "end_totalLabel";
            end_totalLabel.Size = new System.Drawing.Size(144, 31);
            end_totalLabel.TabIndex = 50;
            end_totalLabel.Text = "اجمالي الحساب الاجل:";
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.AllowItemReorder = true;
            this.customerBindingNavigator.AutoSize = false;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator5,
            this.customerBindingNavigatorSaveItem,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.invoices,
            this.toolStripSeparator3,
            this.deliveries});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(944, 41);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            this.customerBindingNavigator.RefreshItems += new System.EventHandler(this.customerBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.advanceDataSet;
            // 
            // advanceDataSet
            // 
            this.advanceDataSet.DataSetName = "advanceDataSet";
            this.advanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 38);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(55, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 38);
            this.customerBindingNavigatorSaveItem.Text = "حفظ";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click_3);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton1.Text = "اعادة تحميل الصفحة";
            this.toolStripButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 38);
            this.toolStripButton2.Tag = "الرئيسية";
            this.toolStripButton2.Text = "الرئيسية";
            this.toolStripButton2.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // invoices
            // 
            this.invoices.Image = ((System.Drawing.Image)(resources.GetObject("invoices.Image")));
            this.invoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invoices.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.invoices.Name = "invoices";
            this.invoices.Size = new System.Drawing.Size(62, 38);
            this.invoices.Tag = "الفواتير";
            this.invoices.Text = "الفواتير";
            this.invoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoices.Click += new System.EventHandler(this.invoices_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // deliveries
            // 
            this.deliveries.Image = ((System.Drawing.Image)(resources.GetObject("deliveries.Image")));
            this.deliveries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deliveries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.deliveries.Name = "deliveries";
            this.deliveries.Size = new System.Drawing.Size(76, 38);
            this.deliveries.Tag = "المسلمات";
            this.deliveries.Text = "المسلمات";
            this.deliveries.Click += new System.EventHandler(this.deliveries_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(17, 53);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(916, 144);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // custom_idTextBox
            // 
            this.custom_idTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.custom_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_id", true));
            this.custom_idTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.custom_idTextBox.Location = new System.Drawing.Point(121, 72);
            this.custom_idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_idTextBox.Multiline = true;
            this.custom_idTextBox.Name = "custom_idTextBox";
            this.custom_idTextBox.ReadOnly = true;
            this.custom_idTextBox.Size = new System.Drawing.Size(91, 30);
            this.custom_idTextBox.TabIndex = 20;
            this.custom_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custom_nameTextBox
            // 
            this.custom_nameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.custom_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_name", true));
            this.custom_nameTextBox.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.custom_nameTextBox.Location = new System.Drawing.Point(119, 107);
            this.custom_nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_nameTextBox.Name = "custom_nameTextBox";
            this.custom_nameTextBox.Size = new System.Drawing.Size(222, 27);
            this.custom_nameTextBox.TabIndex = 22;
            this.custom_nameTextBox.Text = "اسم المستخدم";
            this.custom_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custom_nameTextBox.TextChanged += new System.EventHandler(this.custom_nameTextBox_TextChanged_1);
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(721, 64);
            this.start_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(203, 32);
            this.start_dateDateTimePicker.TabIndex = 28;
            // 
            // creditTextBox
            // 
            this.creditTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.creditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "credit", true));
            this.creditTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.creditTextBox.Location = new System.Drawing.Point(464, 106);
            this.creditTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditTextBox.Multiline = true;
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(158, 33);
            this.creditTextBox.TabIndex = 34;
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditTextBox.TextChanged += new System.EventHandler(this.creditTextBox_TextChanged);
            // 
            // credit1TextBox
            // 
            this.credit1TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.credit1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credit1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "credit1", true));
            this.credit1TextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.credit1TextBox.Location = new System.Drawing.Point(462, 145);
            this.credit1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credit1TextBox.Multiline = true;
            this.credit1TextBox.Name = "credit1TextBox";
            this.credit1TextBox.ReadOnly = true;
            this.credit1TextBox.Size = new System.Drawing.Size(158, 28);
            this.credit1TextBox.TabIndex = 36;
            this.credit1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataGridView.ColumnHeadersHeight = 39;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.customerDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "custom_id", true));
            this.customerDataGridView.DataSource = this.customerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGridView.Location = new System.Drawing.Point(18, 232);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerDataGridView.Name = "customerDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 38;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customerDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowTemplate.ErrorText = "خطاء في البيانات";
            this.customerDataGridView.RowTemplate.Height = 33;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(914, 483);
            this.customerDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "custom_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رقم الحساب";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "custom_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المستخدم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "end_total";
            this.dataGridViewTextBoxColumn7.HeaderText = "إجمالي الاجل  /(ريال)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "credit";
            this.dataGridViewTextBoxColumn8.HeaderText = "المدخر  /(ريال)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "credit1";
            this.dataGridViewTextBoxColumn9.HeaderText = "الصافي /(ريال)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn6.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاريخ إنشاء الحساب";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "النوع";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "custom_phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.genderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genderTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.genderTextBox.Location = new System.Drawing.Point(780, 149);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderTextBox.Multiline = true;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(89, 33);
            this.genderTextBox.TabIndex = 45;
            this.genderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genderTextBox.Visible = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusTextBox.Location = new System.Drawing.Point(465, 69);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(113, 33);
            this.statusTextBox.TabIndex = 49;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // end_totalTextBox
            // 
            this.end_totalTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.end_totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.end_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "end_total", true));
            this.end_totalTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.end_totalTextBox.Location = new System.Drawing.Point(158, 140);
            this.end_totalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.end_totalTextBox.Name = "end_totalTextBox";
            this.end_totalTextBox.Size = new System.Drawing.Size(158, 25);
            this.end_totalTextBox.TabIndex = 51;
            this.end_totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // advanceDataSet1
            // 
            this.advanceDataSet1.DataSetName = "advanceDataSet";
            this.advanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custom_phoneTextBox
            // 
            this.custom_phoneTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.custom_phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_phone", true));
            this.custom_phoneTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.custom_phoneTextBox.Location = new System.Drawing.Point(721, 114);
            this.custom_phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_phoneTextBox.Multiline = true;
            this.custom_phoneTextBox.Name = "custom_phoneTextBox";
            this.custom_phoneTextBox.Size = new System.Drawing.Size(207, 32);
            this.custom_phoneTextBox.TabIndex = 24;
            this.custom_phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(944, 718);
            this.Controls.Add(end_totalLabel);
            this.Controls.Add(this.end_totalTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(custom_idLabel);
            this.Controls.Add(this.custom_idTextBox);
            this.Controls.Add(custom_nameLabel);
            this.Controls.Add(this.custom_nameTextBox);
            this.Controls.Add(custom_phoneLabel);
            this.Controls.Add(this.custom_phoneTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(creditLabel);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(credit1Label);
            this.Controls.Add(this.credit1TextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.customerBindingNavigator);
            this.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customer_FormClosing);
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advanceDataSet advanceDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox custom_idTextBox;
        private System.Windows.Forms.TextBox custom_nameTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox credit1TextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private advanceDataSet advanceDataSet1;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox end_totalTextBox;
        private System.Windows.Forms.TextBox custom_phoneTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton invoices;
        private System.Windows.Forms.ToolStripButton deliveries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;




    }
}

