using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoping
{
    public partial class customer : Form
    {
        private static bool needclose = true;
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
          
          
      this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            // TODO: This line of code loads data into the 'advanceDataSet.proc_select_invoice' table. You can move, or remove it, as needed.
        

        }

        private void end_totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custom_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.customerBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.advanceDataSet);

                    //this.deliveriesSelectProcDataGridView.DataSource = deliveriesSelectProcTableAdapter.GetData();
                    customer_Load(sender, e);
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.advanceDataSet.customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy1(this.advanceDataSet.customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    

//        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
//        {
//             if (male.Checked == true)
//            {
//                genderTextBox.Text = "";
//               genderTextBox.Text ='m'.ToString();
//            }
//             else if (femal.Checked == true)
//             {
//                 genderTextBox.Text = "";
//                 genderTextBox.Text = 'f'.ToString();
//             }
//        }

//        private void femal_CheckedChanged_1(object sender, EventArgs e)
//        {
//            if (femal.Checked == true)
//            {
//                genderTextBox.Text = 'f'.ToString();
//            }
//            else if (male.Checked == true)
//            {
//                genderTextBox.Text = 'm'.ToString();
//;
//            }
//        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

            //if (genderTextBox.Text == "m")
            //{
            //    male.Checked = true; 
            //}
            //else if (genderTextBox.Text == "f")
            //{
            //    femal.Checked = true; 
            //}
        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void creditTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer_Load(sender,e);
        }

        private void back_Click(object sender, EventArgs e)
        {
           
            Application.OpenForms["home"].Show();
            needclose = false;
            this.Hide();

        }

        private void custom_nameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            indiv_invoices indiv = new indiv_invoices();
            indiv.Show();
            Close();
        }

        private void invoices_Click(object sender, EventArgs e)
        {
            indiv_invoices invo = new indiv_invoices();
            invo.Show();
            needclose = false;
            this.Hide();
        }

        private void deliveries_Click(object sender, EventArgs e)
        {
            deliveries deliv = new deliveries();
            deliv.Show();

            needclose = false;
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void customer_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
