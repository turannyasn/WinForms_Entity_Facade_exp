
namespace Windows_UI
{
    partial class Form_Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_guncelle_id = new System.Windows.Forms.TextBox();
            this.textBox2_guncelle_ad = new System.Windows.Forms.TextBox();
            this.textBox3_guncelle_tel = new System.Windows.Forms.TextBox();
            this.button1_guncelle_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket İd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şirket Tel";
            // 
            // textBox1_guncelle_id
            // 
            this.textBox1_guncelle_id.Location = new System.Drawing.Point(101, 26);
            this.textBox1_guncelle_id.Name = "textBox1_guncelle_id";
            this.textBox1_guncelle_id.Size = new System.Drawing.Size(135, 20);
            this.textBox1_guncelle_id.TabIndex = 3;
            this.textBox1_guncelle_id.TextChanged += new System.EventHandler(this.textBox1_guncelle_id_TextChanged);
            // 
            // textBox2_guncelle_ad
            // 
            this.textBox2_guncelle_ad.Location = new System.Drawing.Point(101, 70);
            this.textBox2_guncelle_ad.Name = "textBox2_guncelle_ad";
            this.textBox2_guncelle_ad.Size = new System.Drawing.Size(135, 20);
            this.textBox2_guncelle_ad.TabIndex = 4;
            // 
            // textBox3_guncelle_tel
            // 
            this.textBox3_guncelle_tel.Location = new System.Drawing.Point(101, 117);
            this.textBox3_guncelle_tel.Name = "textBox3_guncelle_tel";
            this.textBox3_guncelle_tel.Size = new System.Drawing.Size(135, 20);
            this.textBox3_guncelle_tel.TabIndex = 5;
            // 
            // button1_guncelle_kaydet
            // 
            this.button1_guncelle_kaydet.Location = new System.Drawing.Point(161, 161);
            this.button1_guncelle_kaydet.Name = "button1_guncelle_kaydet";
            this.button1_guncelle_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button1_guncelle_kaydet.TabIndex = 6;
            this.button1_guncelle_kaydet.Text = "Guncelle";
            this.button1_guncelle_kaydet.UseVisualStyleBackColor = true;
            this.button1_guncelle_kaydet.Click += new System.EventHandler(this.button1_guncelle_kaydet_Click_1);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 251);
            this.Controls.Add(this.button1_guncelle_kaydet);
            this.Controls.Add(this.textBox3_guncelle_tel);
            this.Controls.Add(this.textBox2_guncelle_ad);
            this.Controls.Add(this.textBox1_guncelle_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Update";
            this.Text = "Kayıt Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_guncelle_id;
        private System.Windows.Forms.TextBox textBox2_guncelle_ad;
        private System.Windows.Forms.TextBox textBox3_guncelle_tel;
        private System.Windows.Forms.Button button1_guncelle_kaydet;
    }
}

