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
    public partial class Form_Del : Form
    {
        public Form_Del()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool sonuc = false;

            if (Convert.ToInt32( textBox1_id.Text)>0)
            {
                sonuc= BLL.BLLShipper.BLL_del(Convert.ToInt32(textBox1_id.Text));

                if (sonuc)
                {
                    MessageBox.Show("Kayıt silindi");
                }
                else
                {
                    MessageBox.Show("İlgili Kaydın Bağlantısı Mevcut");
                }
            }
            else
            {
                MessageBox.Show("İlgili kayıt bulunamadı");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            Eshipper eshipper = new Eshipper();
            if (textBox1_id.Text != string.Empty)
            {
                eshipper.ShipperID = Convert.ToInt32(textBox1_id.Text);
            }
            else
            {
                textBox2_ad.Text = "";
                textBox_phone.Text = "";
            }

            dr = BLL.BLLShipper.doldur(eshipper);

            while (dr.Read())
            {
                textBox2_ad.Text = dr[0].ToString();
                textBox_phone.Text = dr[1].ToString();

            }
        }

        
    }
    }

