using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuvariStoreManagement
{
    public partial class bolgeselSorgu : Form
    {
        public int formWidth { get; set; }
        public int formHeight { get; set; }
        public bolgeselSorgu()
        {
            InitializeComponent();
        }

        private void bolgeselSorgu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sqlcommand = @"select * from MagazaTanim where bolgeKodu='"+comboBox1 .Text +"'";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand, magazaTanimTableAdapter.Connection);
            adapter.Fill(this.suvariData1.MagazaTanim);
            this.dataGridView1.DataSource = suvariData1.MagazaTanim;


            panel1.Visible = true;
            formWidth = this.Width;
            formHeight = this.Height;
            panel1.BringToFront();


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Width = formWidth;
            this.Height = formHeight;
        }

    }
}
