/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 	SORU_2
**				ÖĞRENCİ ADI............: 	ARSLANCAN SARIKAYA
**				ÖĞRENCİ NUMARASI.......:	B181210052
**                         DERSİN ALINDIĞI GRUP...: D
****************************************************************************/
namespace B181210052_SORU2
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
            this.Tx_XDeger = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tx_YDeger = new System.Windows.Forms.MaskedTextBox();
            this.btn_arkadasmi = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_xdegeri
            // 
            this.Tx_XDeger.Location = new System.Drawing.Point(38, 38);
            this.Tx_XDeger.Mask = "000000000";
            this.Tx_XDeger.Name = "tb_xdegeri";
            this.Tx_XDeger.Size = new System.Drawing.Size(100, 20);
            this.Tx_XDeger.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // tb_ydegeri
            // 
            this.Tx_YDeger.Location = new System.Drawing.Point(38, 64);
            this.Tx_YDeger.Mask = "000000000";
            this.Tx_YDeger.Name = "tb_ydegeri";
            this.Tx_YDeger.Size = new System.Drawing.Size(100, 20);
            this.Tx_YDeger.TabIndex = 2;
            // 
            // btn_arkadasmi
            // 
            this.btn_arkadasmi.Location = new System.Drawing.Point(38, 109);
            this.btn_arkadasmi.Name = "btn_arkadasmi";
            this.btn_arkadasmi.Size = new System.Drawing.Size(100, 29);
            this.btn_arkadasmi.TabIndex = 4;
            this.btn_arkadasmi.Text = "ARKADAS MI?";
            this.btn_arkadasmi.UseVisualStyleBackColor = true;
            this.btn_arkadasmi.Click += new System.EventHandler(this.btn_arkadasmi_Click);
            // 
            // btn_son
            // 
            this.btn_son.Location = new System.Drawing.Point(149, 109);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(82, 29);
            this.btn_son.TabIndex = 5;
            this.btn_son.Text = "SON";
            this.btn_son.UseVisualStyleBackColor = true;
            this.btn_son.Click += new System.EventHandler(this.btn_son_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 187);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.btn_arkadasmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tx_YDeger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tx_XDeger);
            this.Name = "Form1";
            this.Text = "Arkadasini Bul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Tx_XDeger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Tx_YDeger;
        private System.Windows.Forms.Button btn_arkadasmi;
        private System.Windows.Forms.Button btn_son;
    }
}

