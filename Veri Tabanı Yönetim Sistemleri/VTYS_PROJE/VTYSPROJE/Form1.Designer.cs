
namespace vtysproje
{
    partial class GirisForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunlistcombobox = new System.Windows.Forms.ComboBox();
            this.eklemarkatextbox = new System.Windows.Forms.TextBox();
            this.eklemodeltextbox = new System.Windows.Forms.TextBox();
            this.eklehamfiyattextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ekleurunturucombobox = new System.Windows.Forms.ComboBox();
            this.eklebuton = new System.Windows.Forms.Button();
            this.urunsiltextbox = new System.Windows.Forms.TextBox();
            this.urunsilbuton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DEPObuton = new System.Windows.Forms.Button();
            this.MAGAZAbuton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 463);
            this.dataGridView1.TabIndex = 1;
            // 
            // urunlistcombobox
            // 
            this.urunlistcombobox.FormattingEnabled = true;
            this.urunlistcombobox.Items.AddRange(new object[] {
            "Silinen Ürünler",
            "Ekran Kartı",
            "İşlemci",
            "Anakart",
            "Ram",
            "Güç Kaynağı",
            "Depolama"});
            this.urunlistcombobox.Location = new System.Drawing.Point(12, 180);
            this.urunlistcombobox.Name = "urunlistcombobox";
            this.urunlistcombobox.Size = new System.Drawing.Size(134, 24);
            this.urunlistcombobox.TabIndex = 2;
            this.urunlistcombobox.Text = "ÜRÜN SEÇ";
            // 
            // eklemarkatextbox
            // 
            this.eklemarkatextbox.Location = new System.Drawing.Point(166, 47);
            this.eklemarkatextbox.Name = "eklemarkatextbox";
            this.eklemarkatextbox.Size = new System.Drawing.Size(134, 22);
            this.eklemarkatextbox.TabIndex = 4;
            // 
            // eklemodeltextbox
            // 
            this.eklemodeltextbox.Location = new System.Drawing.Point(166, 75);
            this.eklemodeltextbox.Name = "eklemodeltextbox";
            this.eklemodeltextbox.Size = new System.Drawing.Size(134, 22);
            this.eklemodeltextbox.TabIndex = 5;
            // 
            // eklehamfiyattextbox
            // 
            this.eklehamfiyattextbox.Location = new System.Drawing.Point(166, 103);
            this.eklehamfiyattextbox.Name = "eklehamfiyattextbox";
            this.eklehamfiyattextbox.Size = new System.Drawing.Size(134, 22);
            this.eklehamfiyattextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ÜrünTürü..:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka..:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(71, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model..:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(59, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "İlk Fiyat..:";
            // 
            // ekleurunturucombobox
            // 
            this.ekleurunturucombobox.FormattingEnabled = true;
            this.ekleurunturucombobox.Items.AddRange(new object[] {
            "ekrankarti",
            "islemci",
            "anakart",
            "depolama",
            "guckaynagi",
            "ram"});
            this.ekleurunturucombobox.Location = new System.Drawing.Point(166, 17);
            this.ekleurunturucombobox.Name = "ekleurunturucombobox";
            this.ekleurunturucombobox.Size = new System.Drawing.Size(134, 24);
            this.ekleurunturucombobox.TabIndex = 12;
            // 
            // eklebuton
            // 
            this.eklebuton.Location = new System.Drawing.Point(166, 133);
            this.eklebuton.Name = "eklebuton";
            this.eklebuton.Size = new System.Drawing.Size(134, 39);
            this.eklebuton.TabIndex = 13;
            this.eklebuton.Text = "ÜRÜN EKLE";
            this.eklebuton.UseVisualStyleBackColor = true;
            this.eklebuton.Click += new System.EventHandler(this.eklebuton_Click);
            // 
            // urunsiltextbox
            // 
            this.urunsiltextbox.Location = new System.Drawing.Point(166, 259);
            this.urunsiltextbox.Name = "urunsiltextbox";
            this.urunsiltextbox.Size = new System.Drawing.Size(134, 22);
            this.urunsiltextbox.TabIndex = 14;
            // 
            // urunsilbuton
            // 
            this.urunsilbuton.Location = new System.Drawing.Point(166, 287);
            this.urunsilbuton.Name = "urunsilbuton";
            this.urunsilbuton.Size = new System.Drawing.Size(134, 39);
            this.urunsilbuton.TabIndex = 15;
            this.urunsilbuton.Text = "ÜRÜN SİL";
            this.urunsilbuton.UseVisualStyleBackColor = true;
            this.urunsilbuton.Click += new System.EventHandler(this.urunsilbuton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(27, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Silinecek ID..:";
            // 
            // DEPObuton
            // 
            this.DEPObuton.Location = new System.Drawing.Point(12, 434);
            this.DEPObuton.Name = "DEPObuton";
            this.DEPObuton.Size = new System.Drawing.Size(132, 40);
            this.DEPObuton.TabIndex = 19;
            this.DEPObuton.Text = "DEPO";
            this.DEPObuton.UseVisualStyleBackColor = true;
            this.DEPObuton.Click += new System.EventHandler(this.DEPObuton_Click);
            // 
            // MAGAZAbuton
            // 
            this.MAGAZAbuton.Location = new System.Drawing.Point(165, 434);
            this.MAGAZAbuton.Name = "MAGAZAbuton";
            this.MAGAZAbuton.Size = new System.Drawing.Size(135, 40);
            this.MAGAZAbuton.TabIndex = 20;
            this.MAGAZAbuton.Text = "MAĞAZA";
            this.MAGAZAbuton.UseVisualStyleBackColor = true;
            this.MAGAZAbuton.Click += new System.EventHandler(this.MAGAZAbuton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(12, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 69);
            this.button2.TabIndex = 43;
            this.button2.Text = "Arama Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1234, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MAGAZAbuton);
            this.Controls.Add(this.DEPObuton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urunsilbuton);
            this.Controls.Add(this.urunsiltextbox);
            this.Controls.Add(this.eklebuton);
            this.Controls.Add(this.ekleurunturucombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eklehamfiyattextbox);
            this.Controls.Add(this.eklemodeltextbox);
            this.Controls.Add(this.eklemarkatextbox);
            this.Controls.Add(this.urunlistcombobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "GirisForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox urunlistcombobox;
        private System.Windows.Forms.TextBox eklemarkatextbox;
        private System.Windows.Forms.TextBox eklemodeltextbox;
        private System.Windows.Forms.TextBox eklehamfiyattextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ekleurunturucombobox;
        private System.Windows.Forms.Button eklebuton;
        private System.Windows.Forms.TextBox urunsiltextbox;
        private System.Windows.Forms.Button urunsilbuton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DEPObuton;
        private System.Windows.Forms.Button MAGAZAbuton;
        private System.Windows.Forms.Button button2;
    }
}

