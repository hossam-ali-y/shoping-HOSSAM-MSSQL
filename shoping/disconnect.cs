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
    public partial class disconnect : Form
    {
        home db = new home();
        public disconnect()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                db.con.Open();
                if (db.con.State.ToString() == "Open")
                {
                    query log = new query();
                    log.ShowDialog();
                }
                else
                {
             disconnect_Load(sender,e);
                }
            }
            catch
            {
           
            }
            
        }

        private void disconnect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advanceDataSet.proc_select_invoice' table. You can move, or remove it, as needed.

            msgdisconnect.Text = db.con.State.ToString() + " خطاء في الإتصال تأكد من اسم الخادم \n افحص الاتصال وحاول ثانية";
            connect.Text = "أنقر لإعادة الاتصال";
        }

 

        private void disconnect_Load_1(object sender, EventArgs e)
        {

        }

        private void disconnect_Load_2(object sender, EventArgs e)
        {

        }



        private void disconnect_Load_3(object sender, EventArgs e)
        {

        }


        private void disconnect_Load_4(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disconnect));
            this.connect = new System.Windows.Forms.LinkLabel();
            this.msgdisconnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.BackColor = System.Drawing.Color.Cornsilk;
            this.connect.Font = new System.Drawing.Font("PT Simple Bold Ruled", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.connect.Location = new System.Drawing.Point(67, 147);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(31, 20);
            this.connect.TabIndex = 0;
            this.connect.TabStop = true;
            this.connect.Text = "link";
            this.connect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // msgdisconnect
            // 
            this.msgdisconnect.AutoSize = true;
            this.msgdisconnect.BackColor = System.Drawing.Color.Cornsilk;
            this.msgdisconnect.Font = new System.Drawing.Font("PT Simple Bold Ruled", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msgdisconnect.ForeColor = System.Drawing.Color.Maroon;
            this.msgdisconnect.Location = new System.Drawing.Point(63, 101);
            this.msgdisconnect.Name = "msgdisconnect";
            this.msgdisconnect.Size = new System.Drawing.Size(38, 20);
            this.msgdisconnect.TabIndex = 1;
            this.msgdisconnect.Text = "msg";
            // 
            // disconnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = global::shoping.Properties.Resources.احلي_صور_ابراج_3_450x310;
            this.ClientSize = new System.Drawing.Size(329, 338);
            this.Controls.Add(this.msgdisconnect);
            this.Controls.Add(this.connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "disconnect";
            this.Text = "تعذر الأتصال بالخادم";
            this.Load += new System.EventHandler(this.disconnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.LinkLabel connect;
        private System.Windows.Forms.Label msgdisconnect;
        private IContainer components;
        private void disconnect_Load_5(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
