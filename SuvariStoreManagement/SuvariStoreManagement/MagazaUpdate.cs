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
    public partial class MagazaUpdate : Form
    {
        public MagazaUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            


            String Connstr = "Data Source=SIBEL-PC;Initial Catalog=SuvariSrv;Integrated Security=SSPI;";
            SqlConnection sql = new SqlConnection(Connstr);

           String str = String.Empty;

           str = "UPDATE MagazaTanim SET (BolgeKodu,MagazaKodu,MagazaKisaKodu,MagazaAdi,MagazaTipi,MagazaLokasyonTipi,MagazaAlan,MagazaIli,IlBolgesi,MagazaAdres,MagazaYetkilisiAdi,MagazaYetkilisiUnvani,MagazaSabitHatNo,MagazaGsmNo,MagazaMail,MagazaYetkilisiKisiselGSMNo) ";
           str = str + " WHERE RecordID = " + "txtRecordID.Text";

          

            SqlCommand cmd = new SqlCommand(str, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Mağaza güncelleme başarıyla tamamlandı", "Bilgi", MessageBoxButtons.OK);
           
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {

        }
    }
}
