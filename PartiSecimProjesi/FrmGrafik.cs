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

namespace PartiSecimProjesi
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            //İlçe adlarının combobox'a eklenmesi
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from Tbl_Ilce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Items.Add(dr[0].ToString());
            }
            baglanti.Close();

            //grafiğe seçim sonuçlarını getirme
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from Tbl_Ilce", baglanti);
            SqlDataReader dr3=komut3.ExecuteReader();
            while(dr3.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("APARTI", dr3[0]);
                chart1.Series["Partiler"].Points.AddXY("BPARTI", dr3[1]);
                chart1.Series["Partiler"].Points.AddXY("CPARTI", dr3[2]);
                chart1.Series["Partiler"].Points.AddXY("DPARTI", dr3[3]);
                chart1.Series["Partiler"].Points.AddXY("EPARTI", dr3[4]);

            }
            baglanti.Close();
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //parti verilerinin labellara eklenmesi
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Ilce where ILCEAD=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", cmbIlce.Text);
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblA.Text = dr2[2].ToString();
                lblB.Text = dr2[3].ToString();   
                lblC.Text = dr2[4].ToString();
                lblD.Text = dr2[5].ToString();
                lblE.Text = dr2[6].ToString();

                prgbarA.Value = int.Parse(dr2[2].ToString());
                prgbarB.Value = int.Parse(dr2[3].ToString());
                prgbarC.Value = int.Parse(dr2[4].ToString());
                prgbarD.Value = int.Parse(dr2[5].ToString());
                prgbarE.Value = int.Parse(dr2[6].ToString());
            }
            baglanti.Close();
        }
    }
}
