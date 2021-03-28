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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advanceDataSet);
            invoice_Load(sender,e);
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advanceDataSet.customer' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.advanceDataSet.employee);
            // TODO: This line of code loads data into the 'advanceDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.advanceDataSet.customer);
            // TODO: This line of code loads data into the 'advanceDataSet.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.advanceDataSet.invoice);

        }

        private void invoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buy_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void invoiceBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void custom_idTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emp_idTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void noticesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
