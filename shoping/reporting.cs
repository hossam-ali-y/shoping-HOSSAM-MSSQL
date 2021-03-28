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
    public partial class reporting : Form
    {
        public reporting()
        {
            InitializeComponent();
        }

        private void report_invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advanceDataSet.IndivisualDeliver' table. You can move, or remove it, as needed.
        //    this.IndivisualDeliverTableAdapter.Fill(this.advanceDataSet.IndivisualDeliver);
            // TODO: This line of code loads data into the 'advanceDataSet.DeliveriesSelectProc' table. You can move, or remove it, as needed.
        //    this.deliveriesSelectProcTableAdapter.Fill(this.advanceDataSet.DeliveriesSelectProc);
            // TODO: This line of code loads data into the 'advanceDataSet.IndivisualDeliver' table. You can move, or remove it, as needed.
           // this.IndivisualDeliverTableAdapter.Fill(this.advanceDataSet.IndivisualDeliver);
            // TODO: This line of code loads data into the 'advanceDataSet.Invo_Indiv_Select_topProc' table. You can move, or remove it, as needed.
            //this.invo_Indiv_Select_topProcTableAdapter.Fill(this.advanceDataSet.Invo_Indiv_Select_topProc);
            // TODO: This line of code loads data into the 'advanceDataSet.Invo_Indiv_Select_topProc' table. You can move, or remove it, as needed.
          // this.Invo_Indiv_Select_topProcTableAdapter.Fill(this.advanceDataSet.Invo_Indiv_Select_topProc);

          //  this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

            reportViewer1.ShowExportButton = true;
        }
    }
}
