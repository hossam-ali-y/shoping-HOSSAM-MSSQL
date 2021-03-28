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
using MySql.Data.MySqlClient;

namespace shoping
{
    public partial class main : Form
    {
        //public MySqlConnection mycon = new MySqlConnection("Server=localhostL;Initial Catalog=storemanagment;uid=root;Integrated Security=True");
        //public MySqlCommand mycmd;
        //public MySqlDataReader mydr;

        //public SqlConnection con = new SqlConnection(@"Data Source=HOSSAM\MSSQL;Initial Catalog=advance;Integrated Security=True");
        //public SqlCommand cmd;
        //public SqlDataReader dr;
        public static string emp_session;
        home db = new home();
        public main()
        {
            InitializeComponent();
            //try
            //{
            //    db.con.Open();
            //}
            //catch {

            //}
            //if (db.con.State.ToString() == "Closed")
            //{
            //    disconnect dis = new disconnect();
            //    dis.Show();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sales sal = new sales();
            //sal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deliveries deliv = new deliveries();
            deliv.Show();
            //invoices inv = new invoices();
            //inv.Show();
            //products pro = new products();
            //pro.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            
            //stores stor = new stores();
            //stor.Show();
           vw_invoice v= new vw_invoice();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invoice invo = new invoice();
            invo.Show();
            //invo inv = new invo();
            //inv.Show();
        }


        private void sale_monitor_Click(object sender, EventArgs e)
        {
            //sales_monitore sal_monit = new sales_monitore();
            //sal_monit.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }



        private void main_Load_1(object sender, EventArgs e)
        {

        }


        private void main_Load_2(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sales = new System.Windows.Forms.Button();
            this.stores = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.sale_monitor = new System.Windows.Forms.Button();
            this.store_monitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.Brown;
            this.sales.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales.ForeColor = System.Drawing.Color.White;
            this.sales.Location = new System.Drawing.Point(0, 29);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(327, 53);
            this.sales.TabIndex = 0;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.button2_Click);
            // 
            // stores
            // 
            this.stores.BackColor = System.Drawing.Color.SeaGreen;
            this.stores.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stores.ForeColor = System.Drawing.Color.White;
            this.stores.Location = new System.Drawing.Point(0, 88);
            this.stores.Name = "stores";
            this.stores.Size = new System.Drawing.Size(327, 53);
            this.stores.TabIndex = 1;
            this.stores.Text = "فواتير الدين";
            this.stores.UseVisualStyleBackColor = false;
            this.stores.Click += new System.EventHandler(this.products_Click);
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.Teal;
            this.products.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.ForeColor = System.Drawing.Color.White;
            this.products.Location = new System.Drawing.Point(0, 147);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(327, 53);
            this.products.TabIndex = 2;
            this.products.Text = "المسلمات";
            this.products.UseVisualStyleBackColor = false;
            this.products.Click += new System.EventHandler(this.button3_Click);
            // 
            // sale_monitor
            // 
            this.sale_monitor.BackColor = System.Drawing.Color.Olive;
            this.sale_monitor.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_monitor.ForeColor = System.Drawing.Color.White;
            this.sale_monitor.Location = new System.Drawing.Point(0, 303);
            this.sale_monitor.Name = "sale_monitor";
            this.sale_monitor.Size = new System.Drawing.Size(327, 53);
            this.sale_monitor.TabIndex = 3;
            this.sale_monitor.Text = "Sale Monitor";
            this.sale_monitor.UseVisualStyleBackColor = false;
            this.sale_monitor.Click += new System.EventHandler(this.sale_monitor_Click);
            // 
            // store_monitor
            // 
            this.store_monitor.BackColor = System.Drawing.Color.ForestGreen;
            this.store_monitor.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store_monitor.ForeColor = System.Drawing.Color.White;
            this.store_monitor.Location = new System.Drawing.Point(0, 244);
            this.store_monitor.Name = "store_monitor";
            this.store_monitor.Size = new System.Drawing.Size(327, 53);
            this.store_monitor.TabIndex = 4;
            this.store_monitor.Text = "Store Monitor";
            this.store_monitor.UseVisualStyleBackColor = false;
            this.store_monitor.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(327, 408);
            this.Controls.Add(this.store_monitor);
            this.Controls.Add(this.sale_monitor);
            this.Controls.Add(this.products);
            this.Controls.Add(this.stores);
            this.Controls.Add(this.sales);
            this.Name = "main";
            this.Text = "الخدمات";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        private void main_Load_3(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button stores;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button sale_monitor;
        private System.Windows.Forms.Button store_monitor;


    }
}
