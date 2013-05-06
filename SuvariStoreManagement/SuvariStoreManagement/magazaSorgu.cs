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
    public partial class magazaSorgu : Form
    {
        public magazaSorgu()
        {
            InitializeComponent();
            
        }
        public int formWidth  { get; set; }
        public int formHeight { get; set; }
        private void magazaSorgu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suvariData1.MagazaTanim' table. You can move, or remove it, as needed.
           
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMagazaKisaKodu.Text))
            {
                cmbMagazaAdi.Enabled = true;
            }
            else
            {
                cmbMagazaAdi.Enabled = false;
            }

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
            panel1.Visible = false;
            this.Width = formWidth;
            this.Height = formHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMagazaAdi.Text == "" && cmbMagazaKisaKodu.Text == "")
            {
                MessageBox.Show("Bir seçenek seçilmeli!");
                return;
            }
            panel1.Visible = true;
            formWidth = this.Width;
            formHeight = this.Height;
            panel1.BringToFront();
            string kosul = string.Empty;
            if(!string.IsNullOrEmpty(cmbMagazaAdi.Text) || !string.IsNullOrWhiteSpace(cmbMagazaAdi.Text))
            {
                kosul = " MagazaAdi ='" + cmbMagazaAdi.Text + "'";
            }
            else if (!string.IsNullOrEmpty(cmbMagazaKisaKodu.Text) || !string.IsNullOrWhiteSpace(cmbMagazaKisaKodu.Text))
            {
                kosul = " MagazaKisaKodu ='" + cmbMagazaKisaKodu.Text+"'";                     
            }
            string sqlCommand = @"select * from MagazaTanim where " + kosul ;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, magazaTanimTableAdapter.Connection);
            adapter.Fill(this.suvariData1.MagazaTanim);
            this.dataGridView1.DataSource = suvariData1.MagazaTanim;
        }

        private void cmbMagazaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMagazaAdi.Text))
            {
                cmbMagazaKisaKodu.Enabled = true;

            }
            else
            {
                cmbMagazaKisaKodu.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbMagazaAdi.Text = "";
            cmbMagazaKisaKodu.Text = "";
            cmbMagazaAdi.Enabled = true;
            cmbMagazaKisaKodu.Enabled = true;
        }

    }
}
