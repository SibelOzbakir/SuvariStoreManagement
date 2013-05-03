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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagazaInformation m = new MagazaInformation();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MagazaDelete md = new MagazaDelete();
            md.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMagazaGuncelle_Click(object sender, EventArgs e)
        {
            MagazaUpdate s = new MagazaUpdate();
            s.Show();
        }

        private void btnMagazaRapor_Click(object sender, EventArgs e)
        {
            magazaSorgu n = new magazaSorgu();
            n.Show();

        }

        private void btnMagazaBolgesel_Click(object sender, EventArgs e)
        {
            bolgeselSorgu bs = new bolgeselSorgu();
            bs.Show();

        }

        private void btnMagazaTurkiye_Click(object sender, EventArgs e)
        {
            turkiyeSorgu s = new turkiyeSorgu();
            s.Show();

        }

        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
