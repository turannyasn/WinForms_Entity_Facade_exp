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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Save form_Save = new Form_Save();
            form_Save.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Update form_Update = new Form_Update();
            form_Update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Del form_Del = new Form_Del();
            form_Del.Show();
        }
    }
}
