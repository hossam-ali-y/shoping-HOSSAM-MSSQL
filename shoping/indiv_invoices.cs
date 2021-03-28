using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shoping
{
    public partial class indiv_invoices : Form
    {
        private static string custom_name;
        private static bool needclose = true;
        public indiv_invoices()
        {
            InitializeComponent();
        }

        //private void invo_Indiv_Select_topProcBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.invo_Indiv_Select_topProcBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.advanceDataSet);

        //}
        private void invo_Indiv_Select_topProcBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.invo_Indiv_Select_topProcBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.advanceDataSet);
                    
                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            indiv_invoices_Load(sender, e);

        }
        private bool needadd = false;
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (needadd == false)
                {
                    custom_name = custom_nameTextBox.Text;
                    print_invoices.Text = "طباعة فواتير / " + custom_name;
                    this.toolStripButton1.Text = "استعراض فواتير  " + custom_name;
                    this.Text = "فواتير حساب " + custom_name;
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
               
                    this.invo_Indiv_Select_topProcTableAdapter.Fill(this.advanceDataSet.Invo_Indiv_Select_topProc, custom_nameTextBox.Text
    ,
                        new System.Nullable<int>(((int)(System.Convert.ChangeType(topToolStripTextBox.Text, typeof(int))))),
                        new System.Nullable<int>(((int)(System.Convert.ChangeType(partToolStripTextBox.Text, typeof(int))))));
                    //invo_Indiv_Select_topProcDataGridView.DataSource = ;
                    custom_nameTextBox.SelectedValue = custom_name;
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void indiv_invoices_Load(object sender, EventArgs e)
        {
            needadd = false;
            needclose = true;
         this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            custom_nameTextBox.Text = custom_name;
            fillToolStripButton_Click(sender, e);
        }

        private void custom_nameTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
            Application.OpenForms["home"].Show();
            needclose = false;
            this.Close();
        }

        private void topToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void partToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            priceTextBox.Focus();
            needadd = true;
            emp_nameTextBox.Text = home.emp_session;
            custom_nameTextBox.SelectedValue = custom_name;
           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
          
            home ho = new home();
            ho.tabControl1.SelectTab(1);
           ho.panel1.Visible = false;
           ho.panel3.Visible = false;
           ho.tab3_hid.Visible = false;
           ho.accounts.Visible = true;
           ho.deliveries.Visible = true;
           ho.invoices.Visible = true;
           ho.bindingNavigator4.Visible = true;
            ho.label16.Visible = false;
           ho.tabControl1.Width = 974;
           ho.Width = 984;
           ho.Height = 734;
           ho.tabControl1.Height = 700;
           needclose = false;
           


           ho.Show();
           this.Close();
          // Application.OpenForms["home"].Show(ho);
        }

        private void accounts_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            needadd = false;
            fillToolStripButton_Click(sender,e);
        }

        private void custom_nameTextBox_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

  

        private void toolStripButton12_Click(object sender, EventArgs e)
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
            indiv_invoices_Load(sender, e);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_delivery_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            deliveries deliv = new deliveries();
            deliv.Show();
            needclose = false;
            this.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
       
            
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            needadd = false;
   //         fillToolStripButton_Click_2(sender, e);
        }

        private void custom_nameToolStripTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void print_invoices_Click(object sender, EventArgs e)
        {
            reporting report = new reporting();
            this.invo_Indiv_Select_topProcTableAdapter.Fill(report.advanceDataSet.Invo_Indiv_Select_topProc, custom_nameTextBox.Text
,
                   new System.Nullable<int>(((int)(System.Convert.ChangeType(topToolStripTextBox.Text, typeof(int))))),
                   new System.Nullable<int>(((int)(System.Convert.ChangeType(partToolStripTextBox.Text, typeof(int))))));
            report.reportViewer1.RefreshReport();
            report.reportViewer1.Visible = true;
            report.Show();
        }

        private void buy_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void buy_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void noticesLabel_Click(object sender, EventArgs e)
        {

        }

        private void noticesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            //vw_invoice all = new vw_invoice();
            //all.Show();
            //needclose = false;
            //this.Hide();
        }

        private void indiv_invoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needclose)
            {
                    //Application.OpenForms["home"].Close();
                Application.Exit();
                    //Application.OpenForms["query"].Close();
                    //Application.OpenForms["customer"].Close();
                    //Application.OpenForms["deliveries"].Close();
                    //Application.OpenForms["indiv_invoices"].Close();
            }
        }

        private void invo_Indiv_Select_topProcBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

   
    }
}