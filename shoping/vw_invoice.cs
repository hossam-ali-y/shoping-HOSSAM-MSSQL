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
    public partial class vw_invoice : Form
    {
        public static string proc_state="";
        private static bool needclose;
        public vw_invoice()
        {
            
               
            InitializeComponent();
        }

        private void proc_select_invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

   DialogResult result=MessageBox.Show("هل تريد حفظ التغيرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
   if (result == DialogResult.Yes)
   {
       try
       {
           this.Validate();
           this.procselectinvoiceBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.advanceDataSet);
           if (proc_state != "")
           {
               MessageBox.Show(proc_state);
               proc_state = "";
           }
       }
       catch (global::System.Exception ex)
       {
           MessageBox.Show(ex.Message);
       }
   }
   vw_invoice_Load(sender, e);
        
        }
        
        private void vw_invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advanceDataSet.proc_select_invoice' table. You can move, or remove it, as needed.
         //   this.proc_select_invoiceTableAdapter.Fill1(this.advanceDataSet.proc_select_invoice);
            // TODO: This line of code loads data into the 'advanceDataSet.customer' table. You can move, or remove it, as needed.
            this.proc_select_invoiceTableAdapter.Fill1(this.advanceDataSet.proc_select_invoice);
            this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            needclose = true;
            // TODO: This line of code loads data into the 'advanceDataSet1.employee' table. You can move, or remove it, as needed.
       //     this.employeeTableAdapter.Fill(this.advanceDataSet1.employee);
            // TODO: This line of code loads data into the 'advanceDataSet1.customer' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'advanceDataSet.proc_select_invoice' table. You can move, or remove it, as needed.
          

        }

        private void emp_nameTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void noticesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void emp_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            emp_nameTextBox.Text = home.emp_session;
        }

        private void emp_nameTextBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void emp_nameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            vw_invoice_Load(sender, e);
        }

        private void back_Click(object sender, EventArgs e)
        {

            Application.OpenForms["home"].Show();
            needclose = false;
            this.Hide();

        }

        private void accounts_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
            this.Hide();
        }

        private void invoices_Click(object sender, EventArgs e)
        {
            invoice invo = new invoice();
            invo.Show();
            this.Hide();
        }

        private void deliveries_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();

        }

       

 


        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            //indiv_invo_panel.Visible = true;
         
            indiv_invoices indiv = new indiv_invoices();
      
            indiv.Show();
            needclose = false;
            this.Hide();
  
        }



        private void indiv_invo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            indiv_invo_panel.Visible = false;
        }

        private void indiv_invo_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }



     

        private void invo_Indiv_Select_topProcBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void invpo_indiv_panel_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            customer custom = new customer();
            custom.Show();
            needclose = false;
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vw_invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needclose)
            {
                Application.OpenForms["home"].Close();
                Application.OpenForms["vw_invoice"].Close();
                Application.OpenForms["query"].Close();
                Application.OpenForms["customer"].Close();
                Application.OpenForms["deliveries"].Close();
                Application.OpenForms["indiv_invoices"].Close();
                
            }
        
        }

        private void proc_select_invoiceBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

    
    }
}
