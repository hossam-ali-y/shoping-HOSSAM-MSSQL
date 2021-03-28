namespace shoping
{
    partial class invoice
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
            System.Windows.Forms.Label invoice_idLabel;
            System.Windows.Forms.Label custom_idLabel;
            System.Windows.Forms.Label products_stringLabel;
            System.Windows.Forms.Label noticesLabel;
            System.Windows.Forms.Label emp_idLabel;
            System.Windows.Forms.Label buy_dateLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.advanceDataSet = new shoping.advanceDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new shoping.advanceDataSetTableAdapters.invoiceTableAdapter();
            this.tableAdapterManager = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoice_idTextBox = new System.Windows.Forms.TextBox();
            this.products_stringTextBox = new System.Windows.Forms.TextBox();
            this.noticesTextBox = new System.Windows.Forms.TextBox();
            this.buy_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custom_idTextBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.emp_idTextBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new shoping.advanceDataSetTableAdapters.employeeTableAdapter();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            invoice_idLabel = new System.Windows.Forms.Label();
            custom_idLabel = new System.Windows.Forms.Label();
            products_stringLabel = new System.Windows.Forms.Label();
            noticesLabel = new System.Windows.Forms.Label();
            emp_idLabel = new System.Windows.Forms.Label();
            buy_dateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_idLabel
            // 
            invoice_idLabel.AutoSize = true;
            invoice_idLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            invoice_idLabel.Location = new System.Drawing.Point(344, 35);
            invoice_idLabel.Name = "invoice_idLabel";
            invoice_idLabel.Size = new System.Drawing.Size(73, 17);
            invoice_idLabel.TabIndex = 1;
            invoice_idLabel.Text = "رقم الفاتورة";
            // 
            // custom_idLabel
            // 
            custom_idLabel.AutoSize = true;
            custom_idLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            custom_idLabel.Location = new System.Drawing.Point(451, 68);
            custom_idLabel.Name = "custom_idLabel";
            custom_idLabel.Size = new System.Drawing.Size(77, 17);
            custom_idLabel.TabIndex = 3;
            custom_idLabel.Text = "اسم العميل";
            // 
            // products_stringLabel
            // 
            products_stringLabel.AutoSize = true;
            products_stringLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            products_stringLabel.Location = new System.Drawing.Point(585, 112);
            products_stringLabel.Name = "products_stringLabel";
            products_stringLabel.Size = new System.Drawing.Size(108, 17);
            products_stringLabel.TabIndex = 5;
            products_stringLabel.Text = "الأصناف المشتراه";
            // 
            // noticesLabel
            // 
            noticesLabel.AutoSize = true;
            noticesLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            noticesLabel.Location = new System.Drawing.Point(251, 113);
            noticesLabel.Name = "noticesLabel";
            noticesLabel.Size = new System.Drawing.Size(59, 17);
            noticesLabel.TabIndex = 7;
            noticesLabel.Text = "ملاحظات";
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            emp_idLabel.Location = new System.Drawing.Point(529, 174);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(77, 17);
            emp_idLabel.TabIndex = 9;
            emp_idLabel.Text = "رقم الموظف";
            // 
            // buy_dateLabel
            // 
            buy_dateLabel.AutoSize = true;
            buy_dateLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            buy_dateLabel.Location = new System.Drawing.Point(251, 142);
            buy_dateLabel.Name = "buy_dateLabel";
            buy_dateLabel.Size = new System.Drawing.Size(75, 17);
            buy_dateLabel.TabIndex = 11;
            buy_dateLabel.Text = "تاريخ الشراء";
            buy_dateLabel.Click += new System.EventHandler(this.buy_dateLabel_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            priceLabel.Location = new System.Drawing.Point(585, 137);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "السعر";
            // 
            // advanceDataSet
            // 
            this.advanceDataSet.DataSetName = "advanceDataSet";
            this.advanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.advanceDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.invoiceBindingNavigatorSaveItem});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.invoiceBindingNavigator.TabIndex = 0;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
            this.invoiceBindingNavigator.RefreshItems += new System.EventHandler(this.invoiceBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "إضافة فاتورة";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "حذف فاتورة";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // invoiceBindingNavigatorSaveItem
            // 
            this.invoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBindingNavigatorSaveItem.Image")));
            this.invoiceBindingNavigatorSaveItem.Name = "invoiceBindingNavigatorSaveItem";
            this.invoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoiceBindingNavigatorSaveItem.Text = "حفظ الفاتورة";
            this.invoiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoiceBindingNavigatorSaveItem_Click);
            // 
            // invoice_idTextBox
            // 
            this.invoice_idTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.invoice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoice_id", true));
            this.invoice_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_idTextBox.Location = new System.Drawing.Point(262, 33);
            this.invoice_idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invoice_idTextBox.Name = "invoice_idTextBox";
            this.invoice_idTextBox.ReadOnly = true;
            this.invoice_idTextBox.Size = new System.Drawing.Size(74, 24);
            this.invoice_idTextBox.TabIndex = 2;
            this.invoice_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // products_stringTextBox
            // 
            this.products_stringTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "products_string", true));
            this.products_stringTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_stringTextBox.Location = new System.Drawing.Point(329, 105);
            this.products_stringTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.products_stringTextBox.Name = "products_stringTextBox";
            this.products_stringTextBox.Size = new System.Drawing.Size(250, 24);
            this.products_stringTextBox.TabIndex = 6;
            this.products_stringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // noticesTextBox
            // 
            this.noticesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "notices", true));
            this.noticesTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticesTextBox.Location = new System.Drawing.Point(30, 108);
            this.noticesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noticesTextBox.Name = "noticesTextBox";
            this.noticesTextBox.Size = new System.Drawing.Size(215, 24);
            this.noticesTextBox.TabIndex = 8;
            this.noticesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noticesTextBox.TextChanged += new System.EventHandler(this.noticesTextBox_TextChanged);
            // 
            // buy_dateDateTimePicker
            // 
            this.buy_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "buy_date", true));
            this.buy_dateDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_dateDateTimePicker.Location = new System.Drawing.Point(30, 137);
            this.buy_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buy_dateDateTimePicker.Name = "buy_dateDateTimePicker";
            this.buy_dateDateTimePicker.Size = new System.Drawing.Size(197, 24);
            this.buy_dateDateTimePicker.TabIndex = 12;
            // 
            // custom_idTextBox
            // 
            this.custom_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "custom_id", true));
            this.custom_idTextBox.DataSource = this.customerBindingSource;
            this.custom_idTextBox.DisplayMember = "custom_name";
            this.custom_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_idTextBox.FormattingEnabled = true;
            this.custom_idTextBox.Location = new System.Drawing.Point(197, 65);
            this.custom_idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_idTextBox.Name = "custom_idTextBox";
            this.custom_idTextBox.Size = new System.Drawing.Size(248, 27);
            this.custom_idTextBox.TabIndex = 16;
            this.custom_idTextBox.ValueMember = "custom_id";
            this.custom_idTextBox.SelectedIndexChanged += new System.EventHandler(this.custom_idTextBox_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.advanceDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "emp_id", true));
            this.emp_idTextBox.DataSource = this.employeeBindingSource;
            this.emp_idTextBox.DisplayMember = "emp_name";
            this.emp_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_idTextBox.FormattingEnabled = true;
            this.emp_idTextBox.Location = new System.Drawing.Point(435, 169);
            this.emp_idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(84, 27);
            this.emp_idTextBox.TabIndex = 17;
            this.emp_idTextBox.ValueMember = "emp_id";
            this.emp_idTextBox.SelectedIndexChanged += new System.EventHandler(this.emp_idTextBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.advanceDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(433, 137);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(146, 24);
            this.priceTextBox.TabIndex = 19;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoice_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رقم الفاتورة";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "custom_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "رقم العميل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "products_string";
            this.dataGridViewTextBoxColumn3.HeaderText = "الاصناف المشتراه";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn7.HeaderText = "السعر";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "buy_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "تاريخ الشراء";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "notices";
            this.dataGridViewTextBoxColumn4.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "emp_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "رقم الموظف";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceDataGridView.Location = new System.Drawing.Point(9, 204);
            this.invoiceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceDataGridView.RowHeadersVisible = false;
            this.invoiceDataGridView.Size = new System.Drawing.Size(704, 366);
            this.invoiceDataGridView.TabIndex = 15;
            this.invoiceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellContentClick);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(730, 573);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.emp_idTextBox);
            this.Controls.Add(this.custom_idTextBox);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(invoice_idLabel);
            this.Controls.Add(this.invoice_idTextBox);
            this.Controls.Add(custom_idLabel);
            this.Controls.Add(products_stringLabel);
            this.Controls.Add(this.products_stringTextBox);
            this.Controls.Add(noticesLabel);
            this.Controls.Add(this.noticesTextBox);
            this.Controls.Add(emp_idLabel);
            this.Controls.Add(buy_dateLabel);
            this.Controls.Add(this.buy_dateDateTimePicker);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "invoice";
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advanceDataSet advanceDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private advanceDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoice_idTextBox;
        private System.Windows.Forms.TextBox products_stringTextBox;
        private System.Windows.Forms.TextBox noticesTextBox;
        private System.Windows.Forms.DateTimePicker buy_dateDateTimePicker;
        private System.Windows.Forms.ComboBox custom_idTextBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox emp_idTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private advanceDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
    }
}