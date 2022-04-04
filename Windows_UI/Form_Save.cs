using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_UI
{
    public partial class Form_Save : Form
    {
        public Form_Save()
        {
            InitializeComponent();
        }

        private void button1_kaydet_Click(object sender, EventArgs e)
        {
            string mesaj = string.Empty;
            Eshipper eshipper = new Eshipper();
            eshipper.CompanyName=textBox2_kaydet_ad.Text;
             eshipper.Phone=textBox3_kaydet_tel.Text;

            bool sonuc = BLL.BLLShipper.BLL_Insert(eshipper);

            if (sonuc)
            {
                mesaj = "İşlem Başarılı";
            }
            else
            {
                mesaj = "işlem Başarısız";
            }
            MessageBox.Show(mesaj, "işlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
