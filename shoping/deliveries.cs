using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shoping
{
    public partial class deliveries : Form
    {
        home db = new home();
       private static string custom_name;
       private decimal last_account;
       private bool needadd ;
       private bool needclose = true;
        //private string custom_name;

        //SqlDataAdapter da;
        DataTable dt=new DataTable();
        //CurrencyManager cm;
        public deliveries()
        {
            InitializeComponent();
            //cm = (CurrencyManager)this.deliveriesSelectProcBindingSource[0];

        }

        private void deliveries_Load(object sender, EventArgs e)
        {
            needadd = false;
            this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            custom_nameTextBox.Text = custom_name;
            custom_nameTextBox_MouseHover(sender, e);
        }



        private void delivered_moneyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deliveriesSelectProcBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void deliveriesSelectProcDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emp_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delivery_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliveries_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void tab3_hid_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void products_Click(object sender, EventArgs e)
        {

        }

        private void back_tap1_Click(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lastmony_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void store_monitor_Click(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_MouseHover(object sender, EventArgs e)
        {
            try
            {
                if (custom_nameTextBox.Text != "")
                {
                    custom_name = custom_nameTextBox.Text;
                }
                    db.cmd = new SqlCommand(@"select * from customer  
                 where custom_name='" + custom_name + "'", db.con);
                    if (db.con.State.ToString() != "Open")
                    {
                        db.con.Open();
                    }
                    if (db.dr != null)
                    {
                        db.dr.Close();
                    }

                    db.dr = db.cmd.ExecuteReader();
                    if (db.dr.Read())
                    {
                        if (db.dr["custom_name"].ToString() == custom_name)
                        {
                            last_account = Convert.ToDecimal(db.dr["end_total"]);
                        }
                        db.dr.Close();
                        db.con.Close();
                    }

                    if (needadd == false)
                    {
                        if (custom_name != "" && custom_name != "حدد اسم المستخدم")
                        {

                            toolStripButton6.Text = "طباعة المسلمات ل / " + custom_name;
                        headerlable.Text = "مسلمات حساب /" + custom_name + " المتبقي عنده = " + last_account + "  ريال يمني ";
                        this.toolStripButton1.Text = "استعراض مسلمات -  " + custom_name;
                        this.Text = "مسلمات حساب " + custom_name;
                        if (radioButton1.Checked == true)
                            partToolStripTextBox.Text = radioButton1.Text;
                        else if (radioButton2.Checked == true)
                            partToolStripTextBox.Text = radioButton2.Text;
                        else if (radioButton3.Checked == true)
                            partToolStripTextBox.Text = radioButton3.Text;
                        else if (radioButton4.Checked == true)
                            partToolStripTextBox.Text = radioButton4.Text;
                        else if (radioButton5.Checked == true)
                            partToolStripTextBox.Text = radioButton5.Text;
                        else if (radioButton6.Checked == true)
                            partToolStripTextBox.Text = radioButton6.Text;
                        else if (radioButton7.Checked == true)
                            partToolStripTextBox.Text = radioButton7.Text;
                        else if (radioButton8.Checked == true)
                            partToolStripTextBox.Text = radioButton8.Text;
                        else if (radioButton9.Checked == true)
                            partToolStripTextBox.Text = radioButton9.Text;
                        else if (radioButton10.Checked == true)
                            partToolStripTextBox.Text = radioButton10.Text;
                        else if (radioButton11.Checked == true)
                            partToolStripTextBox.Text = radioButton11.Text;

                        this.indivisualDeliverTableAdapter.Fill(this.advanceDataSet.IndivisualDeliver, custom_name
        ,
                            new System.Nullable<int>(((int)(System.Convert.ChangeType(topToolStripTextBox.Text, typeof(int))))),
                            new System.Nullable<int>(((int)(System.Convert.ChangeType(partToolStripTextBox.Text, typeof(int))))));
                        //invo_Indiv_Select_topProcDataGridView.DataSource = ;
                    }

                    }
                    else
                    {

                        custom_nameTextBox.Text = custom_name;
                        emp_nameTextBox.Text = home.emp_session.ToString();
                        last_accountTextBox.Text = last_account.ToString();
                          headerlable.Text = " إضافة تسليم بإسم حساب- " + custom_name + "  المتبقيات السابقة  = " + last_account + "  ريال يمني ";
                
                    }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void deliver_init(){

           
        }
        private void invo_Indiv_Select_topProcBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.indivisualDeliverBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.advanceDataSet);

                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            deliveries_Load(sender,e);
         //   toolStripButton1_Click(sender,e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            needadd = false;
            custom_nameTextBox_MouseHover(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
                needadd = true;
                priceTextBox.Focus();
                headerlable.Text = " إضافة تسليم بإسم حساب- " + custom_name + "  المتبقيات السابقة  = " + last_account + "  ريال يمني ";
                emp_nameTextBox.Text = home.emp_session;
                custom_nameTextBox.Text = custom_name;
        
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["home"].Show();
            needclose = false;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            deliveries_Load(sender,e);

          
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //customer custom = new customer();
            //custom.Show();
            //needclose = false;
            //this.Hide();
            home ho = new home();
            ho.tabControl1.SelectTab(1);
            ho.panel1.Visible = false;
            ho.panel3.Visible = false;
            ho.tab3_hid.Visible = false;
            ho.accounts.Visible = true;
            ho.deliveries.Visible = true;
            ho.invoices.Visible = true;
            ho.bindingNavigator4.Visible = true;
            ho.tabControl1.Width = 974;
            ho.Width = 984;
            ho.Height = 734;
            ho.tabControl1.Height = 700;
            needclose = false;

            ho.Show();
            this.Close();
        }

        private void custom_nameTextBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          //  custom_name = custom_nameTextBox.Text;
        }

        private void headerlable_Click(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {
           /* if (needadd == true)
            {
                custom_nameTextBox_MouseHover(sender, e);
           }*/
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            reporting report = new reporting();
            this.indivisualDeliverTableAdapter.Fill(report.advanceDataSet.IndivisualDeliver, custom_name,
                        new System.Nullable<int>(((int)(System.Convert.ChangeType(topToolStripTextBox.Text, typeof(int))))),
                        new System.Nullable<int>(((int)(System.Convert.ChangeType(partToolStripTextBox.Text, typeof(int))))));
            report.reportViewer2.RefreshReport();
            report.reportViewer2.Visible = true;
            report.Show();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            deliveries deliv = new deliveries();
            deliv.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void invoices_Click(object sender, EventArgs e)
        {
            indiv_invoices invo = new indiv_invoices();
            invo.Show();
            needclose = false;
            this.Close();
        }

        private void deliveries_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needclose)
            {
                Application.Exit();
                //Application.OpenForms["home"].Close();
                //Application.OpenForms["vw_invoice"].Close();
                //Application.OpenForms["query"].Close();
                //Application.OpenForms["customer"].Close();
                //Application.OpenForms["deliveries"].Close();
                //Application.OpenForms["indiv_invoices"].Close();
            }
        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

     

    }
}
