using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoping
{
    public partial class query : Form
    {
        public SqlConnection con =new SqlConnection(@"Data Source='" + home.con_server + "';Initial Catalog=advance;Integrated Security=True");
           
        public SqlCommand cmd;
        public SqlDataReader dr;
        private Label cruncy;
        private GroupBox groupBox1;
        private RadioButton searchbyid;
        private RadioButton searchbyname;
        private advanceDataSet advanceDataSet;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private BindingSource vwcustomerBindingSource;
        private advanceDataSetTableAdapters.vw_customerTableAdapter vw_customerTableAdapter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator17;
        string custom_id;
        private static bool needclose = true;
        public query()
        {
            InitializeComponent();
   
        }


        private void login_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'advanceDataSet.vw_customer' table. You can move, or remove it, as needed.
            this.vw_customerTableAdapter.Fill(this.advanceDataSet.vw_customer);
         

      
           
            // TODO: This line of code loads data into the 'storeManagmentDataSet.stores' table. You can move, or remove it, as needed.
            msg.Text = "";
            custom_idTextBox.Text = "حدد عميل";
            custom_nameTextBox.Text = "حدد عميل";
            end_totalTextBox.Text = "حدد عميل";
            cruncy.Hide();
           
            if ( searchbyname.Checked==true){

                sname.Text=" حدداسم العميل للاستعلام";
                id.Hide();
                label1.Hide();
            }
            else if(searchbyid.Checked==true){
                id.Text = "حدد رقم العميل";
                name.Hide();
                sname.Hide();
            }
        
        }



//        private void log_Click(object sender, EventArgs e)
//        {
//            db.con.Open();
//            if (sname.Text != "" )
//            {
        
//               db.cmd = new SqlCommand(@"select * from customer  
//                 where custom_name='" + sname.Text + "'", db.con);
//                try {
//                    db.dr = db.cmd.ExecuteReader();
//                    if (db.dr.Read())
//                    {

//                        if (db.dr["custom_name"].ToString() == sname.Text)
//                        {

//                                customer my = new customer();

//        customer.Id = db.dr["custom_id"].ToString();
//                            my.Name = db.dr["custom_name"].ToString();
//                            //my.Location = db.dr["location"].ToString();
//                            my.Show();
//                            //my.Balance = Convert.ToDouble(db.dr["balance"]);
//                            //my.Password = db.dr["password"].ToString();
//                            //my.Ms = " تم تسجيل الدخول بنجاح مرحبا" + my.Name;
//                            //msg.Text = "تم تسجيل الدخول بنجاح مرحبا";
//                            //my.Show();

//                        }
//                        db.dr.Close();
//                        db.con.Close();
//                    }
//                    //else if (dr["store_name"] == sname.Text && dr["password"] != spass.Text)
//                    //{
//                    //    msg.Text = " invalid password ";
//                    //}
//                    else
//                    {
//                        msg.Text = "  الزبون غير موجود ";
//                        db.dr.Close();

//                        db.con.Close();

//                    }
//                }
//                catch 
//                {
//                    msg.Text = "wrong connect with db";                }

              
//            }
//            else if (sname.Text == "" && id.Text !="" )
//            {
//                db.cmd = new SqlCommand(@"select * from customer  
//                 where custom_id='" + id.Text + "'", db.con);
//                try {
//                    db.dr = db.cmd.ExecuteReader();
//                    if (db.dr.Read())
//                    {

//                        if (db.dr["custom_id"].ToString() == id.Text)
//                        {

//                                customer my = new customer();

//        customer.Id = db.dr["custom_id"].ToString();
//                            my.Name = db.dr["custom_name"].ToString();
//                            //my.Location = db.dr["location"].ToString();
//                            my.Show();
//                            //my.Balance = Convert.ToDouble(db.dr["balance"]);
//                            //my.Password = db.dr["password"].ToString();
//                            //my.Ms = " تم تسجيل الدخول بنجاح مرحبا" + my.Name;
//                            //msg.Text = "تم تسجيل الدخول بنجاح مرحبا";
//                            //my.Show();

//                        }
//                        db.dr.Close();

//                    }
//                    //else if (dr["store_name"] == sname.Text && dr["password"] != spass.Text)
//                    //{
//                    //    msg.Text = " invalid password ";
//                    //}
//                    else
//                    {
//                        msg.Text = "  الزبون غير موجود ";
//                        db.dr.Close();

//                    }
//                }
//                catch 
//                {
//                    msg.Text = "wrong connect with db";                }
//            }
//            else if (sname.Text == "")
//            {
//                msg.Text = " ادخل اسم المخزن وكلمة المروور";
//            }
//            else if (sname.Text =="")
//            {

//                msg.Text = "اسم المخزن فارغ";
//            }

        

//        }





        private void login_Load_1(object sender, EventArgs e)
        {

        }

   

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label custom_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query));
            System.Windows.Forms.Label custom_nameLabel;
            System.Windows.Forms.Label end_totalLabel;
            this.name = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.vwcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataSet = new shoping.advanceDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.ComboBox();
            this.custom_idTextBox = new System.Windows.Forms.TextBox();
            this.custom_nameTextBox = new System.Windows.Forms.TextBox();
            this.end_totalTextBox = new System.Windows.Forms.TextBox();
            this.cruncy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbyid = new System.Windows.Forms.RadioButton();
            this.searchbyname = new System.Windows.Forms.RadioButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.vw_customerTableAdapter = new shoping.advanceDataSetTableAdapters.vw_customerTableAdapter();
            custom_idLabel = new System.Windows.Forms.Label();
            custom_nameLabel = new System.Windows.Forms.Label();
            end_totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // custom_idLabel
            // 
            resources.ApplyResources(custom_idLabel, "custom_idLabel");
            custom_idLabel.Name = "custom_idLabel";
            custom_idLabel.Click += new System.EventHandler(this.custom_idLabel_Click);
            // 
            // custom_nameLabel
            // 
            resources.ApplyResources(custom_nameLabel, "custom_nameLabel");
            custom_nameLabel.Name = "custom_nameLabel";
            // 
            // end_totalLabel
            // 
            resources.ApplyResources(end_totalLabel, "end_totalLabel");
            end_totalLabel.Name = "end_totalLabel";
            end_totalLabel.Click += new System.EventHandler(this.end_totalLabel_Click);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // msg
            // 
            resources.ApplyResources(this.msg, "msg");
            this.msg.ForeColor = System.Drawing.Color.Maroon;
            this.msg.Name = "msg";
            this.msg.Click += new System.EventHandler(this.msg_Click);
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwcustomerBindingSource, "custom_id", true));
            this.id.DataSource = this.vwcustomerBindingSource;
            this.id.DisplayMember = "custom_id";
            resources.ApplyResources(this.id, "id");
            this.id.FormattingEnabled = true;
            this.id.Name = "id";
            this.id.ValueMember = "custom_id";
            this.id.MouseHover += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vwcustomerBindingSource
            // 
            this.vwcustomerBindingSource.DataMember = "vw_customer";
            this.vwcustomerBindingSource.DataSource = this.advanceDataSet;
            // 
            // advanceDataSet
            // 
            this.advanceDataSet.DataSetName = "advanceDataSet";
            this.advanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sname
            // 
            this.sname.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.sname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwcustomerBindingSource, "custom_id", true));
            this.sname.DataSource = this.vwcustomerBindingSource;
            this.sname.DisplayMember = "custom_name";
            resources.ApplyResources(this.sname, "sname");
            this.sname.FormattingEnabled = true;
            this.sname.Name = "sname";
            this.sname.ValueMember = "custom_id";
            this.sname.MouseHover += new System.EventHandler(this.sname_SelectedIndexChanged);
            // 
            // custom_idTextBox
            // 
            this.custom_idTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.custom_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwcustomerBindingSource, "custom_id", true));
            resources.ApplyResources(this.custom_idTextBox, "custom_idTextBox");
            this.custom_idTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.custom_idTextBox.Name = "custom_idTextBox";
            this.custom_idTextBox.ReadOnly = true;
            this.custom_idTextBox.TextChanged += new System.EventHandler(this.custom_idTextBox_TextChanged);
            // 
            // custom_nameTextBox
            // 
            this.custom_nameTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.custom_nameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwcustomerBindingSource, "custom_name", true));
            resources.ApplyResources(this.custom_nameTextBox, "custom_nameTextBox");
            this.custom_nameTextBox.Name = "custom_nameTextBox";
            this.custom_nameTextBox.ReadOnly = true;
            this.custom_nameTextBox.TextChanged += new System.EventHandler(this.custom_nameTextBox_TextChanged);
            // 
            // end_totalTextBox
            // 
            this.end_totalTextBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.end_totalTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.end_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwcustomerBindingSource, "end_total", true));
            resources.ApplyResources(this.end_totalTextBox, "end_totalTextBox");
            this.end_totalTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.end_totalTextBox.Name = "end_totalTextBox";
            this.end_totalTextBox.ReadOnly = true;
            this.end_totalTextBox.TextChanged += new System.EventHandler(this.end_totalTextBox_TextChanged);
            // 
            // cruncy
            // 
            resources.ApplyResources(this.cruncy, "cruncy");
            this.cruncy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cruncy.Name = "cruncy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbyid);
            this.groupBox1.Controls.Add(this.searchbyname);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchbyid
            // 
            resources.ApplyResources(this.searchbyid, "searchbyid");
            this.searchbyid.Name = "searchbyid";
            this.searchbyid.UseVisualStyleBackColor = true;
            this.searchbyid.CheckedChanged += new System.EventHandler(this.searchbyid_CheckedChanged);
            // 
            // searchbyname
            // 
            resources.ApplyResources(this.searchbyname, "searchbyname");
            this.searchbyname.Checked = true;
            this.searchbyname.Name = "searchbyname";
            this.searchbyname.TabStop = true;
            this.searchbyname.Tag = "البحث بالاسم";
            this.searchbyname.UseVisualStyleBackColor = true;
            this.searchbyname.CheckedChanged += new System.EventHandler(this.searchbyname_CheckedChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.BindingSource = this.vwcustomerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "من{0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator17,
            this.toolStripButton2});
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.login_Load);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Tag = "الرئيسية";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // vw_customerTableAdapter
            // 
            this.vw_customerTableAdapter.ClearBeforeFill = true;
            // 
            // query
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cruncy);
            this.Controls.Add(custom_idLabel);
            this.Controls.Add(this.custom_idTextBox);
            this.Controls.Add(custom_nameLabel);
            this.Controls.Add(this.custom_nameTextBox);
            this.Controls.Add(end_totalLabel);
            this.Controls.Add(this.end_totalTextBox);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::shoping.Properties.Settings.Default, "query", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::shoping.Properties.Settings.Default.query;
            this.Name = "query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.query_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label name;
        private ComboBox id;
        private Label label1;
        private ComboBox sname;
        private IContainer components;
        private TextBox custom_idTextBox;
        private TextBox custom_nameTextBox;
        private TextBox end_totalTextBox;
        private System.Windows.Forms.Label msg;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(id.SelectedValue) >0)
            {
               
                custom_id = id.SelectedValue.ToString();
                //=id.SelectedValue.ToString();
                cmd = new SqlCommand(@"select * from customer  
                 where custom_id='" + custom_id + "'", con);
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        if (dr["custom_id"].ToString() == custom_id)
                        {
                            //customer my = new customer();
                            customer.Id = dr["custom_id"].ToString();
                            msg.Text = "نتائج البحث";
                            custom_idTextBox.Text = custom_id;
                            custom_nameTextBox.Text = dr["custom_name"].ToString();
                            end_totalTextBox.Text = dr["end_total"].ToString();
                            cruncy.Visible = true;
                        }
                        dr.Close();
                        con.Close();
                    }
                    //else if (dr["store_name"] == sname.Text && dr["password"] != spass.Text)
                    //{
                    //    msg.Text = " invalid password ";
                    //}
                    else
                    {
                        msg.Text = " \n الزبون غير موجود ";
                       dr.Close();
                       con.Close();
                    }
                   
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    msg.Text = "wrong connect with db";
                }
             
            }
        }

        private void sname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(sname.SelectedValue)>0)
            {
                custom_id = sname.SelectedValue.ToString();
                //=id.SelectedValue.ToString();
                cmd = new SqlCommand(@"select * from customer  
                 where custom_id='" + custom_id + "'", con);
                try
                {
                    if (con.State.ToString() != "Open")
                    {
                        con.Open();
                    }
                  
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        if (dr["custom_id"].ToString() == custom_id)
                        {
                           //customer my = new customer();
                            customer.Id = dr["custom_id"].ToString();
                            msg.Text = "نتائج البحث";
                            custom_idTextBox.Text = custom_id;
                            custom_nameTextBox.Text = dr["custom_name"].ToString();
                            end_totalTextBox.Text = dr["end_total"].ToString();
                            cruncy.Visible = true;
                        }
                        dr.Close();
                        con.Close();



                    }
                    //else if (dr["store_name"] == sname.Text && dr["password"] != spass.Text)
                    //{
                    //    msg.Text = " invalid password ";
                    //}
                    else
                    {
                        msg.Text = " \n الزبون غير موجود ";
                       dr.Close();
                        con.Close();

                    }
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    msg.Text = "wrong connect with db";
                }
              


            }
        }

        private void custom_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void end_totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void sname_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void refresh_ForeColorChanged(object sender, EventArgs e)
        {

          
        }

        private void searchbyname_CheckedChanged(object sender, EventArgs e)
        {
            if (searchbyname.Checked == true)
            {
                id.Hide();
                label1.Hide();
                sname.Visible=true;
                name.Visible=true;
                sname.Text = " حدداسم العميل للاستعلام";
                msg.Text = "";
                custom_idTextBox.Text = "حدد عميل";
                custom_nameTextBox.Text = "حدد عميل";
                end_totalTextBox.Text = "حدد عميل";
                cruncy.Hide();
            }
        }

        private void searchbyid_CheckedChanged(object sender, EventArgs e)
        {
               if (searchbyid.Checked == true)
            {
                name.Hide();
                sname.Hide();
                label1.Visible=true;
                id.Visible=true;
                id.Text = "حدد رقم العميل";

                msg.Text = "";
                custom_idTextBox.Text = "حدد عميل";
                custom_nameTextBox.Text = "حدد عميل";
                end_totalTextBox.Text = "حدد عميل";
                cruncy.Hide();
            }
        }

        private void custom_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms["home"].Show();
            this.Close();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sname_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sname_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["home"].Show();
            needclose = false;
            this.Hide();
        }

        private void msg_Click(object sender, EventArgs e)
        {

        }

        private void end_totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void query_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needclose)
            {
                toolStripButton2_Click(sender,e);
                //Application.OpenForms["home"].Close();
                //Application.OpenForms["vw_invoice"].Close();
                //Application.OpenForms["query"].Close();
                //Application.OpenForms["customer"].Close();
                //Application.OpenForms["deliveries"].Close();
                //Application.OpenForms["indiv_invoices"].Close();
            }
        }


  



    }
}
