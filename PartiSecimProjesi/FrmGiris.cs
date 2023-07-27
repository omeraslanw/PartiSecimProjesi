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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void btnOy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Ilce (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlce.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy kaydı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frm=new FrmGrafik();
            frm.Show();
        }
    }
}
