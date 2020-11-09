namespace StajBasvurusu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BasvuruYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BasvuruGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "AnaSayfa";
            // 
            // BasvuruYap
            // 
            this.BasvuruYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasvuruYap.Location = new System.Drawing.Point(220, 285);
            this.BasvuruYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BasvuruYap.Name = "BasvuruYap";
            this.BasvuruYap.Size = new System.Drawing.Size(176, 68);
            this.BasvuruYap.TabIndex = 1;
            this.BasvuruYap.Text = "Başvuru Yap";
            this.BasvuruYap.UseVisualStyleBackColor = true;
            this.BasvuruYap.Click += new System.EventHandler(this.BasvuruYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(849, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bu sayfada staj başvurusu yapabilir. Eğer zaten başvurunuz varsa görüntüleyebilir" +
    "siniz.";
            // 
            // BasvuruGor
            // 
            this.BasvuruGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasvuruGor.Location = new System.Drawing.Point(752, 285);
            this.BasvuruGor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BasvuruGor.Name = "BasvuruGor";
            this.BasvuruGor.Size = new System.Drawing.Size(178, 68);
            this.BasvuruGor.TabIndex = 3;
            this.BasvuruGor.Text = "Başvuru Görüntüle";
            this.BasvuruGor.UseVisualStyleBackColor = true;
            this.BasvuruGor.Click += new System.EventHandler(this.BasvuruGor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BasvuruGor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BasvuruYap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Staj Başvuru Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BasvuruYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BasvuruGor;
    }
}

