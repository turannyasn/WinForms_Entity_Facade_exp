
namespace Windows_UI
{
    partial class Form2
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
            this.button1_kaydet = new System.Windows.Forms.Button();
            this.textBox3_kaydet_tel = new System.Windows.Forms.TextBox();
            this.textBox2_kaydet_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_kaydet
            // 
            this.button1_kaydet.Location = new System.Drawing.Point(198, 136);
            this.button1_kaydet.Name = "button1_kaydet";
            this.button1_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button1_kaydet.TabIndex = 13;
            this.button1_kaydet.Text = "Kaydet";
            this.button1_kaydet.UseVisualStyleBackColor = true;
            this.button1_kaydet.Click += new System.EventHandler(this.button1_kaydet_Click);
            // 
            // textBox3_kaydet_tel
            // 
            this.textBox3_kaydet_tel.Location = new System.Drawing.Point(138, 92);
            this.textBox3_kaydet_tel.Name = "textBox3_kaydet_tel";
            this.textBox3_kaydet_tel.Size = new System.Drawing.Size(135, 20);
            this.textBox3_kaydet_tel.TabIndex = 12;
            // 
            // textBox2_kaydet_ad
            // 
            this.textBox2_kaydet_ad.Location = new System.Drawing.Point(138, 45);
            this.textBox2_kaydet_ad.Name = "textBox2_kaydet_ad";
            this.textBox2_kaydet_ad.Size = new System.Drawing.Size(135, 20);
            this.textBox2_kaydet_ad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şirket Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şirket Ad";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 265);
            this.Controls.Add(this.button1_kaydet);
            this.Controls.Add(this.textBox3_kaydet_tel);
            this.Controls.Add(this.textBox2_kaydet_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_kaydet;
        private System.Windows.Forms.TextBox textBox3_kaydet_tel;
        private System.Windows.Forms.TextBox textBox2_kaydet_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}