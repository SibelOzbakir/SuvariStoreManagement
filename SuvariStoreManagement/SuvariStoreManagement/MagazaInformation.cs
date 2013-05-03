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
    public partial class MagazaInformation : Form
    {
        public MagazaInformation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlTextAreas())
            {
                errorProvider1.SetError(btnSave, "Alanlar Boş Geçilemez");
                return;
            }
            String Connstr = "Data Source=SIBEL-PC;Initial Catalog=SuvariSrv;Integrated Security=SSPI;";
            SqlConnection sql = new SqlConnection(Connstr);



            string str = "INSERT INTO MagazaTanim (BolgeKodu,MagazaKodu,MagazaKisaKodu,MagazaAdi,MagazaTipi,MagazaLokasyonTipi,MagazaAlan,MagazaIli,IlBolgesi,MagazaAdres,MagazaYetkilisiAdi,MagazaYetkilisiUnvani,MagazaSabitHatNo,MagazaGsmNo,MagazaMail,MagazaYetkilisiKisiselGSMNo) ";
            str += " Values ('" + cmbBolgeKodu.Text + "','" + 
                txtMagazaKodu.Text + "','" + 
                txtMagazaKisaKodu.Text + "','" + 
                txtMagazaAdi.Text + "','" + 
                cmbMagazaTipi.Text + "','" + 
                cmbMagazaLokasyonTipi.Text + "'," + 
                Convert.ToDecimal(txtMagazaAlan.Text) + ",'" + 
                cmbMagazaIli.Text + "','" + 
                cmbIlBolgesi.Text + "','" + 
                txtMagazaAdres.Text + "','" + 
                txtMagazaYetkilisiAdi.Text + "','" + 
                cmbMagazaYetkilisiUnvani.Text + "','" + 
                txtMagazaSabitHatNo.Text + "','" + 
                txtMagazaGSMNo.Text + "','" + 
                txtMagazaMail.Text + "','" + 
                txtMagazaYetkilisiKisiselGSMNo.Text + "')";

            SqlCommand cmd = new SqlCommand(str,sql);
            sql.Open();
            cmd.ExecuteNonQuery();
                sql.Close();

                MessageBox.Show("Mağaza kaydedildi","Bilgi",MessageBoxButtons.OK);

        }

        private bool ControlTextAreas()
        {
            return txtMagazaAdi.Text != "" &&
                txtMagazaAdres.Text != "" &&
                txtMagazaAlan.Text != " " &&
                txtMagazaGSMNo.Text != " " &&
                txtMagazaKisaKodu.Text != " " &&
                txtMagazaKodu.Text != " " &&
                txtMagazaMail.Text != " " &&
                txtMagazaSabitHatNo.Text != " " &&
                txtMagazaYetkilisiAdi.Text != " " &&
                txtMagazaYetkilisiKisiselGSMNo.Text != " "; 

               

      
        }

        private void MagazaInformation_Load(object sender, EventArgs e)
        {

        }

        private void cmbBolgeKodu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMagazaKodu_TextChanged(object sender, EventArgs e)
         
        {
          
          
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}