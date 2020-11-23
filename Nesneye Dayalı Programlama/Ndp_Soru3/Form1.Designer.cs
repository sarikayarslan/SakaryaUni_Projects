/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 	SORU_3
**				ÖĞRENCİ ADI............: 	ARSLANCAN SARIKAYA
**				ÖĞRENCİ NUMARASI.......:	B181210052
**                         DERSİN ALINDIĞI GRUP...: D
****************************************************************************/

using System;


namespace Proje3
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
            tv.SecilenToplamAdet = tv.StokAdeti;
            Pc.SecilenToplamAdet = Pc.StokAdeti;
            Tel.SecilenToplamAdet = Tel.StokAdeti;
            Buz.SecilenToplamAdet = Buz.StokAdeti;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TVpicture = new System.Windows.Forms.PictureBox();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.Label();
            this.Adet = new System.Windows.Forms.Label();
            this.NumericTVAdet = new System.Windows.Forms.NumericUpDown();
            this.TvFiyat = new System.Windows.Forms.Label();
            this.TvStok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BuzPicture = new System.Windows.Forms.PictureBox();
            this.BuzStok = new System.Windows.Forms.Label();
            this.BuzFiyat = new System.Windows.Forms.Label();
            this.NumericBuzAdet = new System.Windows.Forms.NumericUpDown();
            this.Adet2 = new System.Windows.Forms.Label();
            this.Stok2 = new System.Windows.Forms.Label();
            this.Fiyat2 = new System.Windows.Forms.Label();
            this.PcStok = new System.Windows.Forms.Label();
            this.PcFiyat = new System.Windows.Forms.Label();
            this.NumericPcAdet = new System.Windows.Forms.NumericUpDown();
            this.Adet3 = new System.Windows.Forms.Label();
            this.Stok3 = new System.Windows.Forms.Label();
            this.Fiyat3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TelStok = new System.Windows.Forms.Label();
            this.TelFiyat = new System.Windows.Forms.Label();
            this.NumericTelAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToplamFiyat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KdvList = new System.Windows.Forms.ListBox();
            this.UrunList = new System.Windows.Forms.ListBox();
            this.AdetList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TVpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTVAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuzPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuzAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPcAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTelAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TVpicture
            // 
            this.TVpicture.Image = ((System.Drawing.Image)(resources.GetObject("TVpicture.Image")));
            this.TVpicture.Location = new System.Drawing.Point(27, 28);
            this.TVpicture.Name = "TVpicture";
            this.TVpicture.Size = new System.Drawing.Size(96, 74);
            this.TVpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TVpicture.TabIndex = 0;
            this.TVpicture.TabStop = false;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Location = new System.Drawing.Point(28, 112);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(32, 13);
            this.Fiyat.TabIndex = 1;
            this.Fiyat.Text = "Fiyat:";
            // 
            // Stok
            // 
            this.Stok.AutoSize = true;
            this.Stok.Location = new System.Drawing.Point(28, 134);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(32, 13);
            this.Stok.TabIndex = 2;
            this.Stok.Text = "Stok:";
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Location = new System.Drawing.Point(28, 157);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(32, 13);
            this.Adet.TabIndex = 3;
            this.Adet.Text = "Adet:";
            // 
            // NumericTVAdet
            // 
            this.NumericTVAdet.Location = new System.Drawing.Point(66, 157);
            this.NumericTVAdet.Name = "NumericTVAdet";
            this.NumericTVAdet.Size = new System.Drawing.Size(39, 20);
            this.NumericTVAdet.TabIndex = 4;
            // 
            // TvFiyat
            // 
            this.TvFiyat.AutoSize = true;
            this.TvFiyat.Location = new System.Drawing.Point(63, 112);
            this.TvFiyat.Name = "TvFiyat";
            this.TvFiyat.Size = new System.Drawing.Size(31, 13);
            this.TvFiyat.TabIndex = 5;
            this.TvFiyat.Text = Convert.ToString(tv.HamFiyat);
            // 
            // TvStok
            // 
            this.TvStok.AutoSize = true;
            this.TvStok.Location = new System.Drawing.Point(63, 134);
            this.TvStok.Name = "TvStok";
            this.TvStok.Size = new System.Drawing.Size(19, 13);
            this.TvStok.TabIndex = 6;
            this.TvStok.Text = Convert.ToString(tv.StokAdeti);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ürünleri Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnEkle);
            // 
            // BuzPicture
            // 
            this.BuzPicture.Image = ((System.Drawing.Image)(resources.GetObject("BuzPicture.Image")));
            this.BuzPicture.Location = new System.Drawing.Point(191, 28);
            this.BuzPicture.Name = "BuzPicture";
            this.BuzPicture.Size = new System.Drawing.Size(96, 74);
            this.BuzPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuzPicture.TabIndex = 8;
            this.BuzPicture.TabStop = false;
            // 
            // BuzStok
            // 
            this.BuzStok.AutoSize = true;
            this.BuzStok.Location = new System.Drawing.Point(239, 134);
            this.BuzStok.Name = "BuzStok";
            this.BuzStok.Size = new System.Drawing.Size(19, 13);
            this.BuzStok.TabIndex = 14;
            this.BuzStok.Text = Convert.ToString(Buz.StokAdeti);
            // 
            // BuzFiyat
            // 
            this.BuzFiyat.AutoSize = true;
            this.BuzFiyat.Location = new System.Drawing.Point(239, 112);
            this.BuzFiyat.Name = "BuzFiyat";
            this.BuzFiyat.Size = new System.Drawing.Size(31, 13);
            this.BuzFiyat.TabIndex = 13;
            this.BuzFiyat.Text = Convert.ToString(Buz.HamFiyat);
            // 
            // NumericBuzAdet
            // 
            this.NumericBuzAdet.Location = new System.Drawing.Point(242, 157);
            this.NumericBuzAdet.Name = "NumericBuzAdet";
            this.NumericBuzAdet.Size = new System.Drawing.Size(39, 20);
            this.NumericBuzAdet.TabIndex = 12;
            // 
            // Adet2
            // 
            this.Adet2.AutoSize = true;
            this.Adet2.Location = new System.Drawing.Point(204, 157);
            this.Adet2.Name = "Adet2";
            this.Adet2.Size = new System.Drawing.Size(32, 13);
            this.Adet2.TabIndex = 11;
            this.Adet2.Text = "Adet:";
            // 
            // Stok2
            // 
            this.Stok2.AutoSize = true;
            this.Stok2.Location = new System.Drawing.Point(204, 134);
            this.Stok2.Name = "Stok2";
            this.Stok2.Size = new System.Drawing.Size(32, 13);
            this.Stok2.TabIndex = 10;
            this.Stok2.Text = "Stok:";
            // 
            // Fiyat2
            // 
            this.Fiyat2.AutoSize = true;
            this.Fiyat2.Location = new System.Drawing.Point(204, 112);
            this.Fiyat2.Name = "Fiyat2";
            this.Fiyat2.Size = new System.Drawing.Size(32, 13);
            this.Fiyat2.TabIndex = 9;
            this.Fiyat2.Text = "Fiyat:";
            // 
            // PcStok
            // 
            this.PcStok.AutoSize = true;
            this.PcStok.Location = new System.Drawing.Point(75, 314);
            this.PcStok.Name = "PcStok";
            this.PcStok.Size = new System.Drawing.Size(13, 13);
            this.PcStok.TabIndex = 21;
            this.PcStok.Text = Convert.ToString(Pc.StokAdeti);
            // 
            // PcFiyat
            // 
            this.PcFiyat.AutoSize = true;
            this.PcFiyat.Location = new System.Drawing.Point(75, 292);
            this.PcFiyat.Name = "PcFiyat";
            this.PcFiyat.Size = new System.Drawing.Size(31, 13);
            this.PcFiyat.TabIndex = 20;
            this.PcFiyat.Text = Convert.ToString(Pc.HamFiyat);
            // 
            // NumericPcAdet
            // 
            this.NumericPcAdet.Location = new System.Drawing.Point(78, 337);
            this.NumericPcAdet.Name = "NumericPcAdet";
            this.NumericPcAdet.Size = new System.Drawing.Size(39, 20);
            this.NumericPcAdet.TabIndex = 19;
            // 
            // Adet3
            // 
            this.Adet3.AutoSize = true;
            this.Adet3.Location = new System.Drawing.Point(40, 337);
            this.Adet3.Name = "Adet3";
            this.Adet3.Size = new System.Drawing.Size(32, 13);
            this.Adet3.TabIndex = 18;
            this.Adet3.Text = "Adet:";
            // 
            // Stok3
            // 
            this.Stok3.AutoSize = true;
            this.Stok3.Location = new System.Drawing.Point(40, 314);
            this.Stok3.Name = "Stok3";
            this.Stok3.Size = new System.Drawing.Size(32, 13);
            this.Stok3.TabIndex = 17;
            this.Stok3.Text = "Stok:";
            // 
            // Fiyat3
            // 
            this.Fiyat3.AutoSize = true;
            this.Fiyat3.Location = new System.Drawing.Point(40, 292);
            this.Fiyat3.Name = "Fiyat3";
            this.Fiyat3.Size = new System.Drawing.Size(32, 13);
            this.Fiyat3.TabIndex = 16;
            this.Fiyat3.Text = "Fiyat:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // TelStok
            // 
            this.TelStok.AutoSize = true;
            this.TelStok.Location = new System.Drawing.Point(239, 314);
            this.TelStok.Name = "TelStok";
            this.TelStok.Size = new System.Drawing.Size(19, 13);
            this.TelStok.TabIndex = 28;
            this.TelStok.Text = Convert.ToString(Tel.StokAdeti);
            // 
            // TelFiyat
            // 
            this.TelFiyat.AutoSize = true;
            this.TelFiyat.Location = new System.Drawing.Point(239, 292);
            this.TelFiyat.Name = "TelFiyat";
            this.TelFiyat.Size = new System.Drawing.Size(31, 13);
            this.TelFiyat.TabIndex = 27;
            this.TelFiyat.Text = Convert.ToString(Tel.HamFiyat);
            // 
            // NumericTelAdet
            // 
            this.NumericTelAdet.Location = new System.Drawing.Point(242, 337);
            this.NumericTelAdet.Name = "NumericTelAdet";
            this.NumericTelAdet.Size = new System.Drawing.Size(39, 20);
            this.NumericTelAdet.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fiyat:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BuzPicture);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TelStok);
            this.groupBox1.Controls.Add(this.TVpicture);
            this.groupBox1.Controls.Add(this.TelFiyat);
            this.groupBox1.Controls.Add(this.Fiyat);
            this.groupBox1.Controls.Add(this.NumericTelAdet);
            this.groupBox1.Controls.Add(this.Stok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Adet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumericTVAdet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TvFiyat);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.TvStok);
            this.groupBox1.Controls.Add(this.PcStok);
            this.groupBox1.Controls.Add(this.Fiyat2);
            this.groupBox1.Controls.Add(this.PcFiyat);
            this.groupBox1.Controls.Add(this.Stok2);
            this.groupBox1.Controls.Add(this.NumericPcAdet);
            this.groupBox1.Controls.Add(this.Adet2);
            this.groupBox1.Controls.Add(this.Adet3);
            this.groupBox1.Controls.Add(this.NumericBuzAdet);
            this.groupBox1.Controls.Add(this.Stok3);
            this.groupBox1.Controls.Add(this.BuzFiyat);
            this.groupBox1.Controls.Add(this.Fiyat3);
            this.groupBox1.Controls.Add(this.BuzStok);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 426);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünlerin KDV\'siz Fiyatları";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Sepeti Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnTemzle);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ToplamFiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.KdvList);
            this.groupBox2.Controls.Add(this.UrunList);
            this.groupBox2.Controls.Add(this.AdetList);
            this.groupBox2.Location = new System.Drawing.Point(360, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 424);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Özeti";
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.AutoSize = true;
            this.ToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamFiyat.Location = new System.Drawing.Point(116, 334);
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Size = new System.Drawing.Size(28, 16);
            this.ToplamFiyat.TabIndex = 29;
            this.ToplamFiyat.Text = "0 ₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "KDV\'li Toplam Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "KDV\'li Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Adet";
            // 
            // KdvList
            // 
            this.KdvList.FormattingEnabled = true;
            this.KdvList.Location = new System.Drawing.Point(177, 51);
            this.KdvList.Name = "KdvList";
            this.KdvList.Size = new System.Drawing.Size(101, 212);
            this.KdvList.TabIndex = 2;
            // 
            // UrunList
            // 
            this.UrunList.FormattingEnabled = true;
            this.UrunList.Location = new System.Drawing.Point(60, 51);
            this.UrunList.Name = "UrunList";
            this.UrunList.Size = new System.Drawing.Size(101, 212);
            this.UrunList.TabIndex = 1;
            // 
            // AdetList
            // 
            this.AdetList.FormattingEnabled = true;
            this.AdetList.Location = new System.Drawing.Point(6, 51);
            this.AdetList.Name = "AdetList";
            this.AdetList.Size = new System.Drawing.Size(39, 212);
            this.AdetList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TVpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTVAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuzPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuzAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPcAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTelAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
                
        private System.Windows.Forms.PictureBox TVpicture;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label Stok;
        private System.Windows.Forms.Label Adet;
        private System.Windows.Forms.NumericUpDown NumericTVAdet;
        private System.Windows.Forms.Label TvFiyat;
        private System.Windows.Forms.Label TvStok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BuzPicture;
        private System.Windows.Forms.Label BuzStok;
        private System.Windows.Forms.Label BuzFiyat;
        private System.Windows.Forms.NumericUpDown NumericBuzAdet;
        private System.Windows.Forms.Label Adet2;
        private System.Windows.Forms.Label Stok2;
        private System.Windows.Forms.Label Fiyat2;
        private System.Windows.Forms.Label PcStok;
        private System.Windows.Forms.Label PcFiyat;
        private System.Windows.Forms.NumericUpDown NumericPcAdet;
        private System.Windows.Forms.Label Adet3;
        private System.Windows.Forms.Label Stok3;
        private System.Windows.Forms.Label Fiyat3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TelStok;
        private System.Windows.Forms.Label TelFiyat;
        private System.Windows.Forms.NumericUpDown NumericTelAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox KdvList;
        private System.Windows.Forms.ListBox UrunList;
        private System.Windows.Forms.ListBox AdetList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ToplamFiyat;
        private System.Windows.Forms.Button button2;
    }
}

