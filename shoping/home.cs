using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoping
{
    
 
    public partial class home : Form
    {
        public static string msgdb="";
        public static string emp_session;
        public static string custom_name;
        public static string custom_name1;
        private static decimal last_mony;
        private static decimal last_account1;
        private bool needclose = true;
        //public MySqlConnection mycon = new MySqlConnection("Server=localhostL;Initial Catalog=storemanagment;uid=root;Integrated Security=True");
        //public MySqlCommand mycmd;
        //public MySqlDataReader mydr;
        public bool authntication = false;
        public static string con_server;
        public SqlConnection con;
           public SqlConnection conms;
        public SqlCommand cmd;
        private advanceDataSet advanceDataSet;
        private BindingSource deliveriesSelectProcBindingSource;
        private advanceDataSetTableAdapters.DeliveriesSelectProcTableAdapter deliveriesSelectProcTableAdapter;
        private BindingSource customerBindingSource;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource indivisualDeliverBindingSource;
        private advanceDataSetTableAdapters.IndivisualDeliverTableAdapter indivisualDeliverTableAdapter;
        private BindingSource proc_select_invoiceBindingSource;
        private BindingSource employeeBindingSource;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter1;
        private advanceDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private advanceDataSetTableAdapters.proc_select_invoiceTableAdapter proc_select_invoiceTableAdapter;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource proc_select_invoiceBindingSource1;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter2;
        private advanceDataSetTableAdapters.employeeTableAdapter employeeTableAdapter1;
        private advanceDataSetTableAdapters.proc_select_invoiceTableAdapter proc_select_invoiceTableAdapter1;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private Label last_accountLabel1;
        private TabPage tabPage3;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridView deliveriesSelectProcDataGridView;
        private DataGridViewTextBoxColumn deliveryidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastaccountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveredmoneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afterdeliveringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliverdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noticesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private Label delivery_idLabel;
        private TextBox d_id;
        private Label custom_nameLabel;
        private Label last_accountLabel;
        private TextBox lastmony;
        private Label delivered_moneyLabel;
        private TextBox mony;
        private Label noticesLabel;
        private TextBox notices;
        private Label emp_nameLabel;
        private TextBox emp_name;
        private TabPage tabPage2;
        public TabControl tabControl1;
        private Button log;
        private TextBox sname;
        private TextBox spass;
        private Label name;
        private Label password;
       


        private Button back;
        private Button button1;
        private LinkLabel connect;
        private Label label4;
        private LinkLabel msgdisconnect;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button query;
        private Panel panel_main;
        private Button sales;
        private Button stores;
        private Button products;
        private Button sale_monitor;
        private Button store_monitor;
        private Button button2;
        private TabPage tabPage1;
        private Panel panel_login;
        private Button button12;
        private Label msg;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button13;
        private Panel panal_home;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private LinkLabel wrongmsg;
        private Label label6;
        private LinkLabel restore_connect;
        private Label label8;
        private ComboBox server_name;
        private BindingNavigator deliveriesSelectProcBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton deliveriesSelectProcBindingNavigatorSaveItem;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator16;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton home_nav;
        private ToolStripSeparator toolStripSeparator21;
        private ToolStripButton refrish;
        private ToolStripSeparator toolStripSeparator22;
        public ToolStripButton accounts;
        private ToolStripSeparator space1;
        private ToolStripButton toolStripButton14;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton15;
        private ToolStripSeparator toolStripSeparator7;
        public ToolStripButton invoices;
        private ToolStripSeparator space2;
        public ToolStripButton deliveries;
        private ToolStripSeparator space3;
        private Panel indevisiual_deliv_panel;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton toolStripButton7;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton toolStripButton11;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton toolStripButton13;
        private ToolStripSeparator toolStripSeparator14;
        private Label last_account;
        private TextBox last_accountTextBox;
        private Label noticesLabel1;
        private TextBox noticesTextBox;
        private Label deliver_dateLabel;
        private DateTimePicker deliver_dateDateTimePicker;
        private ComboBox custom_nameTextBox;
        private Label delivery_idLabel1;
        private TextBox delivery_idTextBox;
        private Label custom_nameLabel1;
        private Label delivered_moneyLabel1;
        private TextBox delivered_moneyTextBox;
        private Label after_deliveringLabel;
        private TextBox after_deliveringTextBox;
        private Label emp_nameLabel1;
        private TextBox emp_nameTextBox;
        private DataGridView indivisualDeliverDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label topToolStripLabel;
        private Label partToolStripLabel;
        private ComboBox partToolStripTextBox;
        private ComboBox topToolStripTextBox;
        private Label label11;
        private Label label12;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label_num;
        private Label label_part;
        private ComboBox combo_part;
        private ComboBox combo_num;
        private GroupBox groupBox1;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private ToolStripButton toolStripButton16;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripButton toolStripButton17;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripButton toolStripButton12;
        private ToolStripButton toolStripButton19;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton18;
        private Button print;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripSeparator toolStripSeparator24;
        private ToolStripSeparator toolStripSeparator23;
        private DataGridView customerDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private BindingSource bindingSource1;
        private advanceDataSet advanceDataSet1;
        private TextBox custom_idTextBox;
        private TextBox textBox3;
        private DateTimePicker start_dateDateTimePicker;
        private TextBox creditTextBox;
        private TextBox credit1TextBox;
        private TextBox end_totalTextBox;
        private TextBox statusTextBox;
        private TextBox genderTextBox;
        private TextBox custom_phoneTextBox;
        private BindingNavigator customerBindingNavigator;
        private ToolStripButton toolStripButton23;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton24;
        private ToolStripButton toolStripButton25;
        private ToolStripButton toolStripButton26;
        private ToolStripSeparator toolStripSeparator28;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator29;
        private ToolStripButton toolStripButton27;
        private ToolStripButton toolStripButton28;
        private ToolStripSeparator toolStripSeparator30;
        private ToolStripSeparator toolStripSeparator31;
        private ToolStripButton customerBindingNavigatorSaveItem;
        private ToolStripSeparator toolStripSeparator32;
        private ToolStripButton toolStripButton29;
        private ToolStripSeparator toolStripSeparator27;
        private ToolStripButton toolStripButton20;
        private ToolStripSeparator toolStripSeparator26;
        private ToolStripButton toolStripButton21;
        private ToolStripSeparator toolStripSeparator25;
        private ToolStripButton toolStripButton22;
        private advanceDataSetTableAdapters.customerTableAdapter customerTableAdapter3;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private advanceDataSet advanceDataSet2;
        public Panel panel3;
        public Panel tab3_hid;
        private Button button3;
        private BindingNavigator bindingNavigator3;
        private ToolStripButton toolStripButton30;
        private BindingSource employeeBindingSource1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton toolStripButton31;
        private ToolStripButton toolStripButton32;
        private ToolStripButton toolStripButton33;
        private ToolStripSeparator toolStripSeparator33;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripSeparator toolStripSeparator34;
        private ToolStripButton toolStripButton34;
        private ToolStripButton toolStripButton35;
        private ToolStripSeparator toolStripSeparator35;
        private ToolStripSeparator toolStripSeparator36;
        private ToolStripButton toolStripButton36;
        private ToolStripSeparator toolStripSeparator37;
        private ToolStripButton toolStripButton37;
        private ToolStripSeparator toolStripSeparator38;
        private ToolStripButton toolStripButton38;
        private ToolStripSeparator toolStripSeparator39;
        private ToolStripButton toolStripButton39;
        private ToolStripSeparator toolStripSeparator40;
        private ToolStripButton toolStripButton40;
        private DataGridView employeeDataGridView;
        private TextBox emp_idTextBox;
        private TextBox emp_nameTextBox1;
        private TextBox emp_passwordTextBox;
        private TextBox emp_statusTextBox;
        public Panel panel1;
        private ToolStripButton toolStripButton42;
        private ToolStripButton toolStripButton41;
        private BindingSource employeeBindingSource2;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TabPage tabPage4;
        public BindingNavigator bindingNavigator4;
        private ToolStripButton toolStripButton43;
        private ToolStripSeparator toolStripSeparator41;
        private ToolStripButton toolStripButton49;
        private ToolStripSeparator toolStripSeparator47;
        private ToolStripButton toolStripButton50;
        private ToolStripButton toolStripButton51;
        private ToolStripSeparator toolStripSeparator44;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager4;
        private advanceDataSetTableAdapters.TableAdapterManager tableAdapterManager5;
        private BindingSource customerBindingSource1;
        private BindingSource customerBindingSource2;
        private BindingSource vwcustomerBindingSource;
        private advanceDataSetTableAdapters.vw_customerTableAdapter vw_customerTableAdapter;
        private BindingSource customerDataTableBindingSource;
        private advanceDataSetTableAdapters.customer_DataTableTableAdapter customer_DataTableTableAdapter;
        private DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emppasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empstatusDataGridViewTextBoxColumn;
        private ToolStripButton toolStripButton44;
        private ToolStripSeparator toolStripSeparator42;
        private ToolStripButton toolStripButton45;
        private BindingSource customerDataTableTableAdapter1BindingSource;
        private advanceDataSetTableAdapters.customer_DataTableTableAdapter1TableAdapter customer_DataTableTableAdapter1TableAdapter;
        private ToolStripSeparator toolStripSeparator45;
        private Label label15;
        public Label label14;
        public Label label16;
        private Button button10;
        public SqlDataReader dr;

        //method to create  backup for database
        private void backup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog bk = new SaveFileDialog();
                bk.Filter = "Backup Files (*.Bak) | *.bak";
                if (bk.ShowDialog() == DialogResult.OK)
                {
                    cmd = new SqlCommand("Backup Database advance To Disk'" + bk.FileName + "'", con);
                    con.Open();
                   cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    
        private void SqlConnect(){
            try
            {
                con.Open();
            }
            catch
            {
                //msgdisconnect.Text = "لايوجد إتصال  \n اعادة المحاولة";
            }
            if (con.State.ToString() != "Open")
            {
                wrongmsg.Text = "خطاء في الإتصال \n افحص الاتصال وحاول ثانية";
                disconnect dis = new disconnect();
                dis.Show();
            }
        }
    
        //private void MySqlConnect()
        //{
        //    try
        //    {
        //        mycon.Open();
        //    }
        //    catch
        //    {
        //        //msgdisconnect.Text = "لايوجد إتصال  \n اعادة المحاولة";
        //    }
        //    if (mycon.State.ToString() != "Open")
        //    {
        //        wrongmsg.Text = "خطاء في الإتصال \n افحص الاتصال وحاول ثانية";
        //        disconnect dis = new disconnect();
        //        dis.Show();
        //    }
        //}

        public home()
        {

          InitializeComponent();
          con_server = server_name.Text;
          con = new SqlConnection(@"Data Source='" + server_name.Text + "';Initial Catalog=advance;Integrated Security=True");
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SqlConnect();
            panel2.Visible = false;
            panel_login.Visible = true;
            sname.Focus();
              
            
        }

        private void home_Load(object sender, EventArgs e)
        {
            con = null;
            con_server = server_name.Text;
            con = new SqlConnection(@"Data Source='" + con_server + "';Initial Catalog=advance;Integrated Security=True");


            // TODO: This line of code loads data into the 'advanceDataSet.customer_DataTableTableAdapter1' table. You can move, or remove it, as needed.
            this.customer_DataTableTableAdapter1TableAdapter.Fill(this.advanceDataSet.customer_DataTableTableAdapter1);

            custom_name1 = comboBox1.Text;


            custom_name = custom_nameTextBox.Text;
            // TODO: This line of code loads data into the 'advanceDataSet.customer_DataTable' table. You can move, or remove it, as needed.
            this.customer_DataTableTableAdapter.Fill(this.advanceDataSet.customer_DataTable);
            // TODO: This line of code loads data into the 'advanceDataSet.vw_customer' table. You can move, or remove it, as needed.
            this.vw_customerTableAdapter.Fill(this.advanceDataSet.vw_customer);
            // TODO: This line of code loads data into the 'advanceDataSet.vw_customer' table. You can move, or remove it, as needed.
    

        
            ////hide.Visible = true;

            this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            // TODO: This line of code loads data into the 'advanceDataSet.DeliveriesSelectProc' table. You can move, or remove it, as needed.
            this.deliveriesSelectProcTableAdapter.Fill(this.advanceDataSet.DeliveriesSelectProc);
            //this.deliveriesSelectProcBindingNavigator.RefreshItems += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            this.employeeTableAdapter1.Fill(this.advanceDataSet.employee);


       // custom_nameTextBox.Text = custom_name1;
          //comboBox1.Text = custom_name1;
            //comboBox1.Text = custom_name1;
            //try
            //{
            //    db.con.Open();
            //}
            //catch
            //{
            //    dbstate.Text = db.con.State.ToString() + "\n" + "انت غير متصل" + "\n";
            //    connect.Text = "أنقر لإعادة الاتصال";

            //}

        }

  


   

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label end_totalLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label custom_idLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label custom_phoneLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label credit1Label;
            System.Windows.Forms.Label emp_idLabel;
            System.Windows.Forms.Label emp_nameLabel2;
            System.Windows.Forms.Label emp_passwordLabel;
            System.Windows.Forms.Label emp_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.last_accountLabel1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.indivisualDeliverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataSet = new shoping.advanceDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveriesSelectProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proc_select_invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveriesSelectProcTableAdapter = new shoping.advanceDataSetTableAdapters.DeliveriesSelectProcTableAdapter();
            this.customerTableAdapter = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.indivisualDeliverTableAdapter = new shoping.advanceDataSetTableAdapters.IndivisualDeliverTableAdapter();
            this.proc_select_invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.employeeTableAdapter = new shoping.advanceDataSetTableAdapters.employeeTableAdapter();
            this.proc_select_invoiceTableAdapter = new shoping.advanceDataSetTableAdapters.proc_select_invoiceTableAdapter();
            this.tableAdapterManager1 = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter2 = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.employeeTableAdapter1 = new shoping.advanceDataSetTableAdapters.employeeTableAdapter();
            this.proc_select_invoiceTableAdapter1 = new shoping.advanceDataSetTableAdapters.proc_select_invoiceTableAdapter();
            this.tableAdapterManager2 = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab3_hid = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.indevisiual_deliv_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label_num = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_part = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_part = new System.Windows.Forms.ComboBox();
            this.combo_num = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.topToolStripLabel = new System.Windows.Forms.Label();
            this.partToolStripLabel = new System.Windows.Forms.Label();
            this.partToolStripTextBox = new System.Windows.Forms.ComboBox();
            this.topToolStripTextBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton44 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.last_account = new System.Windows.Forms.Label();
            this.last_accountTextBox = new System.Windows.Forms.TextBox();
            this.noticesLabel1 = new System.Windows.Forms.Label();
            this.noticesTextBox = new System.Windows.Forms.TextBox();
            this.deliver_dateLabel = new System.Windows.Forms.Label();
            this.deliver_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custom_nameTextBox = new System.Windows.Forms.ComboBox();
            this.customerDataTableTableAdapter1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delivery_idLabel1 = new System.Windows.Forms.Label();
            this.delivery_idTextBox = new System.Windows.Forms.TextBox();
            this.custom_nameLabel1 = new System.Windows.Forms.Label();
            this.delivered_moneyLabel1 = new System.Windows.Forms.Label();
            this.delivered_moneyTextBox = new System.Windows.Forms.TextBox();
            this.after_deliveringLabel = new System.Windows.Forms.Label();
            this.after_deliveringTextBox = new System.Windows.Forms.TextBox();
            this.emp_nameLabel1 = new System.Windows.Forms.Label();
            this.emp_nameTextBox = new System.Windows.Forms.TextBox();
            this.indivisualDeliverDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveriesSelectProcDataGridView = new System.Windows.Forms.DataGridView();
            this.deliveryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterdeliveringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_idLabel = new System.Windows.Forms.Label();
            this.d_id = new System.Windows.Forms.TextBox();
            this.custom_nameLabel = new System.Windows.Forms.Label();
            this.last_accountLabel = new System.Windows.Forms.Label();
            this.lastmony = new System.Windows.Forms.TextBox();
            this.delivered_moneyLabel = new System.Windows.Forms.Label();
            this.mony = new System.Windows.Forms.TextBox();
            this.noticesLabel = new System.Windows.Forms.Label();
            this.notices = new System.Windows.Forms.TextBox();
            this.emp_nameLabel = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.TextBox();
            this.deliveriesSelectProcBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.deliveriesSelectProcBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton45 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vwcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton35 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator36 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton36 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton37 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton38 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton39 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator40 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton40 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton42 = new System.Windows.Forms.ToolStripButton();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emppasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_idTextBox = new System.Windows.Forms.TextBox();
            this.emp_nameTextBox1 = new System.Windows.Forms.TextBox();
            this.emp_passwordTextBox = new System.Windows.Forms.TextBox();
            this.emp_statusTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataSet1 = new shoping.advanceDataSet();
            this.custom_idTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.credit1TextBox = new System.Windows.Forms.TextBox();
            this.end_totalTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.custom_phoneTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton41 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator45 = new System.Windows.Forms.ToolStripSeparator();
            this.home_nav = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.refrish = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.accounts = new System.Windows.Forms.ToolStripButton();
            this.space1 = new System.Windows.Forms.ToolStripSeparator();
            this.invoices = new System.Windows.Forms.ToolStripButton();
            this.space2 = new System.Windows.Forms.ToolStripSeparator();
            this.deliveries = new System.Windows.Forms.ToolStripButton();
            this.space3 = new System.Windows.Forms.ToolStripSeparator();
            this.panal_home = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.server_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wrongmsg = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.restore_connect = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton43 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton49 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator47 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton50 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton51 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator44 = new System.Windows.Forms.ToolStripSeparator();
            this.log = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.TextBox();
            this.spass = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.msgdisconnect = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.query = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.sales = new System.Windows.Forms.Button();
            this.stores = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.sale_monitor = new System.Windows.Forms.Button();
            this.store_monitor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerTableAdapter3 = new shoping.advanceDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager3 = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.advanceDataSet2 = new shoping.advanceDataSet();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager4 = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager5 = new shoping.advanceDataSetTableAdapters.TableAdapterManager();
            this.vw_customerTableAdapter = new shoping.advanceDataSetTableAdapters.vw_customerTableAdapter();
            this.customer_DataTableTableAdapter = new shoping.advanceDataSetTableAdapters.customer_DataTableTableAdapter();
            this.toolStripSeparator42 = new System.Windows.Forms.ToolStripSeparator();
            this.customer_DataTableTableAdapter1TableAdapter = new shoping.advanceDataSetTableAdapters.customer_DataTableTableAdapter1TableAdapter();
            end_totalLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            custom_idLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            custom_phoneLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            credit1Label = new System.Windows.Forms.Label();
            emp_idLabel = new System.Windows.Forms.Label();
            emp_nameLabel2 = new System.Windows.Forms.Label();
            emp_passwordLabel = new System.Windows.Forms.Label();
            emp_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.indivisualDeliverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proc_select_invoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proc_select_invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tab3_hid.SuspendLayout();
            this.indevisiual_deliv_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableTableAdapter1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indivisualDeliverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingNavigator)).BeginInit();
            this.deliveriesSelectProcBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.panal_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // end_totalLabel
            // 
            end_totalLabel.AutoSize = true;
            end_totalLabel.BackColor = System.Drawing.Color.DarkCyan;
            end_totalLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            end_totalLabel.ForeColor = System.Drawing.Color.White;
            end_totalLabel.Location = new System.Drawing.Point(771, 150);
            end_totalLabel.Name = "end_totalLabel";
            end_totalLabel.Size = new System.Drawing.Size(144, 31);
            end_totalLabel.TabIndex = 71;
            end_totalLabel.Text = "اجمالي الحساب الاجل:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.DarkCyan;
            statusLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(380, 106);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(94, 31);
            statusLabel.TabIndex = 69;
            statusLabel.Text = "حالة الحساب:";
            // 
            // custom_idLabel
            // 
            custom_idLabel.AutoSize = true;
            custom_idLabel.BackColor = System.Drawing.Color.DarkCyan;
            custom_idLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            custom_idLabel.ForeColor = System.Drawing.Color.White;
            custom_idLabel.Location = new System.Drawing.Point(828, 66);
            custom_idLabel.Name = "custom_idLabel";
            custom_idLabel.Size = new System.Drawing.Size(87, 31);
            custom_idLabel.TabIndex = 54;
            custom_idLabel.Text = "رقم الحساب:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.DarkCyan;
            label13.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(776, 109);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(99, 31);
            label13.TabIndex = 56;
            label13.Text = "اسم المستخدم:";
            label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // custom_phoneLabel
            // 
            custom_phoneLabel.AutoSize = true;
            custom_phoneLabel.BackColor = System.Drawing.Color.DarkCyan;
            custom_phoneLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            custom_phoneLabel.ForeColor = System.Drawing.Color.White;
            custom_phoneLabel.Location = new System.Drawing.Point(218, 61);
            custom_phoneLabel.Name = "custom_phoneLabel";
            custom_phoneLabel.Size = new System.Drawing.Size(82, 31);
            custom_phoneLabel.TabIndex = 58;
            custom_phoneLabel.Text = "رقم الهاتف:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.DarkCyan;
            genderLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(224, 109);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(47, 31);
            genderLabel.TabIndex = 60;
            genderLabel.Text = "النوع:";
            genderLabel.Visible = false;
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.BackColor = System.Drawing.Color.DarkCyan;
            start_dateLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            start_dateLabel.ForeColor = System.Drawing.Color.White;
            start_dateLabel.Location = new System.Drawing.Point(526, 59);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(139, 31);
            start_dateLabel.TabIndex = 61;
            start_dateLabel.Text = "تاريخ إنشاء الحساب:";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.BackColor = System.Drawing.Color.DarkCyan;
            creditLabel.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            creditLabel.ForeColor = System.Drawing.Color.White;
            creditLabel.Location = new System.Drawing.Point(486, 150);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(108, 31);
            creditLabel.TabIndex = 63;
            creditLabel.Text = "الحساب المدخر:";
            // 
            // credit1Label
            // 
            credit1Label.AutoSize = true;
            credit1Label.BackColor = System.Drawing.Color.DarkCyan;
            credit1Label.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            credit1Label.ForeColor = System.Drawing.Color.White;
            credit1Label.Location = new System.Drawing.Point(251, 153);
            credit1Label.Name = "credit1Label";
            credit1Label.Size = new System.Drawing.Size(61, 31);
            credit1Label.TabIndex = 65;
            credit1Label.Text = "الصافي:";
            credit1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            credit1Label.Click += new System.EventHandler(this.credit1Label_Click);
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(768, 67);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(63, 20);
            emp_idLabel.TabIndex = 0;
            emp_idLabel.Text = "رقم المسجل";
            // 
            // emp_nameLabel2
            // 
            emp_nameLabel2.AutoSize = true;
            emp_nameLabel2.Location = new System.Drawing.Point(768, 115);
            emp_nameLabel2.Name = "emp_nameLabel2";
            emp_nameLabel2.Size = new System.Drawing.Size(63, 20);
            emp_nameLabel2.TabIndex = 2;
            emp_nameLabel2.Text = "اسم المسجل";
            // 
            // emp_passwordLabel
            // 
            emp_passwordLabel.AutoSize = true;
            emp_passwordLabel.Location = new System.Drawing.Point(477, 120);
            emp_passwordLabel.Name = "emp_passwordLabel";
            emp_passwordLabel.Size = new System.Drawing.Size(63, 20);
            emp_passwordLabel.TabIndex = 4;
            emp_passwordLabel.Text = "كلمة المرور";
            // 
            // emp_statusLabel
            // 
            emp_statusLabel.AutoSize = true;
            emp_statusLabel.Location = new System.Drawing.Point(478, 73);
            emp_statusLabel.Name = "emp_statusLabel";
            emp_statusLabel.Size = new System.Drawing.Size(34, 20);
            emp_statusLabel.TabIndex = 6;
            emp_statusLabel.Text = "الحالة";
            // 
            // last_accountLabel1
            // 
            this.last_accountLabel1.AutoSize = true;
            this.last_accountLabel1.Location = new System.Drawing.Point(316, 71);
            this.last_accountLabel1.Name = "last_accountLabel1";
            this.last_accountLabel1.Size = new System.Drawing.Size(84, 18);
            this.last_accountLabel1.TabIndex = 51;
            this.last_accountLabel1.Text = "الحساب السابق";
            this.last_accountLabel1.Click += new System.EventHandler(this.last_accountLabel1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // indivisualDeliverBindingSource
            // 
            this.indivisualDeliverBindingSource.DataMember = "IndivisualDeliver";
            this.indivisualDeliverBindingSource.DataSource = this.advanceDataSet;
            // 
            // advanceDataSet
            // 
            this.advanceDataSet.DataSetName = "advanceDataSet";
            this.advanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.advanceDataSet;
            // 
            // deliveriesSelectProcBindingSource
            // 
            this.deliveriesSelectProcBindingSource.DataMember = "DeliveriesSelectProc";
            this.deliveriesSelectProcBindingSource.DataSource = this.advanceDataSet;
            // 
            // proc_select_invoiceBindingSource1
            // 
            this.proc_select_invoiceBindingSource1.DataMember = "proc_select_invoice";
            this.proc_select_invoiceBindingSource1.DataSource = this.advanceDataSet;
            // 
            // deliveriesSelectProcTableAdapter
            // 
            this.deliveriesSelectProcTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.IndivisualDeliverTableAdapter = this.indivisualDeliverTableAdapter;
            this.tableAdapterManager.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // indivisualDeliverTableAdapter
            // 
            this.indivisualDeliverTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // proc_select_invoiceTableAdapter
            // 
            this.proc_select_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager1.customerTableAdapter = null;
            this.tableAdapterManager1.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager1.deliveriesTableAdapter = null;
            this.tableAdapterManager1.employeeTableAdapter = null;
            this.tableAdapterManager1.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager1.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager1.invoiceTableAdapter = null;
            this.tableAdapterManager1.proc_select_invoiceTableAdapter = this.proc_select_invoiceTableAdapter;
            this.tableAdapterManager1.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // proc_select_invoiceTableAdapter1
            // 
            this.proc_select_invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager2.customerTableAdapter = null;
            this.tableAdapterManager2.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager2.deliveriesTableAdapter = null;
            this.tableAdapterManager2.employeeTableAdapter = null;
            this.tableAdapterManager2.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager2.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager2.invoiceTableAdapter = null;
            this.tableAdapterManager2.proc_select_invoiceTableAdapter = this.proc_select_invoiceTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage3.CausesValidation = false;
            this.tabPage3.Controls.Add(this.tab3_hid);
            this.tabPage3.Controls.Add(this.indevisiual_deliv_panel);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.deliveriesSelectProcDataGridView);
            this.tabPage3.Controls.Add(this.delivery_idLabel);
            this.tabPage3.Controls.Add(this.d_id);
            this.tabPage3.Controls.Add(this.custom_nameLabel);
            this.tabPage3.Controls.Add(this.last_accountLabel);
            this.tabPage3.Controls.Add(this.lastmony);
            this.tabPage3.Controls.Add(this.delivered_moneyLabel);
            this.tabPage3.Controls.Add(this.mony);
            this.tabPage3.Controls.Add(this.noticesLabel);
            this.tabPage3.Controls.Add(this.notices);
            this.tabPage3.Controls.Add(this.emp_nameLabel);
            this.tabPage3.Controls.Add(this.emp_name);
            this.tabPage3.Controls.Add(this.deliveriesSelectProcBindingNavigator);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "المسلمات";
            this.tabPage3.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tab3_hid
            // 
            this.tab3_hid.BackColor = System.Drawing.Color.DarkCyan;
            this.tab3_hid.Controls.Add(this.label15);
            this.tab3_hid.Location = new System.Drawing.Point(0, -7);
            this.tab3_hid.Name = "tab3_hid";
            this.tab3_hid.Size = new System.Drawing.Size(962, 645);
            this.tab3_hid.TabIndex = 52;
            this.tab3_hid.Paint += new System.Windows.Forms.PaintEventHandler(this.tab3_hid_Paint_2);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sakkal Majalla", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(448, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 43);
            this.label15.TabIndex = 1;
            this.label15.Text = "من فضلك سجل الدخول اولا";
            // 
            // indevisiual_deliv_panel
            // 
            this.indevisiual_deliv_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indevisiual_deliv_panel.Controls.Add(this.button3);
            this.indevisiual_deliv_panel.Controls.Add(this.print);
            this.indevisiual_deliv_panel.Controls.Add(this.groupBox1);
            this.indevisiual_deliv_panel.Controls.Add(this.label_num);
            this.indevisiual_deliv_panel.Controls.Add(this.label11);
            this.indevisiual_deliv_panel.Controls.Add(this.label_part);
            this.indevisiual_deliv_panel.Controls.Add(this.label12);
            this.indevisiual_deliv_panel.Controls.Add(this.combo_part);
            this.indevisiual_deliv_panel.Controls.Add(this.combo_num);
            this.indevisiual_deliv_panel.Controls.Add(this.comboBox2);
            this.indevisiual_deliv_panel.Controls.Add(this.comboBox3);
            this.indevisiual_deliv_panel.Controls.Add(this.topToolStripLabel);
            this.indevisiual_deliv_panel.Controls.Add(this.partToolStripLabel);
            this.indevisiual_deliv_panel.Controls.Add(this.partToolStripTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.topToolStripTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.bindingNavigator1);
            this.indevisiual_deliv_panel.Controls.Add(this.last_account);
            this.indevisiual_deliv_panel.Controls.Add(this.last_accountTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.noticesLabel1);
            this.indevisiual_deliv_panel.Controls.Add(this.noticesTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.deliver_dateLabel);
            this.indevisiual_deliv_panel.Controls.Add(this.deliver_dateDateTimePicker);
            this.indevisiual_deliv_panel.Controls.Add(this.custom_nameTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.delivery_idLabel1);
            this.indevisiual_deliv_panel.Controls.Add(this.delivery_idTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.custom_nameLabel1);
            this.indevisiual_deliv_panel.Controls.Add(this.delivered_moneyLabel1);
            this.indevisiual_deliv_panel.Controls.Add(this.delivered_moneyTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.after_deliveringLabel);
            this.indevisiual_deliv_panel.Controls.Add(this.after_deliveringTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.emp_nameLabel1);
            this.indevisiual_deliv_panel.Controls.Add(this.emp_nameTextBox);
            this.indevisiual_deliv_panel.Controls.Add(this.indivisualDeliverDataGridView);
            this.indevisiual_deliv_panel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indevisiual_deliv_panel.Location = new System.Drawing.Point(0, -1);
            this.indevisiual_deliv_panel.Name = "indevisiual_deliv_panel";
            this.indevisiual_deliv_panel.Size = new System.Drawing.Size(31778, 635);
            this.indevisiual_deliv_panel.TabIndex = 51;
            this.indevisiual_deliv_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.indevisiual_deliv_panel_Paint_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(13084, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 31);
            this.button3.TabIndex = 65;
            this.button3.Text = "طباعة كل المسلمات";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.print.Location = new System.Drawing.Point(811, 197);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(127, 31);
            this.print.TabIndex = 53;
            this.print.Text = "طباعة جدول المسلمات";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(94, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(701, 42);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التالي";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton12.Location = new System.Drawing.Point(108, -1);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(28, 35);
            this.radioButton12.TabIndex = 34;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton11.Location = new System.Drawing.Point(152, -1);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(28, 35);
            this.radioButton11.TabIndex = 33;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton10.Location = new System.Drawing.Point(199, -1);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(28, 35);
            this.radioButton10.TabIndex = 32;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton9.Location = new System.Drawing.Point(249, 0);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(20, 35);
            this.radioButton9.TabIndex = 31;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Location = new System.Drawing.Point(287, -1);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(20, 35);
            this.radioButton8.TabIndex = 30;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.Location = new System.Drawing.Point(326, -1);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(20, 35);
            this.radioButton7.TabIndex = 25;
            this.radioButton7.Text = "7";
            this.radioButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Location = new System.Drawing.Point(367, -2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(20, 35);
            this.radioButton6.TabIndex = 29;
            this.radioButton6.Text = "6";
            this.radioButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Location = new System.Drawing.Point(402, -1);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(20, 35);
            this.radioButton5.TabIndex = 28;
            this.radioButton5.Text = "5";
            this.radioButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(446, -1);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(20, 35);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.Text = "4";
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Location = new System.Drawing.Point(493, -1);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(20, 35);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.Text = "3";
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(538, -1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(20, 35);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "2";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(587, -1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(20, 35);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(818, 60);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(125, 18);
            this.label_num.TabIndex = 50;
            this.label_num.Text = "عدد المسلمات المستعرضة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10310, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "عدد المسلمات المستعرضة";
            // 
            // label_part
            // 
            this.label_part.AutoSize = true;
            this.label_part.Location = new System.Drawing.Point(718, 57);
            this.label_part.Name = "label_part";
            this.label_part.Size = new System.Drawing.Size(35, 18);
            this.label_part.TabIndex = 49;
            this.label_part.Text = "الجزء";
            this.label_part.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10562, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "الجزء";
            // 
            // combo_part
            // 
            this.combo_part.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_part.FormattingEnabled = true;
            this.combo_part.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.combo_part.Location = new System.Drawing.Point(662, 53);
            this.combo_part.Name = "combo_part";
            this.combo_part.Size = new System.Drawing.Size(51, 26);
            this.combo_part.TabIndex = 48;
            this.combo_part.Text = "1";
            this.combo_part.Visible = false;
            this.combo_part.SelectedIndexChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // combo_num
            // 
            this.combo_num.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_num.FormattingEnabled = true;
            this.combo_num.Items.AddRange(new object[] {
            "0",
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400"});
            this.combo_num.Location = new System.Drawing.Point(757, 54);
            this.combo_num.Name = "combo_num";
            this.combo_num.Size = new System.Drawing.Size(54, 26);
            this.combo_num.TabIndex = 47;
            this.combo_num.Text = "10";
            this.combo_num.SelectedIndexChanged += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "2",
            "20",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "3",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "4",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "5",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "6",
            "60",
            "7",
            "8",
            "9"});
            this.comboBox2.Location = new System.Drawing.Point(10611, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 26);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 61;
            this.comboBox2.Text = "1";
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400"});
            this.comboBox3.Location = new System.Drawing.Point(10483, 174);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(54, 26);
            this.comboBox3.TabIndex = 60;
            this.comboBox3.Text = "15";
            // 
            // topToolStripLabel
            // 
            this.topToolStripLabel.AutoSize = true;
            this.topToolStripLabel.Location = new System.Drawing.Point(9764, 193);
            this.topToolStripLabel.Name = "topToolStripLabel";
            this.topToolStripLabel.Size = new System.Drawing.Size(125, 18);
            this.topToolStripLabel.TabIndex = 59;
            this.topToolStripLabel.Text = "عدد المسلمات المستعرضة";
            // 
            // partToolStripLabel
            // 
            this.partToolStripLabel.AutoSize = true;
            this.partToolStripLabel.Location = new System.Drawing.Point(10016, 194);
            this.partToolStripLabel.Name = "partToolStripLabel";
            this.partToolStripLabel.Size = new System.Drawing.Size(35, 18);
            this.partToolStripLabel.TabIndex = 58;
            this.partToolStripLabel.Text = "الجزء";
            // 
            // partToolStripTextBox
            // 
            this.partToolStripTextBox.FormattingEnabled = true;
            this.partToolStripTextBox.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "2",
            "20",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "3",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "4",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "5",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "6",
            "60",
            "7",
            "8",
            "9"});
            this.partToolStripTextBox.Location = new System.Drawing.Point(10065, 190);
            this.partToolStripTextBox.Name = "partToolStripTextBox";
            this.partToolStripTextBox.Size = new System.Drawing.Size(51, 26);
            this.partToolStripTextBox.Sorted = true;
            this.partToolStripTextBox.TabIndex = 57;
            this.partToolStripTextBox.Text = "1";
            // 
            // topToolStripTextBox
            // 
            this.topToolStripTextBox.FormattingEnabled = true;
            this.topToolStripTextBox.Items.AddRange(new object[] {
            "1",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400"});
            this.topToolStripTextBox.Location = new System.Drawing.Point(9937, 191);
            this.topToolStripTextBox.Name = "topToolStripTextBox";
            this.topToolStripTextBox.Size = new System.Drawing.Size(54, 26);
            this.topToolStripTextBox.TabIndex = 56;
            this.topToolStripTextBox.Text = "15";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.AllowItemReorder = true;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.indivisualDeliverBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator15,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.saveToolStripButton,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripSeparator,
            this.toolStripButton7,
            this.toolStripSeparator12,
            this.toolStripSeparator17,
            this.toolStripButton13,
            this.toolStripSeparator13,
            this.toolStripButton44,
            this.toolStripButton12,
            this.toolStripSeparator18,
            this.toolStripButton17,
            this.toolStripSeparator14,
            this.toolStripButton16,
            this.toolStripSeparator19});
            this.bindingNavigator1.Location = new System.Drawing.Point(-4, 1);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(967, 45);
            this.bindingNavigator1.TabIndex = 54;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.Image = global::shoping.Properties.Resources.toolStripButton1_Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(89, 42);
            this.toolStripButton1.Text = "إضافة تسليم";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::shoping.Properties.Resources.toolStripButton2_Image;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(52, 42);
            this.toolStripButton2.Text = "حذف";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::shoping.Properties.Resources.toolStripButton3_Image;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::shoping.Properties.Resources.toolStripButton4_Image;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 42);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::shoping.Properties.Resources.toolStripButton5_Image;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::shoping.Properties.Resources.toolStripButton6_Image;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.CheckOnClick = true;
            this.saveToolStripButton.Image = global::shoping.Properties.Resources.saveToolStripButton_Image;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(50, 42);
            this.saveToolStripButton.Text = "حفظ";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click_1);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton11.Tag = "اعادة تحميل الصفحة";
            this.toolStripButton11.Text = "اعادة تحميل الصفحة";
            this.toolStripButton11.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::shoping.Properties.Resources.search_icon1;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(90, 42);
            this.toolStripButton7.Tag = "البحث بالاسم";
            this.toolStripButton7.Text = "البحث بالاسم";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click_1);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(66, 42);
            this.toolStripButton13.Tag = "الرئيسية";
            this.toolStripButton13.Text = "الرئيسية";
            this.toolStripButton13.Click += new System.EventHandler(this.back_tap1_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton44
            // 
            this.toolStripButton44.Image = global::shoping.Properties.Resources.avatar;
            this.toolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton44.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton44.Name = "toolStripButton44";
            this.toolStripButton44.Size = new System.Drawing.Size(72, 42);
            this.toolStripButton44.Tag = "الحسابات";
            this.toolStripButton44.Text = "الحسابات";
            this.toolStripButton44.ToolTipText = "الحسابات";
            this.toolStripButton44.Click += new System.EventHandler(this.sales_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(93, 42);
            this.toolStripButton12.Tag = "كل المسلمات";
            this.toolStripButton12.Text = "كل المسلمات";
            this.toolStripButton12.Click += new System.EventHandler(this.store_monitor_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(62, 42);
            this.toolStripButton17.Tag = "الفواتير";
            this.toolStripButton17.Text = "الفواتير";
            this.toolStripButton17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton17.Click += new System.EventHandler(this.stores_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton16.Text = "طباعة المسلمات";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 45);
            // 
            // last_account
            // 
            this.last_account.AutoSize = true;
            this.last_account.Location = new System.Drawing.Point(395, 97);
            this.last_account.Name = "last_account";
            this.last_account.Size = new System.Drawing.Size(75, 18);
            this.last_account.TabIndex = 53;
            this.last_account.Text = "الحساب السابق";
            // 
            // last_accountTextBox
            // 
            this.last_accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "last_account", true));
            this.last_accountTextBox.Location = new System.Drawing.Point(180, 91);
            this.last_accountTextBox.Name = "last_accountTextBox";
            this.last_accountTextBox.ReadOnly = true;
            this.last_accountTextBox.Size = new System.Drawing.Size(200, 26);
            this.last_accountTextBox.TabIndex = 52;
            this.last_accountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noticesLabel1
            // 
            this.noticesLabel1.AutoSize = true;
            this.noticesLabel1.Location = new System.Drawing.Point(396, 134);
            this.noticesLabel1.Name = "noticesLabel1";
            this.noticesLabel1.Size = new System.Drawing.Size(42, 18);
            this.noticesLabel1.TabIndex = 38;
            this.noticesLabel1.Text = "ملاحظة";
            // 
            // noticesTextBox
            // 
            this.noticesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "notices", true));
            this.noticesTextBox.Location = new System.Drawing.Point(102, 125);
            this.noticesTextBox.Name = "noticesTextBox";
            this.noticesTextBox.Size = new System.Drawing.Size(286, 26);
            this.noticesTextBox.TabIndex = 39;
            this.noticesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deliver_dateLabel
            // 
            this.deliver_dateLabel.AutoSize = true;
            this.deliver_dateLabel.Location = new System.Drawing.Point(394, 161);
            this.deliver_dateLabel.Name = "deliver_dateLabel";
            this.deliver_dateLabel.Size = new System.Drawing.Size(64, 18);
            this.deliver_dateLabel.TabIndex = 36;
            this.deliver_dateLabel.Text = "تاريخ التسليم";
            // 
            // deliver_dateDateTimePicker
            // 
            this.deliver_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.indivisualDeliverBindingSource, "deliver_date", true));
            this.deliver_dateDateTimePicker.Location = new System.Drawing.Point(163, 154);
            this.deliver_dateDateTimePicker.Name = "deliver_dateDateTimePicker";
            this.deliver_dateDateTimePicker.RightToLeftLayout = true;
            this.deliver_dateDateTimePicker.Size = new System.Drawing.Size(225, 26);
            this.deliver_dateDateTimePicker.TabIndex = 37;
            // 
            // custom_nameTextBox
            // 
            this.custom_nameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.custom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.indivisualDeliverBindingSource, "custom_name", true));
            this.custom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDataTableTableAdapter1BindingSource, "custom_name", true));
            this.custom_nameTextBox.DataSource = this.customerDataTableTableAdapter1BindingSource;
            this.custom_nameTextBox.DisplayMember = "custom_name";
            this.custom_nameTextBox.FormattingEnabled = true;
            this.custom_nameTextBox.Location = new System.Drawing.Point(540, 89);
            this.custom_nameTextBox.Name = "custom_nameTextBox";
            this.custom_nameTextBox.Size = new System.Drawing.Size(246, 26);
            this.custom_nameTextBox.TabIndex = 34;
            this.custom_nameTextBox.ValueMember = "custom_name";
            this.custom_nameTextBox.SelectedIndexChanged += new System.EventHandler(this.custom_nameTextBox_SelectedIndexChanged_2);
            this.custom_nameTextBox.MouseHover += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // customerDataTableTableAdapter1BindingSource
            // 
            this.customerDataTableTableAdapter1BindingSource.DataMember = "customer_DataTableTableAdapter1";
            this.customerDataTableTableAdapter1BindingSource.DataSource = this.advanceDataSet;
            // 
            // delivery_idLabel1
            // 
            this.delivery_idLabel1.AutoSize = true;
            this.delivery_idLabel1.Location = new System.Drawing.Point(575, 56);
            this.delivery_idLabel1.Name = "delivery_idLabel1";
            this.delivery_idLabel1.Size = new System.Drawing.Size(87, 18);
            this.delivery_idLabel1.TabIndex = 18;
            this.delivery_idLabel1.Text = "رقم فاتورة التسليم";
            // 
            // delivery_idTextBox
            // 
            this.delivery_idTextBox.BackColor = System.Drawing.Color.Khaki;
            this.delivery_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "delivery_id", true));
            this.delivery_idTextBox.Location = new System.Drawing.Point(453, 53);
            this.delivery_idTextBox.Multiline = true;
            this.delivery_idTextBox.Name = "delivery_idTextBox";
            this.delivery_idTextBox.ReadOnly = true;
            this.delivery_idTextBox.Size = new System.Drawing.Size(112, 27);
            this.delivery_idTextBox.TabIndex = 19;
            this.delivery_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custom_nameLabel1
            // 
            this.custom_nameLabel1.AutoSize = true;
            this.custom_nameLabel1.Location = new System.Drawing.Point(790, 91);
            this.custom_nameLabel1.Name = "custom_nameLabel1";
            this.custom_nameLabel1.Size = new System.Drawing.Size(68, 18);
            this.custom_nameLabel1.TabIndex = 20;
            this.custom_nameLabel1.Text = "اسم المستخدم";
            // 
            // delivered_moneyLabel1
            // 
            this.delivered_moneyLabel1.AutoSize = true;
            this.delivered_moneyLabel1.Location = new System.Drawing.Point(791, 124);
            this.delivered_moneyLabel1.Name = "delivered_moneyLabel1";
            this.delivered_moneyLabel1.Size = new System.Drawing.Size(67, 18);
            this.delivered_moneyLabel1.TabIndex = 24;
            this.delivered_moneyLabel1.Text = "القيمة المسلمة";
            // 
            // delivered_moneyTextBox
            // 
            this.delivered_moneyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delivered_moneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "delivered_money", true));
            this.delivered_moneyTextBox.Location = new System.Drawing.Point(577, 124);
            this.delivered_moneyTextBox.Name = "delivered_moneyTextBox";
            this.delivered_moneyTextBox.Size = new System.Drawing.Size(200, 26);
            this.delivered_moneyTextBox.TabIndex = 25;
            this.delivered_moneyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // after_deliveringLabel
            // 
            this.after_deliveringLabel.AutoSize = true;
            this.after_deliveringLabel.Location = new System.Drawing.Point(786, 158);
            this.after_deliveringLabel.Name = "after_deliveringLabel";
            this.after_deliveringLabel.Size = new System.Drawing.Size(92, 18);
            this.after_deliveringLabel.TabIndex = 26;
            this.after_deliveringLabel.Text = "الحساب بعد التسليم";
            // 
            // after_deliveringTextBox
            // 
            this.after_deliveringTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "after_delivering", true));
            this.after_deliveringTextBox.Location = new System.Drawing.Point(577, 155);
            this.after_deliveringTextBox.Name = "after_deliveringTextBox";
            this.after_deliveringTextBox.ReadOnly = true;
            this.after_deliveringTextBox.Size = new System.Drawing.Size(200, 26);
            this.after_deliveringTextBox.TabIndex = 27;
            this.after_deliveringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emp_nameLabel1
            // 
            this.emp_nameLabel1.AutoSize = true;
            this.emp_nameLabel1.Location = new System.Drawing.Point(276, 56);
            this.emp_nameLabel1.Name = "emp_nameLabel1";
            this.emp_nameLabel1.Size = new System.Drawing.Size(48, 18);
            this.emp_nameLabel1.TabIndex = 32;
            this.emp_nameLabel1.Text = "الموضف";
            // 
            // emp_nameTextBox
            // 
            this.emp_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indivisualDeliverBindingSource, "emp_name", true));
            this.emp_nameTextBox.Location = new System.Drawing.Point(111, 52);
            this.emp_nameTextBox.Multiline = true;
            this.emp_nameTextBox.Name = "emp_nameTextBox";
            this.emp_nameTextBox.ReadOnly = true;
            this.emp_nameTextBox.Size = new System.Drawing.Size(166, 26);
            this.emp_nameTextBox.TabIndex = 33;
            // 
            // indivisualDeliverDataGridView
            // 
            this.indivisualDeliverDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.indivisualDeliverDataGridView.AutoGenerateColumns = false;
            this.indivisualDeliverDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.indivisualDeliverDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.indivisualDeliverDataGridView.ColumnHeadersHeight = 41;
            this.indivisualDeliverDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.indivisualDeliverDataGridView.DataSource = this.indivisualDeliverBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.indivisualDeliverDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.indivisualDeliverDataGridView.Location = new System.Drawing.Point(22, 242);
            this.indivisualDeliverDataGridView.Name = "indivisualDeliverDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.indivisualDeliverDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.indivisualDeliverDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.indivisualDeliverDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Thistle;
            this.indivisualDeliverDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.RowTemplate.ErrorText = "خطاء في الإدخال";
            this.indivisualDeliverDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.indivisualDeliverDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.indivisualDeliverDataGridView.Size = new System.Drawing.Size(927, 391);
            this.indivisualDeliverDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "delivery_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "التسلسل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "custom_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "المستخدم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_account";
            this.dataGridViewTextBoxColumn3.HeaderText = "الحساب السابق";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "delivered_money";
            this.dataGridViewTextBoxColumn4.HeaderText = "القيمة المسلمة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "after_delivering";
            this.dataGridViewTextBoxColumn5.HeaderText = "الحساب بعد التسليم";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "notices";
            this.dataGridViewTextBoxColumn6.FillWeight = 200F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ملاحظة";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "deliver_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "التاريخ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "emp_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "الموظف";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveriesSelectProcBindingSource, "custom_name", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDataTableBindingSource, "custom_name", true));
            this.comboBox1.DataSource = this.customerDataTableBindingSource;
            this.comboBox1.DisplayMember = "custom_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(508, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 26);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Tag = "الاسم";
            this.comboBox1.ValueMember = "custom_name";
            this.comboBox1.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
            // 
            // customerDataTableBindingSource
            // 
            this.customerDataTableBindingSource.DataMember = "customer_DataTable";
            this.customerDataTableBindingSource.DataSource = this.advanceDataSet;
            // 
            // deliveriesSelectProcDataGridView
            // 
            this.deliveriesSelectProcDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.deliveriesSelectProcDataGridView.AllowUserToOrderColumns = true;
            this.deliveriesSelectProcDataGridView.AutoGenerateColumns = false;
            this.deliveriesSelectProcDataGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.deliveriesSelectProcDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deliveriesSelectProcDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesSelectProcDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.deliveriesSelectProcDataGridView.ColumnHeadersHeight = 41;
            this.deliveriesSelectProcDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryidDataGridViewTextBoxColumn,
            this.customnameDataGridViewTextBoxColumn,
            this.lastaccountDataGridViewTextBoxColumn,
            this.deliveredmoneyDataGridViewTextBoxColumn,
            this.afterdeliveringDataGridViewTextBoxColumn,
            this.deliverdateDataGridViewTextBoxColumn,
            this.noticesDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn});
            this.deliveriesSelectProcDataGridView.DataSource = this.deliveriesSelectProcBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveriesSelectProcDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.deliveriesSelectProcDataGridView.Location = new System.Drawing.Point(34, 163);
            this.deliveriesSelectProcDataGridView.Name = "deliveriesSelectProcDataGridView";
            this.deliveriesSelectProcDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesSelectProcDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.deliveriesSelectProcDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveriesSelectProcDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.deliveriesSelectProcDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.deliveriesSelectProcDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deliveriesSelectProcDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesSelectProcDataGridView.RowTemplate.ErrorText = "خطاء في ادخال القيم";
            this.deliveriesSelectProcDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesSelectProcDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deliveriesSelectProcDataGridView.Size = new System.Drawing.Size(891, 466);
            this.deliveriesSelectProcDataGridView.TabIndex = 32;
            this.deliveriesSelectProcDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveriesSelectProcDataGridView_CellContentClick);
            // 
            // deliveryidDataGridViewTextBoxColumn
            // 
            this.deliveryidDataGridViewTextBoxColumn.DataPropertyName = "delivery_id";
            this.deliveryidDataGridViewTextBoxColumn.HeaderText = "التسلسل";
            this.deliveryidDataGridViewTextBoxColumn.Name = "deliveryidDataGridViewTextBoxColumn";
            this.deliveryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryidDataGridViewTextBoxColumn.Width = 50;
            // 
            // customnameDataGridViewTextBoxColumn
            // 
            this.customnameDataGridViewTextBoxColumn.DataPropertyName = "custom_name";
            this.customnameDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.customnameDataGridViewTextBoxColumn.Name = "customnameDataGridViewTextBoxColumn";
            this.customnameDataGridViewTextBoxColumn.Width = 180;
            // 
            // lastaccountDataGridViewTextBoxColumn
            // 
            this.lastaccountDataGridViewTextBoxColumn.DataPropertyName = "last_account";
            this.lastaccountDataGridViewTextBoxColumn.HeaderText = "الحساب السابق";
            this.lastaccountDataGridViewTextBoxColumn.Name = "lastaccountDataGridViewTextBoxColumn";
            // 
            // deliveredmoneyDataGridViewTextBoxColumn
            // 
            this.deliveredmoneyDataGridViewTextBoxColumn.DataPropertyName = "delivered_money";
            this.deliveredmoneyDataGridViewTextBoxColumn.HeaderText = "القيمة المسلمة";
            this.deliveredmoneyDataGridViewTextBoxColumn.Name = "deliveredmoneyDataGridViewTextBoxColumn";
            // 
            // afterdeliveringDataGridViewTextBoxColumn
            // 
            this.afterdeliveringDataGridViewTextBoxColumn.DataPropertyName = "after_delivering";
            this.afterdeliveringDataGridViewTextBoxColumn.HeaderText = "الحساب بعد التسليم";
            this.afterdeliveringDataGridViewTextBoxColumn.Name = "afterdeliveringDataGridViewTextBoxColumn";
            this.afterdeliveringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverdateDataGridViewTextBoxColumn
            // 
            this.deliverdateDataGridViewTextBoxColumn.DataPropertyName = "deliver_date";
            this.deliverdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.deliverdateDataGridViewTextBoxColumn.Name = "deliverdateDataGridViewTextBoxColumn";
            // 
            // noticesDataGridViewTextBoxColumn
            // 
            this.noticesDataGridViewTextBoxColumn.DataPropertyName = "notices";
            this.noticesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.noticesDataGridViewTextBoxColumn.Name = "noticesDataGridViewTextBoxColumn";
            this.noticesDataGridViewTextBoxColumn.Width = 150;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.Width = 102;
            // 
            // delivery_idLabel
            // 
            this.delivery_idLabel.AutoSize = true;
            this.delivery_idLabel.Location = new System.Drawing.Point(644, 55);
            this.delivery_idLabel.Name = "delivery_idLabel";
            this.delivery_idLabel.Size = new System.Drawing.Size(94, 18);
            this.delivery_idLabel.TabIndex = 21;
            this.delivery_idLabel.Text = "رقم فاتورة التسليم";
            // 
            // d_id
            // 
            this.d_id.BackColor = System.Drawing.Color.Khaki;
            this.d_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesSelectProcBindingSource, "delivery_id", true));
            this.d_id.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.deliveriesSelectProcBindingSource, "delivery_id", true));
            this.d_id.Location = new System.Drawing.Point(533, 52);
            this.d_id.Name = "d_id";
            this.d_id.ReadOnly = true;
            this.d_id.Size = new System.Drawing.Size(73, 24);
            this.d_id.TabIndex = 22;
            this.d_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custom_nameLabel
            // 
            this.custom_nameLabel.AutoSize = true;
            this.custom_nameLabel.Location = new System.Drawing.Point(769, 94);
            this.custom_nameLabel.Name = "custom_nameLabel";
            this.custom_nameLabel.Size = new System.Drawing.Size(74, 18);
            this.custom_nameLabel.TabIndex = 23;
            this.custom_nameLabel.Text = "اسم المستخدم";
            // 
            // last_accountLabel
            // 
            this.last_accountLabel.AutoSize = true;
            this.last_accountLabel.Location = new System.Drawing.Point(376, 95);
            this.last_accountLabel.Name = "last_accountLabel";
            this.last_accountLabel.Size = new System.Drawing.Size(84, 18);
            this.last_accountLabel.TabIndex = 24;
            this.last_accountLabel.Text = "الحساب السابق";
            // 
            // lastmony
            // 
            this.lastmony.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesSelectProcBindingSource, "last_account", true));
            this.lastmony.Location = new System.Drawing.Point(194, 91);
            this.lastmony.Name = "lastmony";
            this.lastmony.ReadOnly = true;
            this.lastmony.Size = new System.Drawing.Size(170, 24);
            this.lastmony.TabIndex = 25;
            this.lastmony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastmony.TextChanged += new System.EventHandler(this.lastmony_TextChanged);
            // 
            // delivered_moneyLabel
            // 
            this.delivered_moneyLabel.AutoSize = true;
            this.delivered_moneyLabel.Location = new System.Drawing.Point(765, 130);
            this.delivered_moneyLabel.Name = "delivered_moneyLabel";
            this.delivered_moneyLabel.Size = new System.Drawing.Size(76, 18);
            this.delivered_moneyLabel.TabIndex = 26;
            this.delivered_moneyLabel.Text = "القيمة المسلمة";
            // 
            // mony
            // 
            this.mony.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mony.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesSelectProcBindingSource, "delivered_money", true));
            this.mony.Location = new System.Drawing.Point(589, 123);
            this.mony.Name = "mony";
            this.mony.Size = new System.Drawing.Size(170, 24);
            this.mony.TabIndex = 27;
            this.mony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noticesLabel
            // 
            this.noticesLabel.AutoSize = true;
            this.noticesLabel.Location = new System.Drawing.Point(380, 126);
            this.noticesLabel.Name = "noticesLabel";
            this.noticesLabel.Size = new System.Drawing.Size(46, 18);
            this.noticesLabel.TabIndex = 28;
            this.noticesLabel.Text = "ملاحظة";
            // 
            // notices
            // 
            this.notices.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesSelectProcBindingSource, "notices", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notices.Location = new System.Drawing.Point(126, 123);
            this.notices.Name = "notices";
            this.notices.Size = new System.Drawing.Size(237, 24);
            this.notices.TabIndex = 29;
            this.notices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emp_nameLabel
            // 
            this.emp_nameLabel.AutoSize = true;
            this.emp_nameLabel.Location = new System.Drawing.Point(471, 55);
            this.emp_nameLabel.Name = "emp_nameLabel";
            this.emp_nameLabel.Size = new System.Drawing.Size(48, 18);
            this.emp_nameLabel.TabIndex = 30;
            this.emp_nameLabel.Text = "الموظف";
            // 
            // emp_name
            // 
            this.emp_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesSelectProcBindingSource, "emp_name", true));
            this.emp_name.Location = new System.Drawing.Point(314, 51);
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            this.emp_name.Size = new System.Drawing.Size(125, 24);
            this.emp_name.TabIndex = 31;
            this.emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deliveriesSelectProcBindingNavigator
            // 
            this.deliveriesSelectProcBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.deliveriesSelectProcBindingNavigator.AllowItemReorder = true;
            this.deliveriesSelectProcBindingNavigator.AutoSize = false;
            this.deliveriesSelectProcBindingNavigator.BindingSource = this.deliveriesSelectProcBindingSource;
            this.deliveriesSelectProcBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.deliveriesSelectProcBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.deliveriesSelectProcBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.deliveriesSelectProcBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveriesSelectProcBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator16,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator20,
            this.deliveriesSelectProcBindingNavigatorSaveItem,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripSeparator9,
            this.toolStripSeparator24,
            this.toolStripButton8,
            this.toolStripSeparator10,
            this.toolStripButton45,
            this.toolStripButton18,
            this.toolStripSeparator8,
            this.toolStripButton19,
            this.toolStripButton10,
            this.toolStripSeparator23});
            this.deliveriesSelectProcBindingNavigator.Location = new System.Drawing.Point(-4, -1);
            this.deliveriesSelectProcBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.deliveriesSelectProcBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.deliveriesSelectProcBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.deliveriesSelectProcBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.deliveriesSelectProcBindingNavigator.Name = "deliveriesSelectProcBindingNavigator";
            this.deliveriesSelectProcBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.deliveriesSelectProcBindingNavigator.Size = new System.Drawing.Size(966, 45);
            this.deliveriesSelectProcBindingNavigator.Stretch = true;
            this.deliveriesSelectProcBindingNavigator.TabIndex = 20;
            this.deliveriesSelectProcBindingNavigator.Text = "bindingNavigator1";
            this.deliveriesSelectProcBindingNavigator.RefreshItems += new System.EventHandler(this.deliveriesSelectProcBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.CheckOnClick = true;
            this.bindingNavigatorAddNewItem.Image = global::shoping.Properties.Resources.toolStripButton1_Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(86, 42);
            this.bindingNavigatorAddNewItem.Text = "إضافة تسليم";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 42);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.CheckOnClick = true;
            this.bindingNavigatorDeleteItem.Image = global::shoping.Properties.Resources.toolStripButton2_Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 42);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::shoping.Properties.Resources.toolStripButton3_Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveFirstItem.Text = "أول سجل";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::shoping.Properties.Resources.toolStripButton4_Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMovePreviousItem.Text = "السابق";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::shoping.Properties.Resources.toolStripButton5_Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveNextItem.Text = "التالي";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::shoping.Properties.Resources.toolStripButton6_Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveLastItem.Text = "اخر سجل";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 45);
            // 
            // deliveriesSelectProcBindingNavigatorSaveItem
            // 
            this.deliveriesSelectProcBindingNavigatorSaveItem.CheckOnClick = true;
            this.deliveriesSelectProcBindingNavigatorSaveItem.Image = global::shoping.Properties.Resources.saveToolStripButton_Image;
            this.deliveriesSelectProcBindingNavigatorSaveItem.Name = "deliveriesSelectProcBindingNavigatorSaveItem";
            this.deliveriesSelectProcBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 42);
            this.deliveriesSelectProcBindingNavigatorSaveItem.Text = "حفظ ";
            this.deliveriesSelectProcBindingNavigatorSaveItem.Click += new System.EventHandler(this.deliveriesSelectProcBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 42);
            this.toolStripButton9.Tag = "اعادة تحميل الصفحة";
            this.toolStripButton9.Text = "اعادة تحميل الصفحة";
            this.toolStripButton9.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(65, 42);
            this.toolStripButton8.Tag = "الرئيسية";
            this.toolStripButton8.Text = "الرئيسية";
            this.toolStripButton8.Click += new System.EventHandler(this.back_tap1_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton45
            // 
            this.toolStripButton45.Image = global::shoping.Properties.Resources.avatar;
            this.toolStripButton45.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton45.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton45.Name = "toolStripButton45";
            this.toolStripButton45.Size = new System.Drawing.Size(69, 42);
            this.toolStripButton45.Tag = "الحسابات";
            this.toolStripButton45.Text = "الحسابات";
            this.toolStripButton45.ToolTipText = "الحسابات";
            this.toolStripButton45.Click += new System.EventHandler(this.sales_Click);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(62, 42);
            this.toolStripButton18.Tag = "الفواتير";
            this.toolStripButton18.Text = "الفواتير";
            this.toolStripButton18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton18.Click += new System.EventHandler(this.stores_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(167, 42);
            this.toolStripButton19.Tag = "المسلمات على حسب الحسابات";
            this.toolStripButton19.Text = "المسلمات على حسب الحسابات";
            this.toolStripButton19.Click += new System.EventHandler(this.products_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(103, 42);
            this.toolStripButton10.Text = "طباعة المسلمات";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 45);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.advanceDataSet;
            // 
            // vwcustomerBindingSource
            // 
            this.vwcustomerBindingSource.DataMember = "vw_customer";
            this.vwcustomerBindingSource.DataSource = this.advanceDataSet;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.advanceDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.customerDataGridView);
            this.tabPage2.Controls.Add(this.custom_idTextBox);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.start_dateDateTimePicker);
            this.tabPage2.Controls.Add(this.creditTextBox);
            this.tabPage2.Controls.Add(this.credit1TextBox);
            this.tabPage2.Controls.Add(this.end_totalTextBox);
            this.tabPage2.Controls.Add(this.statusTextBox);
            this.tabPage2.Controls.Add(this.genderTextBox);
            this.tabPage2.Controls.Add(this.custom_phoneTextBox);
            this.tabPage2.Controls.Add(end_totalLabel);
            this.tabPage2.Controls.Add(statusLabel);
            this.tabPage2.Controls.Add(custom_idLabel);
            this.tabPage2.Controls.Add(label13);
            this.tabPage2.Controls.Add(custom_phoneLabel);
            this.tabPage2.Controls.Add(genderLabel);
            this.tabPage2.Controls.Add(start_dateLabel);
            this.tabPage2.Controls.Add(creditLabel);
            this.tabPage2.Controls.Add(credit1Label);
            this.tabPage2.Controls.Add(this.customerBindingNavigator);
            this.tabPage2.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 652);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "الحسابات";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(27, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 642);
            this.panel1.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sakkal Majalla", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(451, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(307, 43);
            this.label14.TabIndex = 0;
            this.label14.Text = "من فضلك سجل الدخول اولا";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bindingNavigator3);
            this.panel3.Controls.Add(this.employeeDataGridView);
            this.panel3.Controls.Add(emp_idLabel);
            this.panel3.Controls.Add(this.emp_idTextBox);
            this.panel3.Controls.Add(emp_nameLabel2);
            this.panel3.Controls.Add(this.emp_nameTextBox1);
            this.panel3.Controls.Add(emp_passwordLabel);
            this.panel3.Controls.Add(this.emp_passwordTextBox);
            this.panel3.Controls.Add(emp_statusLabel);
            this.panel3.Controls.Add(this.emp_statusTextBox);
            this.panel3.Location = new System.Drawing.Point(0, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 639);
            this.panel3.TabIndex = 73;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton30;
            this.bindingNavigator3.AllowItemReorder = true;
            this.bindingNavigator3.AutoSize = false;
            this.bindingNavigator3.BindingSource = this.employeeBindingSource1;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = this.toolStripButton31;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton32,
            this.toolStripButton33,
            this.toolStripSeparator33,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator34,
            this.toolStripButton34,
            this.toolStripButton35,
            this.toolStripSeparator35,
            this.toolStripButton30,
            this.toolStripButton31,
            this.toolStripSeparator36,
            this.toolStripButton36,
            this.toolStripSeparator37,
            this.toolStripButton37,
            this.toolStripSeparator38,
            this.toolStripButton38,
            this.toolStripSeparator39,
            this.toolStripButton39,
            this.toolStripSeparator40,
            this.toolStripButton40,
            this.toolStripButton42});
            this.bindingNavigator3.Location = new System.Drawing.Point(28, 5);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton32;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton35;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton34;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton33;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator3.Size = new System.Drawing.Size(963, 44);
            this.bindingNavigator3.TabIndex = 53;
            this.bindingNavigator3.Text = "bindingNavigator1";
            // 
            // toolStripButton30
            // 
            this.toolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton30.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton30.Image")));
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.RightToLeftAutoMirrorImage = true;
            this.toolStripButton30.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton30.Text = "Add new";
            this.toolStripButton30.Click += new System.EventHandler(this.toolStripButton30_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "employee";
            this.employeeBindingSource1.DataSource = this.advanceDataSet;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 41);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton31
            // 
            this.toolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton31.Image")));
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.RightToLeftAutoMirrorImage = true;
            this.toolStripButton31.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton31.Text = "Delete";
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton32.Image")));
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.RightToLeftAutoMirrorImage = true;
            this.toolStripButton32.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton32.Text = "Move first";
            // 
            // toolStripButton33
            // 
            this.toolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton33.Image")));
            this.toolStripButton33.Name = "toolStripButton33";
            this.toolStripButton33.RightToLeftAutoMirrorImage = true;
            this.toolStripButton33.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton33.Text = "Move previous";
            // 
            // toolStripSeparator33
            // 
            this.toolStripSeparator33.Name = "toolStripSeparator33";
            this.toolStripSeparator33.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(55, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator34
            // 
            this.toolStripSeparator34.Name = "toolStripSeparator34";
            this.toolStripSeparator34.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.RightToLeftAutoMirrorImage = true;
            this.toolStripButton34.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton34.Text = "Move next";
            // 
            // toolStripButton35
            // 
            this.toolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton35.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton35.Image")));
            this.toolStripButton35.Name = "toolStripButton35";
            this.toolStripButton35.RightToLeftAutoMirrorImage = true;
            this.toolStripButton35.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton35.Text = "Move last";
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            this.toolStripSeparator35.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator36
            // 
            this.toolStripSeparator36.Name = "toolStripSeparator36";
            this.toolStripSeparator36.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton36
            // 
            this.toolStripButton36.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton36.Image")));
            this.toolStripButton36.Name = "toolStripButton36";
            this.toolStripButton36.Size = new System.Drawing.Size(50, 41);
            this.toolStripButton36.Text = "حفظ";
            this.toolStripButton36.Click += new System.EventHandler(this.toolStripButton36_Click);
            // 
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            this.toolStripSeparator37.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton37
            // 
            this.toolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton37.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton37.Image")));
            this.toolStripButton37.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton37.Name = "toolStripButton37";
            this.toolStripButton37.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton37.Text = "اعادة تحميل الصفحة";
            this.toolStripButton37.Click += new System.EventHandler(this.home_Load);
            // 
            // toolStripSeparator38
            // 
            this.toolStripSeparator38.Name = "toolStripSeparator38";
            this.toolStripSeparator38.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton38
            // 
            this.toolStripButton38.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton38.Image")));
            this.toolStripButton38.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton38.Name = "toolStripButton38";
            this.toolStripButton38.Size = new System.Drawing.Size(66, 41);
            this.toolStripButton38.Tag = "الرئيسية";
            this.toolStripButton38.Text = "الرئيسية";
            this.toolStripButton38.Click += new System.EventHandler(this.back_tap1_Click);
            // 
            // toolStripSeparator39
            // 
            this.toolStripSeparator39.Name = "toolStripSeparator39";
            this.toolStripSeparator39.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton39
            // 
            this.toolStripButton39.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton39.Image")));
            this.toolStripButton39.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton39.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton39.Name = "toolStripButton39";
            this.toolStripButton39.Size = new System.Drawing.Size(62, 41);
            this.toolStripButton39.Tag = "الفواتير";
            this.toolStripButton39.Text = "الفواتير";
            this.toolStripButton39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton39.Click += new System.EventHandler(this.stores_Click);
            // 
            // toolStripSeparator40
            // 
            this.toolStripSeparator40.Name = "toolStripSeparator40";
            this.toolStripSeparator40.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton40
            // 
            this.toolStripButton40.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton40.Image")));
            this.toolStripButton40.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton40.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton40.Name = "toolStripButton40";
            this.toolStripButton40.Size = new System.Drawing.Size(76, 41);
            this.toolStripButton40.Tag = "المسلمات";
            this.toolStripButton40.Text = "المسلمات";
            this.toolStripButton40.Click += new System.EventHandler(this.products_Click);
            // 
            // toolStripButton42
            // 
            this.toolStripButton42.Image = global::shoping.Properties.Resources.avatar;
            this.toolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton42.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton42.Name = "toolStripButton42";
            this.toolStripButton42.Size = new System.Drawing.Size(72, 41);
            this.toolStripButton42.Tag = "الحسابات";
            this.toolStripButton42.Text = "الحسابات";
            this.toolStripButton42.ToolTipText = "الحسابات";
            this.toolStripButton42.Click += new System.EventHandler(this.sales_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToOrderColumns = true;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.employeeDataGridView.ColumnHeadersHeight = 41;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn1,
            this.emppasswordDataGridViewTextBoxColumn,
            this.empstatusDataGridViewTextBoxColumn});
            this.employeeDataGridView.DataSource = this.employeeBindingSource1;
            this.employeeDataGridView.Location = new System.Drawing.Point(140, 201);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(751, 412);
            this.employeeDataGridView.TabIndex = 8;
            this.employeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellContentClick);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "رقم المسجل";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn1
            // 
            this.empnameDataGridViewTextBoxColumn1.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn1.HeaderText = "اسم المسجل";
            this.empnameDataGridViewTextBoxColumn1.Name = "empnameDataGridViewTextBoxColumn1";
            this.empnameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // emppasswordDataGridViewTextBoxColumn
            // 
            this.emppasswordDataGridViewTextBoxColumn.DataPropertyName = "emp_password";
            this.emppasswordDataGridViewTextBoxColumn.HeaderText = "كلمة المرور";
            this.emppasswordDataGridViewTextBoxColumn.Name = "emppasswordDataGridViewTextBoxColumn";
            this.emppasswordDataGridViewTextBoxColumn.Width = 200;
            // 
            // empstatusDataGridViewTextBoxColumn
            // 
            this.empstatusDataGridViewTextBoxColumn.DataPropertyName = "emp_status";
            this.empstatusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.empstatusDataGridViewTextBoxColumn.Name = "empstatusDataGridViewTextBoxColumn";
            this.empstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "emp_id", true));
            this.emp_idTextBox.Location = new System.Drawing.Point(586, 70);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(176, 24);
            this.emp_idTextBox.TabIndex = 1;
            // 
            // emp_nameTextBox1
            // 
            this.emp_nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "emp_name", true));
            this.emp_nameTextBox1.Location = new System.Drawing.Point(586, 118);
            this.emp_nameTextBox1.Name = "emp_nameTextBox1";
            this.emp_nameTextBox1.Size = new System.Drawing.Size(176, 24);
            this.emp_nameTextBox1.TabIndex = 3;
            // 
            // emp_passwordTextBox
            // 
            this.emp_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "emp_password", true));
            this.emp_passwordTextBox.Location = new System.Drawing.Point(291, 121);
            this.emp_passwordTextBox.Name = "emp_passwordTextBox";
            this.emp_passwordTextBox.PasswordChar = '*';
            this.emp_passwordTextBox.Size = new System.Drawing.Size(176, 24);
            this.emp_passwordTextBox.TabIndex = 5;
            // 
            // emp_statusTextBox
            // 
            this.emp_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "emp_status", true));
            this.emp_statusTextBox.Location = new System.Drawing.Point(289, 72);
            this.emp_statusTextBox.Name = "emp_statusTextBox";
            this.emp_statusTextBox.Size = new System.Drawing.Size(176, 24);
            this.emp_statusTextBox.TabIndex = 7;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.customerDataGridView.ColumnHeadersHeight = 39;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.customerDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "custom_id", true));
            this.customerDataGridView.DataSource = this.customerBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.customerDataGridView.Location = new System.Drawing.Point(53, 201);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerDataGridView.Name = "customerDataGridView";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 38;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.customerDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customerDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowTemplate.ErrorText = "خطاء في البيانات";
            this.customerDataGridView.RowTemplate.Height = 33;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(928, 399);
            this.customerDataGridView.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "custom_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "رقم الحساب";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "custom_name";
            this.dataGridViewTextBoxColumn10.HeaderText = "اسم المستخدم";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 230;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "end_total";
            this.dataGridViewTextBoxColumn11.HeaderText = "إجمالي الاجل  /(ريال)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "credit";
            this.dataGridViewTextBoxColumn12.HeaderText = "المدخر  /(ريال)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "credit1";
            this.dataGridViewTextBoxColumn13.HeaderText = "الصافي /(ريال)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 130;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn14.HeaderText = "الحالة";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn15.HeaderText = "تاريخ إنشاء الحساب";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 140;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn16.HeaderText = "النوع";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "custom_phone";
            this.dataGridViewTextBoxColumn17.HeaderText = "رقم الهاتف";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "customer";
            this.bindingSource1.DataSource = this.advanceDataSet1;
            // 
            // advanceDataSet1
            // 
            this.advanceDataSet1.DataSetName = "advanceDataSet";
            this.advanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custom_idTextBox
            // 
            this.custom_idTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.custom_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_id", true));
            this.custom_idTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.custom_idTextBox.Location = new System.Drawing.Point(720, 68);
            this.custom_idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_idTextBox.Multiline = true;
            this.custom_idTextBox.Name = "custom_idTextBox";
            this.custom_idTextBox.ReadOnly = true;
            this.custom_idTextBox.Size = new System.Drawing.Size(91, 30);
            this.custom_idTextBox.TabIndex = 55;
            this.custom_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_name", true));
            this.textBox3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox3.Location = new System.Drawing.Point(547, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 30);
            this.textBox3.TabIndex = 57;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.start_dateDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(320, 59);
            this.start_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.start_dateDateTimePicker.TabIndex = 62;
            // 
            // creditTextBox
            // 
            this.creditTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.creditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "credit", true));
            this.creditTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.creditTextBox.Location = new System.Drawing.Point(350, 151);
            this.creditTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditTextBox.Multiline = true;
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(141, 30);
            this.creditTextBox.TabIndex = 64;
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // credit1TextBox
            // 
            this.credit1TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.credit1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credit1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "credit1", true));
            this.credit1TextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.credit1TextBox.Location = new System.Drawing.Point(128, 156);
            this.credit1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credit1TextBox.Multiline = true;
            this.credit1TextBox.Name = "credit1TextBox";
            this.credit1TextBox.ReadOnly = true;
            this.credit1TextBox.Size = new System.Drawing.Size(113, 28);
            this.credit1TextBox.TabIndex = 66;
            this.credit1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // end_totalTextBox
            // 
            this.end_totalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.end_totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.end_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "end_total", true));
            this.end_totalTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.end_totalTextBox.Location = new System.Drawing.Point(623, 152);
            this.end_totalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.end_totalTextBox.Multiline = true;
            this.end_totalTextBox.Name = "end_totalTextBox";
            this.end_totalTextBox.Size = new System.Drawing.Size(138, 29);
            this.end_totalTextBox.TabIndex = 72;
            this.end_totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusTextBox.Location = new System.Drawing.Point(303, 103);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(72, 33);
            this.statusTextBox.TabIndex = 70;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.genderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "gender", true));
            this.genderTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.genderTextBox.Location = new System.Drawing.Point(128, 104);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderTextBox.Multiline = true;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(89, 33);
            this.genderTextBox.TabIndex = 68;
            this.genderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genderTextBox.Visible = false;
            // 
            // custom_phoneTextBox
            // 
            this.custom_phoneTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.custom_phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "custom_phone", true));
            this.custom_phoneTextBox.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.custom_phoneTextBox.Location = new System.Drawing.Point(34, 60);
            this.custom_phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_phoneTextBox.Multiline = true;
            this.custom_phoneTextBox.Name = "custom_phoneTextBox";
            this.custom_phoneTextBox.Size = new System.Drawing.Size(183, 32);
            this.custom_phoneTextBox.TabIndex = 59;
            this.custom_phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.toolStripButton23;
            this.customerBindingNavigator.AllowItemReorder = true;
            this.customerBindingNavigator.AutoSize = false;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.toolStripLabel2;
            this.customerBindingNavigator.DeleteItem = this.toolStripButton24;
            this.customerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton25,
            this.toolStripButton26,
            this.toolStripSeparator28,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator29,
            this.toolStripButton27,
            this.toolStripButton28,
            this.toolStripSeparator30,
            this.toolStripButton23,
            this.toolStripButton24,
            this.toolStripSeparator31,
            this.customerBindingNavigatorSaveItem,
            this.toolStripSeparator32,
            this.toolStripButton29,
            this.toolStripSeparator27,
            this.toolStripButton20,
            this.toolStripSeparator26,
            this.toolStripButton21,
            this.toolStripSeparator25,
            this.toolStripButton22,
            this.toolStripButton41});
            this.customerBindingNavigator.Location = new System.Drawing.Point(28, 0);
            this.customerBindingNavigator.MoveFirstItem = this.toolStripButton25;
            this.customerBindingNavigator.MoveLastItem = this.toolStripButton28;
            this.customerBindingNavigator.MoveNextItem = this.toolStripButton27;
            this.customerBindingNavigator.MovePreviousItem = this.toolStripButton26;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.toolStripTextBox2;
            this.customerBindingNavigator.Size = new System.Drawing.Size(963, 50);
            this.customerBindingNavigator.TabIndex = 52;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton23.Text = "Add new";
            this.toolStripButton23.Click += new System.EventHandler(this.toolStripButton23_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 47);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton24.Text = "Delete";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton25.Text = "Move first";
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.RightToLeftAutoMirrorImage = true;
            this.toolStripButton26.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton26.Text = "Move previous";
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(55, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator29
            // 
            this.toolStripSeparator29.Name = "toolStripSeparator29";
            this.toolStripSeparator29.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton27.Text = "Move next";
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.RightToLeftAutoMirrorImage = true;
            this.toolStripButton28.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton28.Text = "Move last";
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            this.toolStripSeparator30.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator31
            // 
            this.toolStripSeparator31.Name = "toolStripSeparator31";
            this.toolStripSeparator31.Size = new System.Drawing.Size(6, 50);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 47);
            this.customerBindingNavigatorSaveItem.Text = "حفظ";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator32
            // 
            this.toolStripSeparator32.Name = "toolStripSeparator32";
            this.toolStripSeparator32.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton29
            // 
            this.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton29.Image")));
            this.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton29.Text = "اعادة تحميل الصفحة";
            this.toolStripButton29.Click += new System.EventHandler(this.toolStripButton29_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.Size = new System.Drawing.Size(66, 47);
            this.toolStripButton20.Tag = "الرئيسية";
            this.toolStripButton20.Text = "الرئيسية";
            this.toolStripButton20.Click += new System.EventHandler(this.back_tap1_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton21.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(62, 47);
            this.toolStripButton21.Tag = "الفواتير";
            this.toolStripButton21.Text = "الفواتير";
            this.toolStripButton21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton21.Click += new System.EventHandler(this.stores_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton22.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.Size = new System.Drawing.Size(76, 47);
            this.toolStripButton22.Tag = "المسلمات";
            this.toolStripButton22.Text = "المسلمات";
            this.toolStripButton22.Click += new System.EventHandler(this.products_Click);
            // 
            // toolStripButton41
            // 
            this.toolStripButton41.Image = global::shoping.Properties.Resources.avatar;
            this.toolStripButton41.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton41.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton41.Name = "toolStripButton41";
            this.toolStripButton41.Size = new System.Drawing.Size(74, 47);
            this.toolStripButton41.Tag = "المسجلين";
            this.toolStripButton41.Text = "المسجلين";
            this.toolStripButton41.ToolTipText = "المسجلين";
            this.toolStripButton41.Click += new System.EventHandler(this.toolStripButton41_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(500, 40);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 700);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Tag = "الرئيسية";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(this.panal_home);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel_login);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 652);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "الرئيسية";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(-4, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 34);
            this.button10.TabIndex = 58;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.AllowItemReorder = true;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.BindingSource = this.indivisualDeliverBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator45,
            this.home_nav,
            this.toolStripSeparator21,
            this.refrish,
            this.toolStripSeparator22,
            this.toolStripButton14,
            this.toolStripSeparator6,
            this.toolStripButton15,
            this.toolStripSeparator7,
            this.accounts,
            this.space1,
            this.invoices,
            this.space2,
            this.deliveries,
            this.space3});
            this.bindingNavigator2.Location = new System.Drawing.Point(-89, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(1050, 48);
            this.bindingNavigator2.TabIndex = 57;
            this.bindingNavigator2.Text = "0";
            this.bindingNavigator2.RefreshItems += new System.EventHandler(this.bindingNavigator2_RefreshItems_1);
            // 
            // toolStripSeparator45
            // 
            this.toolStripSeparator45.Name = "toolStripSeparator45";
            this.toolStripSeparator45.Size = new System.Drawing.Size(6, 48);
            // 
            // home_nav
            // 
            this.home_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.home_nav.Image = ((System.Drawing.Image)(resources.GetObject("home_nav.Image")));
            this.home_nav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home_nav.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.home_nav.Name = "home_nav";
            this.home_nav.RightToLeftAutoMirrorImage = true;
            this.home_nav.Size = new System.Drawing.Size(56, 45);
            this.home_nav.Tag = "الرئيسية";
            this.home_nav.Text = " الرئيسية ";
            this.home_nav.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.home_nav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_nav.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 48);
            // 
            // refrish
            // 
            this.refrish.Image = ((System.Drawing.Image)(resources.GetObject("refrish.Image")));
            this.refrish.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refrish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrish.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.refrish.Name = "refrish";
            this.refrish.Size = new System.Drawing.Size(110, 45);
            this.refrish.Tag = "اعادة تحميل الصفحة";
            this.refrish.Text = "اعادة تحميل الصفحة";
            this.refrish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refrish.Click += new System.EventHandler(this.home_Load);
            this.refrish.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::shoping.Properties.Resources.search_icon11;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(49, 45);
            this.toolStripButton14.Tag = "استعلام ";
            this.toolStripButton14.Text = "استعلام";
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton14.Click += new System.EventHandler(this.query_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(81, 45);
            this.toolStripButton15.Tag = "تسجيل الدخول";
            this.toolStripButton15.Text = "تسجيل الدخول";
            this.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton15.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 48);
            this.toolStripSeparator7.Click += new System.EventHandler(this.toolStripSeparator7_Click);
            // 
            // accounts
            // 
            this.accounts.Image = global::shoping.Properties.Resources.avatar;
            this.accounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accounts.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.accounts.Name = "accounts";
            this.accounts.Size = new System.Drawing.Size(56, 45);
            this.accounts.Tag = "الحسابات";
            this.accounts.Text = "الحسابات";
            this.accounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accounts.ToolTipText = "الحسابات";
            this.accounts.Visible = false;
            this.accounts.Click += new System.EventHandler(this.sales_Click);
            // 
            // space1
            // 
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(6, 48);
            this.space1.Visible = false;
            // 
            // invoices
            // 
            this.invoices.Image = ((System.Drawing.Image)(resources.GetObject("invoices.Image")));
            this.invoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invoices.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.invoices.Name = "invoices";
            this.invoices.Size = new System.Drawing.Size(46, 45);
            this.invoices.Tag = "الفواتير";
            this.invoices.Text = "الفواتير";
            this.invoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.invoices.Visible = false;
            this.invoices.Click += new System.EventHandler(this.stores_Click);
            // 
            // space2
            // 
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(6, 48);
            this.space2.Visible = false;
            // 
            // deliveries
            // 
            this.deliveries.Image = ((System.Drawing.Image)(resources.GetObject("deliveries.Image")));
            this.deliveries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deliveries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.deliveries.Name = "deliveries";
            this.deliveries.Size = new System.Drawing.Size(60, 45);
            this.deliveries.Tag = "المسلمات";
            this.deliveries.Text = "المسلمات";
            this.deliveries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deliveries.Visible = false;
            this.deliveries.Click += new System.EventHandler(this.products_Click);
            // 
            // space3
            // 
            this.space3.Name = "space3";
            this.space3.Size = new System.Drawing.Size(6, 48);
            this.space3.Visible = false;
            // 
            // panal_home
            // 
            this.panal_home.Controls.Add(this.pictureBox4);
            this.panal_home.Controls.Add(this.pictureBox3);
            this.panal_home.Controls.Add(this.label8);
            this.panal_home.Controls.Add(this.server_name);
            this.panal_home.Controls.Add(this.label1);
            this.panal_home.Controls.Add(this.label5);
            this.panal_home.Controls.Add(this.wrongmsg);
            this.panal_home.Controls.Add(this.label6);
            this.panal_home.Controls.Add(this.restore_connect);
            this.panal_home.Location = new System.Drawing.Point(275, 38);
            this.panal_home.Name = "panal_home";
            this.panal_home.Size = new System.Drawing.Size(398, 614);
            this.panal_home.TabIndex = 18;
            this.panal_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panal_home_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(61, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(279, 170);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(97, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 212);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "اختر الخادم للأتصال";
            // 
            // server_name
            // 
            this.server_name.BackColor = System.Drawing.Color.Thistle;
            this.server_name.FormattingEnabled = true;
            this.server_name.Items.AddRange(new object[] {
            "DESKTOP-U0A2IQP\\HOSSAM",
            "DESKTOP-NNFPL6R",
            "HOSSAM\\MSSQL"});
            this.server_name.Location = new System.Drawing.Point(32, 512);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(192, 31);
            this.server_name.TabIndex = 35;
            this.server_name.Text = "DESKTOP-U0A2IQP\\HOSSAM";
            this.server_name.MouseHover += new System.EventHandler(this.server_name_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(47, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "design by eng : Hossam ALyaari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(64, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 64);
            this.label5.TabIndex = 30;
            this.label5.Text = "        تطبيق سجلات الاجل \r\n       محلات الحسين مرحبا";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // wrongmsg
            // 
            this.wrongmsg.AutoSize = true;
            this.wrongmsg.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongmsg.LinkColor = System.Drawing.Color.DarkRed;
            this.wrongmsg.Location = new System.Drawing.Point(76, 238);
            this.wrongmsg.Name = "wrongmsg";
            this.wrongmsg.Size = new System.Drawing.Size(0, 30);
            this.wrongmsg.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 29;
            // 
            // restore_connect
            // 
            this.restore_connect.AutoSize = true;
            this.restore_connect.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restore_connect.Location = new System.Drawing.Point(76, 269);
            this.restore_connect.Name = "restore_connect";
            this.restore_connect.Size = new System.Drawing.Size(13, 30);
            this.restore_connect.TabIndex = 26;
            this.restore_connect.TabStop = true;
            this.restore_connect.Text = "\r\n";
            this.restore_connect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restore_connect_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Location = new System.Drawing.Point(276, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 553);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(38, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "رجوع";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.back_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(37, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(327, 53);
            this.button5.TabIndex = 20;
            this.button5.Text = "السجلات بشكل فردي";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.store_monitor_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Olive;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(36, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(327, 53);
            this.button6.TabIndex = 19;
            this.button6.Text = "Sale Monitor";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Teal;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(38, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(327, 53);
            this.button7.TabIndex = 18;
            this.button7.Text = "سجلات المسلمات";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.products_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SeaGreen;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(38, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(327, 53);
            this.button8.TabIndex = 17;
            this.button8.Text = "سجلات الدين";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.stores_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Brown;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(38, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(327, 53);
            this.button9.TabIndex = 16;
            this.button9.Text = "إنشاء حساب جديد";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.sales_Click);
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_login.Controls.Add(this.button12);
            this.panel_login.Controls.Add(this.msg);
            this.panel_login.Controls.Add(this.label9);
            this.panel_login.Controls.Add(this.label10);
            this.panel_login.Controls.Add(this.textBox1);
            this.panel_login.Controls.Add(this.textBox2);
            this.panel_login.Controls.Add(this.button13);
            this.panel_login.Location = new System.Drawing.Point(275, 44);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(394, 613);
            this.panel_login.TabIndex = 8;
            this.panel_login.Visible = false;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button12.ForeColor = System.Drawing.Color.DarkRed;
            this.button12.Location = new System.Drawing.Point(34, 15);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 43);
            this.button12.TabIndex = 30;
            this.button12.Text = "رجوع";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.back_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Tahoma", 12F);
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(157, 20);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 19);
            this.msg.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(267, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "كلمة المرور";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(261, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "اسم المستخدم";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Bisque;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(57, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(202, 35);
            this.textBox1.TabIndex = 26;
            this.textBox1.Tag = "";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Bisque;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(55, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 33);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button13.Location = new System.Drawing.Point(54, 164);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(292, 48);
            this.button13.TabIndex = 24;
            this.button13.Text = "تسجيل الدخول";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.log_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.bindingNavigator4);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(961, 652);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "إدارة النظام";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sakkal Majalla", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(445, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(307, 43);
            this.label16.TabIndex = 59;
            this.label16.Text = "من فضلك سجل الدخول اولا";
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.AllowItemReorder = true;
            this.bindingNavigator4.AutoSize = false;
            this.bindingNavigator4.BindingSource = this.indivisualDeliverBindingSource;
            this.bindingNavigator4.CountItem = null;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton43,
            this.toolStripSeparator41,
            this.toolStripButton49,
            this.toolStripSeparator47,
            this.toolStripButton50,
            this.toolStripButton51,
            this.toolStripSeparator44});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator4.MoveFirstItem = null;
            this.bindingNavigator4.MoveLastItem = null;
            this.bindingNavigator4.MoveNextItem = null;
            this.bindingNavigator4.MovePreviousItem = null;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = null;
            this.bindingNavigator4.Size = new System.Drawing.Size(833, 40);
            this.bindingNavigator4.TabIndex = 58;
            this.bindingNavigator4.Text = "bindingNavigator4";
            this.bindingNavigator4.Visible = false;
            this.bindingNavigator4.Click += new System.EventHandler(this.back_tap1_Click);
            // 
            // toolStripButton43
            // 
            this.toolStripButton43.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton43.Image")));
            this.toolStripButton43.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton43.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripButton43.Name = "toolStripButton43";
            this.toolStripButton43.RightToLeftAutoMirrorImage = true;
            this.toolStripButton43.Size = new System.Drawing.Size(66, 37);
            this.toolStripButton43.Tag = "الرئيسية";
            this.toolStripButton43.Text = "الرئيسية";
            this.toolStripButton43.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripSeparator41
            // 
            this.toolStripSeparator41.Name = "toolStripSeparator41";
            this.toolStripSeparator41.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton49
            // 
            this.toolStripButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton49.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton49.Image")));
            this.toolStripButton49.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton49.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton49.Name = "toolStripButton49";
            this.toolStripButton49.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton49.Tag = "المسلمات";
            this.toolStripButton49.Text = "المسلمات";
            this.toolStripButton49.Visible = false;
            this.toolStripButton49.Click += new System.EventHandler(this.toolStripButton49_Click);
            // 
            // toolStripSeparator47
            // 
            this.toolStripSeparator47.Name = "toolStripSeparator47";
            this.toolStripSeparator47.Size = new System.Drawing.Size(6, 40);
            this.toolStripSeparator47.Visible = false;
            // 
            // toolStripButton50
            // 
            this.toolStripButton50.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton50.Image")));
            this.toolStripButton50.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton50.Name = "toolStripButton50";
            this.toolStripButton50.Size = new System.Drawing.Size(132, 37);
            this.toolStripButton50.Text = "نسخ احتياطي للبيانات";
            this.toolStripButton50.Click += new System.EventHandler(this.toolStripButton50_Click);
            // 
            // toolStripButton51
            // 
            this.toolStripButton51.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton51.Image")));
            this.toolStripButton51.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton51.Name = "toolStripButton51";
            this.toolStripButton51.Size = new System.Drawing.Size(197, 37);
            this.toolStripButton51.Text = "إستعادة البيانات من نسخة احتياطية";
            this.toolStripButton51.Click += new System.EventHandler(this.toolStripButton51_Click);
            // 
            // toolStripSeparator44
            // 
            this.toolStripSeparator44.Name = "toolStripSeparator44";
            this.toolStripSeparator44.Size = new System.Drawing.Size(6, 40);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.log.Location = new System.Drawing.Point(40, 260);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(292, 48);
            this.log.TabIndex = 17;
            this.log.Text = "تسجيل الدخول";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.Color.Bisque;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sname.Location = new System.Drawing.Point(41, 165);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(202, 33);
            this.sname.TabIndex = 18;
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spass
            // 
            this.spass.BackColor = System.Drawing.Color.Bisque;
            this.spass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.spass.Location = new System.Drawing.Point(43, 208);
            this.spass.Multiline = true;
            this.spass.Name = "spass";
            this.spass.PasswordChar = '*';
            this.spass.Size = new System.Drawing.Size(202, 35);
            this.spass.TabIndex = 19;
            this.spass.Tag = "";
            this.spass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name.Location = new System.Drawing.Point(247, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(97, 30);
            this.name.TabIndex = 20;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password.Location = new System.Drawing.Point(253, 210);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(79, 30);
            this.password.TabIndex = 21;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Silver;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.back.ForeColor = System.Drawing.Color.DarkRed;
            this.back.Location = new System.Drawing.Point(15, 73);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 43);
            this.back.TabIndex = 23;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(44, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "السجل الاجل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(59, 311);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(12, 26);
            this.connect.TabIndex = 17;
            this.connect.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 20;
            // 
            // msgdisconnect
            // 
            this.msgdisconnect.AutoSize = true;
            this.msgdisconnect.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgdisconnect.LinkColor = System.Drawing.Color.DarkRed;
            this.msgdisconnect.Location = new System.Drawing.Point(69, 280);
            this.msgdisconnect.Name = "msgdisconnect";
            this.msgdisconnect.Size = new System.Drawing.Size(0, 26);
            this.msgdisconnect.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(356, 100);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(55, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 30);
            this.label2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::shoping.Properties.Resources.براج_الجزائر;
            this.pictureBox2.Location = new System.Drawing.Point(43, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.SeaGreen;
            this.query.Font = new System.Drawing.Font("Sitka Small", 18F);
            this.query.ForeColor = System.Drawing.Color.White;
            this.query.Location = new System.Drawing.Point(43, 141);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(320, 55);
            this.query.TabIndex = 24;
            this.query.Text = "الإستعلام";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // panel_main
            // 
            this.panel_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_main.Location = new System.Drawing.Point(-3, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(409, 602);
            this.panel_main.TabIndex = 21;
            this.panel_main.Visible = false;
            this.panel_main.TabIndexChanged += new System.EventHandler(this.panel_main_Paint);
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint_1);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.Brown;
            this.sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sales.ForeColor = System.Drawing.Color.White;
            this.sales.Location = new System.Drawing.Point(32, 84);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(327, 53);
            this.sales.TabIndex = 10;
            this.sales.Text = "إنشاء حساب جديد";
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // stores
            // 
            this.stores.BackColor = System.Drawing.Color.SeaGreen;
            this.stores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stores.ForeColor = System.Drawing.Color.White;
            this.stores.Location = new System.Drawing.Point(32, 157);
            this.stores.Name = "stores";
            this.stores.Size = new System.Drawing.Size(327, 53);
            this.stores.TabIndex = 11;
            this.stores.Text = "سجلات الدين";
            this.stores.UseVisualStyleBackColor = false;
            this.stores.Click += new System.EventHandler(this.stores_Click);
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.Teal;
            this.products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.products.ForeColor = System.Drawing.Color.White;
            this.products.Location = new System.Drawing.Point(32, 231);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(327, 53);
            this.products.TabIndex = 12;
            this.products.Text = "سجلات المسلمات";
            this.products.UseVisualStyleBackColor = false;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // sale_monitor
            // 
            this.sale_monitor.BackColor = System.Drawing.Color.Olive;
            this.sale_monitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale_monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sale_monitor.ForeColor = System.Drawing.Color.White;
            this.sale_monitor.Location = new System.Drawing.Point(30, 382);
            this.sale_monitor.Name = "sale_monitor";
            this.sale_monitor.Size = new System.Drawing.Size(327, 53);
            this.sale_monitor.TabIndex = 13;
            this.sale_monitor.Text = "Sale Monitor";
            this.sale_monitor.UseVisualStyleBackColor = false;
            // 
            // store_monitor
            // 
            this.store_monitor.BackColor = System.Drawing.Color.ForestGreen;
            this.store_monitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store_monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.store_monitor.ForeColor = System.Drawing.Color.White;
            this.store_monitor.Location = new System.Drawing.Point(31, 306);
            this.store_monitor.Name = "store_monitor";
            this.store_monitor.Size = new System.Drawing.Size(327, 53);
            this.store_monitor.TabIndex = 14;
            this.store_monitor.Text = "السجلات بشكل فردي";
            this.store_monitor.UseVisualStyleBackColor = false;
            this.store_monitor.Click += new System.EventHandler(this.store_monitor_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(22, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // customerTableAdapter3
            // 
            this.customerTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager3.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager3.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager3.deliveriesTableAdapter = null;
            this.tableAdapterManager3.employeeTableAdapter = null;
            this.tableAdapterManager3.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager3.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager3.invoiceTableAdapter = null;
            this.tableAdapterManager3.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // advanceDataSet2
            // 
            this.advanceDataSet2.DataSetName = "advanceDataSet";
            this.advanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "employee";
            this.employeeBindingSource2.DataSource = this.advanceDataSet;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager4.customerTableAdapter = null;
            this.tableAdapterManager4.DeliveriesSelectProcTableAdapter = null;
            this.tableAdapterManager4.deliveriesTableAdapter = null;
            this.tableAdapterManager4.employeeTableAdapter = this.employeeTableAdapter1;
            this.tableAdapterManager4.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager4.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager4.invoiceTableAdapter = null;
            this.tableAdapterManager4.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager4.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.customer_DataTableTableAdapter1TableAdapter = null;
            this.tableAdapterManager5.customerTableAdapter = null;
            this.tableAdapterManager5.DeliveriesSelectProcTableAdapter = this.deliveriesSelectProcTableAdapter;
            this.tableAdapterManager5.deliveriesTableAdapter = null;
            this.tableAdapterManager5.employeeTableAdapter = null;
            this.tableAdapterManager5.IndivisualDeliverTableAdapter = null;
            this.tableAdapterManager5.Invo_Indiv_Select_topProcTableAdapter = null;
            this.tableAdapterManager5.invoiceTableAdapter = null;
            this.tableAdapterManager5.proc_select_invoiceTableAdapter = null;
            this.tableAdapterManager5.UpdateOrder = shoping.advanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vw_customerTableAdapter
            // 
            this.vw_customerTableAdapter.ClearBeforeFill = true;
            // 
            // customer_DataTableTableAdapter
            // 
            this.customer_DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator42
            // 
            this.toolStripSeparator42.Name = "toolStripSeparator42";
            this.toolStripSeparator42.Size = new System.Drawing.Size(6, 41);
            // 
            // customer_DataTableTableAdapter1TableAdapter
            // 
            this.customer_DataTableTableAdapter1TableAdapter.ClearBeforeFill = true;
            // 
            // home
            // 
            this.AcceptButton = this.log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(968, 698);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::shoping.Properties.Settings.Default, "h", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = global::shoping.Properties.Settings.Default.h;
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "";
            this.Text = "  محلات الحســـــــين التجاريــــــــة>> الرئيســية  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indivisualDeliverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proc_select_invoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proc_select_invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tab3_hid.ResumeLayout(false);
            this.tab3_hid.PerformLayout();
            this.indevisiual_deliv_panel.ResumeLayout(false);
            this.indevisiual_deliv_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableTableAdapter1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indivisualDeliverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingNavigator)).EndInit();
            this.deliveriesSelectProcBindingNavigator.ResumeLayout(false);
            this.deliveriesSelectProcBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.panal_home.ResumeLayout(false);
            this.panal_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }
        private ImageList imageList1;
        private IContainer components;



        private void log_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {

               cmd = new SqlCommand(@"select * from employee 
                 where emp_name='" + textBox2.Text + "' and emp_password='" + textBox1.Text + "'", con);
                try
                {
                    dr =cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        if ( dr["emp_password"].ToString() == textBox1.Text)
                        {
                           
                            emp_session =dr["emp_name"].ToString();

                            this.StartPosition = FormStartPosition.CenterScreen;
                            panel_login.Visible = false;
                            panal_home.Visible = true;
                            panel2.Visible = false;
                            authntication = true;
                            accounts.Visible = true;
                            invoices.Visible = true;
                            deliveries.Visible = true;
                            space1.Visible = true;
                            space2.Visible = true;
                            space3.Visible = true;
                            bindingNavigator4.Visible = true;
                            //refresh.Visible = true;
                            label16.Visible = false;
           panel1.Visible = false;
            panel3.Visible = false;

       

                            needadd = false;
                            tab3_hid.Visible = false;
                            indevisiual_deliv_panel.Visible = true;
                            groupBox1.Visible = true;
                            //  hide.Visible = false;//يعرض لوحة كل سجلات المسلمات حسب التاريخ
                            tabControl1.Width = 974;
                            this.Width = 984;
                            this.Height = 734;
                            tabControl1.Height = 700;
                            fillToolStripButton_Click_1(sender, e);
                            
                        }
                        dr.Close();

                    }
                    //else if (dr["store_name"] == sname.Text && dr["password"] != spass.Text)
                    //{
                    //    msg.Text = " invalid password ";
                    //}
                    else
                    {
                        msg.Text = " خطا في البيانات تأكد منها ";
                        textBox2.Text = "";
                        textBox1.Text = "";
                        textBox2.Focus();
                        dr.Close();

                    }
                }
                catch
                {
                    msg.Text = "خطاء في الأتصال بقاعدة البيانات";
                    textBox2.Focus();
                }


            }
            else if (sname.Text == "" && spass.Text == "")
            {
                msg.Text = " الرجاء إدخل اسم المستخدم وكلمة المروور";
                textBox2.Focus();
            }
            else if (sname.Text == "")
            {

                msg.Text = "اسم المستخدم ضرورية";
                textBox2.Focus();
            }
            else if (spass.Text == "")
            {
                msg.Text = "ادخل كلمة المرور";
                textBox2.Focus();
            }
        
        }

        private void back_Click(object sender, EventArgs e)
        {
            toolStripButton15.BackColor = Color.White;
            panel_login.Visible = false;
            panel_main.Visible = false;
            panal_home.Visible = true;
            home_nav.BackColor = Color.FromArgb(224, 224, 224);
        }

  


   
        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }





        private void tabPage1_Click(object sender, EventArgs e)
        {
            name.Focus();
     

            try
            {
             
                // TODO: This line of code loads data into the 'advanceDataSet.customer' table. You can move, or remove it, as needed.
              //  this.customerTableAdapter.Fill(this.advanceDataSet.customer);
                // TODO: This line of code loads data into the 'advanceDataSet.DeliveriesSelectProc' table. You can move, or remove it, as needed.
                this.deliveriesSelectProcTableAdapter.Fill(this.advanceDataSet.DeliveriesSelectProc);

                //this.refresh.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);



                //name.Text = "حدد الحساب";
                //lastmony.Text = "الحساب المتبقي";
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





  


        private void store_monitor_Click_1(object sender, EventArgs e)
        {
            home_Load(sender, e);
            tab3_hid.Visible = false;
            indevisiual_deliv_panel.Visible = true;//show المسلمات لكل حساب على حده
          //  hide.Visible = false;
           
            //search.Visible =true;
            tabControl1.SelectTab(2);
            tabControl1.Width = 920;
            this.Width = 908;
            this.Height = 679;
            tabControl1.Height = 700;
         
            //deliveries deliv = new deliveries();
            //deliv.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
            try
            {
             
                needadd = true;
                mony.Focus();
                emp_name.Text =emp_session;
                comboBox1.SelectedValue= custom_name1;
                lastmony.Text = last_mony.ToString();
                comboBox1_MouseHover(sender, e);
            }
            catch (global::System.Exception ex){ 
                MessageBox.Show(ex.Message);
                
            }
        }

        private void deliveriesSelectProcBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    this.Validate();
                    this.deliveriesSelectProcBindingSource.EndEdit();
                    this.tableAdapterManager5.UpdateAll(this.advanceDataSet);
                //    home_Load(sender,e);
                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
                    home_Load(sender, e);
                    if (msgdb != "")
                    {
                        MessageBox.Show(msgdb);
                        msgdb = "";
                    }
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            needadd = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            deliveriesSelectProcBindingNavigatorSaveItem_Click(sender,e);
        }

        private void deliveriesSelectProcBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panel_deliveries_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

            home_Load(sender,e);
        }

        private void panel_deliveries_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void deliveriesSelectProcDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 

  
        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }


   


        bool needadd = false;
        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
               try
                {
                    if (custom_nameTextBox.Text != "")
                    {
                      custom_name = custom_nameTextBox.Text;
                    }
                    cmd = new SqlCommand(@"select * from customer  
                 where custom_name='" + custom_name + "'", con);
                    if (con.State.ToString() != "Open")
                    {
                        con.Open();
                    }
                    if (dr != null)
                    {
                        dr.Close();
                    }

                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                            last_account1= Convert.ToDecimal(dr["end_total"]);
                        
                        dr.Close();
                        con.Close();
                    }

            if (!needadd)
               {
                   if (radioButton1.Checked == true)
                       combo_part.Text = radioButton1.Text;
                   else if (radioButton2.Checked == true)
                       combo_part.Text = radioButton2.Text;
                   else if (radioButton3.Checked == true)
                       combo_part.Text = radioButton3.Text;
                   else if (radioButton4.Checked == true)
                       combo_part.Text = radioButton4.Text;
                   else if (radioButton5.Checked == true)
                       combo_part.Text = radioButton5.Text;
                   else if (radioButton6.Checked == true)
                       combo_part.Text = radioButton6.Text;
                   else if (radioButton7.Checked == true)
                       combo_part.Text = radioButton7.Text;
                   else if (radioButton8.Checked == true)
                       combo_part.Text = radioButton8.Text;
                   else if (radioButton9.Checked == true)
                       combo_part.Text = radioButton9.Text;
                   else if (radioButton10.Checked == true)
                       combo_part.Text = radioButton10.Text;
                   else if (radioButton11.Checked == true)
                       combo_part.Text = radioButton11.Text;

                this.indivisualDeliverTableAdapter.Fill(this.advanceDataSet.IndivisualDeliver,custom_name,
                  new System.Nullable<int>(((int)(System.Convert.ChangeType(combo_num.Text, typeof(int))))),
                    new System.Nullable<int>(((int)(System.Convert.ChangeType(combo_part.Text, typeof(int))))));   
                }
            else {
                if (custom_nameTextBox.Text==null)
                  this.custom_nameTextBox.Text = custom_name;

                    toolStripButton16.Text = "طباعة جدول المسلمات ل / " + custom_name;
                    emp_nameTextBox.Text = home.emp_session;
                    last_accountTextBox.Text = last_account1.ToString();

                     }
           // this.customerTableAdapter.Fill(this.advanceDataSet1.customer);
          //  home_Load(sender,e);
                }
               catch (global::System.Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
        }

        private void indivisualDeliverDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custom_nameToolStripTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indevisiual_deliv_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

        }

        private void delivery_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastmony_TextChanged(object sender, EventArgs e)
        {



        }

        private void hide3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hide3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }



        private void panel1_Paint_4(object sender, PaintEventArgs e)
        {

        }

        private void last_accountLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tab3_hid_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            indevisiual_deliv_panel.Visible = false;
            tabControl1.SelectTab(2);
            //  hide.Visible = false;//يعرض لوحة كل سجلات المسلمات حسب التاريخ
            tabControl1.Width = 920;
            this.Width = 930;
            this.Height = 700;
            tabControl1.Height = 700;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tab3_hid.Visible = false;
            indevisiual_deliv_panel.Visible = true;//show المسلمات لكل حساب على حده
            //  hide.Visible = false;

            //search.Visible =true;
            tabControl1.SelectTab(2);
            tabControl1.Width = 920;
            this.Width = 930;
            this.Height = 700;
            tabControl1.Height = 700;
        }





        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.indivisualDeliverBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.advanceDataSet);
                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
                    home_Load(sender, e);
                    if (msgdb != "")
                    {
                        MessageBox.Show(msgdb);
                        msgdb = "";
                    }
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void query_Click(object sender, EventArgs e)
        {

            SqlConnect();
            if (con.State.ToString() == "Open")
            {
                query log = new query();
                log.Show();
                this.Hide();
         
               
       
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            SqlConnect();
            if (con.State.ToString() == "Open")
            {
                panel_login.Visible = true;
                panal_home.Visible = false;
                panel2.Visible = false;
                textBox2.Focus();
                toolStripButton15.BackColor = Color.FromArgb(224, 224, 224);
                home_nav.BackColor = Color.White;
                toolStripButton15.Visible=false;
            }
        }

   
        private void button2_Click_3(object sender, EventArgs e)
        {
            panal_home.Visible = false;
            panel_login.Visible = false;
            panel2.Visible = true;
        }

        private void sales_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = false;
            panel3.Visible = false;
            tabControl1.SelectTab(1);

            tabControl1.Width = 974;
            this.Width = 984;
            this.Height = 734;
            tabControl1.Height = 700;
         
            //tabControl1.Width = 920;
            //this.Width = 930;
            //this.Height = 700;

            //tabControl1.Height = 700;
        
    
        }

        private void stores_Click(object sender, EventArgs e)
        {
          
            indiv_invoices indinv = new indiv_invoices();
            indinv.Show();
            this.Hide();
            //vw_invoice v = new vw_invoice();
            //v.Show();
          
         
   
        }

        private void products_Click(object sender, EventArgs e)
        {
          //  home_Load(sender, e);
         
         //   Application.OpenForms["deliveries"].Show();
            //deliveries deliv = new deliveries();
            //deliv.Show();
            //this.Hide();
            needadd = false;
            tab3_hid.Visible = false;
            indevisiual_deliv_panel.Visible = true;
            tabControl1.SelectTab(2);
            groupBox1.Visible = true;
            //  hide.Visible = false;//يعرض لوحة كل سجلات المسلمات حسب التاريخ
            tabControl1.Width = 974;
                            this.Width = 984;
                            this.Height = 734;
                            tabControl1.Height = 700;
            //tabControl1.Width = 920;
            //this.Width = 930;
            //this.Height = 700;
            //tabControl1.Height = 700;
            fillToolStripButton_Click_1(sender, e);
        }

        private void store_monitor_Click(object sender, EventArgs e)
        {
            //home_Load(sender, e);
            needadd = false;
            tab3_hid.Visible = false;
            indevisiual_deliv_panel.Visible = false;//show المسلمات لكل حساب على حده
            //  hide.Visible = false;

            //search.Visible =true;
            tabControl1.SelectTab(2);
            tabControl1.Width = 974;
            this.Width = 984;
            this.Height = 734;
            tabControl1.Height = 700;
            //tabControl1.Width = 920;
            //this.Width = 908;
            //this.Height = 679;
            //tabControl1.Height = 700;
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            this.Width = 416;
            this.Height=679;
        }

        private void panel_main_Paint_1(object sender, PaintEventArgs e)
        {
            tabControl1.Width = 409;
            tabControl1.Height=655;
            this.Width = 416;
            this.Height = 679;
        }

        private void panel_main_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void server_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = null;
            con = new SqlConnection(@"Data Source='" + server_name.SelectedText + "';Initial Catalog=advance;Integrated Security=True");
           
        }

        private void server_name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con = null;
            con = new SqlConnection(@"Data Source='" + server_name.Text + "';Initial Catalog=advance;Integrated Security=True");
            con_server = server_name.Text;
        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.indivisualDeliverBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.advanceDataSet);
                    home_Load(sender, e);
                    needadd = false;
                    fillToolStripButton_Click_1(sender, e);

           
                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
                    if (msgdb != "")
                    {
                        MessageBox.Show(msgdb);
                        msgdb = "";
                    }


                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void custom_nameTextBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            needadd = true;

            try
            {
                emp_name.Text = emp_session;
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            delivered_moneyTextBox.Focus();
            try
            {

            
                needadd = true;
                emp_nameTextBox.Text = emp_session;
                custom_nameTextBox.Text = custom_name;
                custom_nameTextBox.SelectedValue = custom_name;
                last_accountTextBox.Text = last_account1.ToString();
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            needadd = false;
            fillToolStripButton_Click_1(sender,e);
        }

        private void indevisiual_deliv_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void back_tap1_Click(object sender, EventArgs e)
        {
          //  home_Load(sender, e);
            tabControl1.SelectTab(0);
            //  hide.Visible = false;//يعرض لوحة كل سجلات المسلمات حسب التاريخs
          
            //tabControl1.Width = 723;
            //tabControl1.Height = 851;
            //this.Width = 734;
            //this.Height = 857;
            back_Click(sender, e);

        }

        private void toolStripSeparator17_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void panal_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void restore_connect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tab3_hid_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (custom_nameTextBox.Text != null)
            //custom_name = custom_nameTextBox.Text;
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.Text != null)
                {
                    custom_name1 = comboBox1.Text;
                }
                cmd = new SqlCommand(@"select * from customer  
                 where custom_name='" + custom_name1 + "'", con);
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                if (dr != null)
                {
                    dr.Close();
                }

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                   

                        last_mony = Convert.ToDecimal(dr["end_total"].ToString());
                    
                    dr.Close();
                    con.Close();
                }
                if (needadd)
                {
                    mony.Focus();
                    if (comboBox1.Text==null)
                  //  comboBox1.Text = custom_name1;

                    emp_name.Text = home.emp_session;
                    lastmony.Text = last_mony.ToString();

                }
                else
                {

                }

            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text != null)
            //custom_name1 = comboBox1.Text;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            deliveries deliv = new deliveries();
            deliv.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            reporting report = new reporting();

            this.indivisualDeliverTableAdapter.Fill(report.advanceDataSet.IndivisualDeliver, custom_name,
              new System.Nullable<int>(((int)(System.Convert.ChangeType(combo_num.Text, typeof(int))))),
                new System.Nullable<int>(((int)(System.Convert.ChangeType(combo_part.Text, typeof(int))))));   
            report.reportViewer2.RefreshReport();
            report.reportViewer2.Visible = true;
            report.Show();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            indiv_invoices invo = new indiv_invoices();
            invo.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            reporting report = new reporting();

            this.deliveriesSelectProcTableAdapter.Fill(report.advanceDataSet.DeliveriesSelectProc);
            report.reportViewer3.RefreshReport();
            report.reportViewer3.Visible = true;
            report.Show();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.customerBindingSource.EndEdit();
                    this.tableAdapterManager3.UpdateAll(this.advanceDataSet);

                    home_Load(sender,e);

                    //this.customerTableAdapter.Fill(this.advanceDataSet.customer);
                    //this.customer_DataTableTableAdapter.Fill(this.advanceDataSet.customer_DataTable);
                    //this.vw_customerTableAdapter.Fill(this.advanceDataSet.vw_customer);
              
                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
    
                    //if (msgdb != "")
                    //{
                    //    MessageBox.Show(msgdb);
                    //    msgdb = "";
                    //}
                  
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show("إسم الحساب موجود مسبقا/n لايمكن اضافة اكثر من حساب واحد بنفس الإسم"+ex.Message,"تعذر الإضافة",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            home_Load(sender,e);
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
            try
            {

            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit1Label_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton36_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.employeeBindingSource1.EndEdit();
                    this.tableAdapterManager4.UpdateAll(this.advanceDataSet);

                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
                    home_Load(sender, e);
                    //if (msgdb != "")
                    //{
                    //    MessageBox.Show(msgdb);
                    //    msgdb = "";
                    //}
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            emp_nameTextBox1.Focus();
        }

        private void toolStripButton41_Click(object sender, EventArgs e)
        {
          //  home_Load(sender,e);
            panel1.Visible = false;
            panel3.Visible = true;
            tabControl1.SelectTab(1);
            tabControl1.Width = 920;
            this.Width = 930;
            this.Height = 700;
            tabControl1.Height = 700;
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton50_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                // save.Filter = "Buckup Files (*.Bak) |*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {

                    cmd = new SqlCommand("Backup Database advance To Disk='" + save.FileName
                     + " تاريخ انشاء النسخة -" + DateTime.Now.Year + " - " + DateTime.Now.Month + " - " + DateTime.Now.Day
                     + " الساعة " + DateTime.Now.Minute + "-" + DateTime.Now.Hour + ".bak" + "'", con);

                    if (con.State.ToString() != "Open")
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم إنشاء النسخة الإحتياطية بنجاح", "نسخ  احتياطي للسجلات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show("لم تتم عملية النسخ الاحتياطي \n" + ex.Message, "خطاء في النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void toolStripButton51_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog res = new OpenFileDialog();
                res.Filter = "Buckup Files (*.Bak) |*.bak";
                if (res.ShowDialog() == DialogResult.OK)
                {
                    conms = new SqlConnection(@"Data Source='" + server_name.Text + "';Initial Catalog=master;Integrated Security=True");
                    cmd = new SqlCommand("restore_database", conms);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter("@file_name", SqlDbType.NVarChar, 250);
                    param.Value = res.FileName;

                    cmd.Parameters.Add(param);

                    if (conms.State.ToString() != "Open")
                    {
                        conms.Open();
                    }
                    int result = cmd.ExecuteNonQuery();
                    conms.Close();


                    MessageBox.Show(" تم استعادة النسخة الإحتياطية بنجاح \n        <إسم النسخةـــ" + res.FileName, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home_Load(sender, e);

                }
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(" لم تتم عملة استعادة قاعدة البيانات \n" + ex.Message, " خطاء في الإستعادة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //       private void toolStripButton50_Click(object sender, EventArgs e)
        //       {
        //           try
        //           {
        //               SaveFileDialog save = new SaveFileDialog();
        //               save.Filter = "Buckup Files (*.Bak) |*.bak";
        //               if (save.ShowDialog() == DialogResult.OK)
        //               {
        //                   cmd = new SqlCommand("Backup Database advance To Disk='" +save.FileName+ "'", con);
        //                   if (con.State.ToString() != "Open")
        //                   {
        //                       con.Open();
        //                   }
        //                   cmd.ExecuteNonQuery();
        //                   con.Close();
        //                   MessageBox.Show("تم إنشاء النسخة الإحتياطية بنجاح", "نسخ  احتياطي للسجلات", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //               }
        //           }
        //           catch (global::System.Exception ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }
        //       }


        //       private void toolStripButton51_Click(object sender, EventArgs e)
        //       {
        //           try
        //           {

        //               OpenFileDialog res = new OpenFileDialog();
        //               res.Filter = "Buckup Files (*.Bak) |*.bak"; 
        //               if (res.ShowDialog() == DialogResult.OK)
        //               {
        //              conms = new SqlConnection(@"Data Source='" + server_name.Text + "';Initial Catalog=master;Integrated Security=True");
        //                cmd   = new SqlCommand("restore_database", conms);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //              SqlParameter  param = new SqlParameter();
        //                 param = new SqlParameter("@file_name",SqlDbType.NVarChar,250);
        //                   param.Value = res.FileName;
        //                   cmd.Parameters.Add(param);

        //                   if (conms.State.ToString() != "Open")
        //                   {
        //                       conms.Open();
        //                   }
        //                   cmd.ExecuteNonQuery();
        //                   conms.Close();
        //                   home_Load(sender,e);
        //                   MessageBox.Show("تم استعادة النسخة الإحتياطية بنجاح","إستعادة",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //} 
        //           }
        //           catch (global::System.Exception ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }
        //       }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton49_Click(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    if (needclose)
            //    {
            //        Application.OpenForms["home"].Close();
            //        Application.OpenForms["vw_invoice"].Close();
            //        Application.OpenForms["query"].Close();
            //        Application.OpenForms["customer"].Close();
            //        Application.OpenForms["deliveries"].Close();
            //        Application.OpenForms["indiv_invoices"].Close();
            //    }
            //}
            //catch (global::System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void tab3_hid_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void btn_MouseHover(object sender, EventArgs e)
        { 
            
        }
    }
}
