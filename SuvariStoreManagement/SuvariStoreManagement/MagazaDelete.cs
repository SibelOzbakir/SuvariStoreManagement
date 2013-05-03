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
    public partial class MagazaDelete : Form
    {
        String Connstr = "Data Source=SIBEL-PC;Initial Catalog=SuvariSrv;Integrated Security=SSPI;";
        public MagazaDelete()
        {
            InitializeComponent();
            fillCmb();
        }

        private void fillCmb()
        {
          
            SqlConnection sql = new SqlConnection(Connstr);
            String str = String.Empty;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
         //   int i = 0;

            str = "select RecordId,MagazaAdi,MagazaKisaKodu from MagazaTanim";

            //SqlCommand cmd = new SqlCommand(str, sql);
            SqlDataAdapter adap = new SqlDataAdapter();
            sql.Open();
            adap.SelectCommand = new SqlCommand(str,sql);
            adap.Fill(ds);
           
            sql.Close();

            cmbMagazaAdi.Items.Clear();
          this.cmbMagazaAdi.Items.AddRange(new object[] {"--Seçiniz--"});
            
            cmbMagazaKisaKodu.Items.Clear();
          this.cmbMagazaKisaKodu.Items.AddRange(new object[] {"--Seçiniz--"});

            //for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //{

            //    MessageBox.Show(ds.Tables[0].Rows[1].ItemArray[1].ToString());

            //    this.cmbMkk.Items.AddRange(new object[] { "--Seçiniz--", });
            //}

            for (int i = 0; i < ds.Tables[0].Rows.Count ; i++)
            {

                this.cmbMagazaAdi.Items.AddRange(new object[] { ds.Tables[0].Rows[i].ItemArray[1].ToString() });

                this.cmbMagazaKisaKodu.Items.AddRange(new object[] { ds.Tables[0].Rows[i].ItemArray[2].ToString() });
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        
        {
            String str = String.Empty;

            if (cmbMagazaKisaKodu.Text != "--Seçiniz--" )
            {
                str = "DELETE FROM MagazaTanim WHERE MagazaKisaKodu = '" + cmbMagazaKisaKodu.Text + "'";
            }
            else if (cmbMagazaAdi.Text != "--Seçiniz--" )
            {
                str = "DELETE FROM MagazaTanim WHERE MagazaAdi = " + cmbMagazaAdi.Text + "'";
            }

            String Connstr = "Data Source=SIBEL-PC;Initial Catalog=SuvariSrv;Integrated Security=SSPI;";
            SqlConnection sql = new SqlConnection(Connstr);

            SqlCommand cmd = new SqlCommand(str, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Mağaza silindi", "Bilgi", MessageBoxButtons.OK);

        }
    }
}
