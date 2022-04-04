using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_UI
{
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }

        

        private void button1_guncelle_kaydet_Click_1(object sender, EventArgs e)
        {
            Eshipper eshipper = new Eshipper();
            bool sonuc = false;

            if (Convert.ToInt32(textBox1_guncelle_id.Text) > 0 || textBox1_guncelle_id.Text != string.Empty)
            {
                eshipper.ShipperID = Convert.ToInt32(textBox1_guncelle_id.Text);
                eshipper.CompanyName = textBox2_guncelle_ad.Text;
                eshipper.Phone = textBox3_guncelle_tel.Text;
                sonuc = BLL.BLLShipper.BLL_Update(eshipper);
            }

            if (sonuc)
            {
                MessageBox.Show("Güncelleme Yapıldı.");
            }
            else
            {
                MessageBox.Show("İşlam Yapılamadı");
            }
        }

        private void textBox1_guncelle_id_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            Eshipper eshipper = new Eshipper();
            if (textBox1_guncelle_id.Text!=string.Empty)
            {
                eshipper.ShipperID = Convert.ToInt32(textBox1_guncelle_id.Text);
            }
            else
            {
                textBox2_guncelle_ad.Text = "";
                textBox3_guncelle_tel.Text = "";
            }
            
            dr= BLL.BLLShipper.doldur(eshipper);

            while (dr.Read())
            {
                textBox2_guncelle_ad.Text = dr[0].ToString();
                textBox3_guncelle_tel.Text = dr[1].ToString();

            }
        }
    }
}
