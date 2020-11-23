namespace Odev
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResimKutusu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisbuton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.puan = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sure = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.yenioyunbuton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.organikBar = new System.Windows.Forms.ProgressBar();
            this.organikBosaltButon = new System.Windows.Forms.Button();
            this.liste1 = new System.Windows.Forms.ListBox();
            this.organikButon = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.kagitBar = new System.Windows.Forms.ProgressBar();
            this.kagitBosaltButon = new System.Windows.Forms.Button();
            this.liste2 = new System.Windows.Forms.ListBox();
            this.kagitButon = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.camBar = new System.Windows.Forms.ProgressBar();
            this.camBosaltButon = new System.Windows.Forms.Button();
            this.liste3 = new System.Windows.Forms.ListBox();
            this.camButon = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.metalBar = new System.Windows.Forms.ProgressBar();
            this.metalBosaltButon = new System.Windows.Forms.Button();
            this.liste4 = new System.Windows.Forms.ListBox();
            this.metalButon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ResimKutusu);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 193);
            this.panel1.TabIndex = 1;
            // 
            // ResimKutusu
            // 
            this.ResimKutusu.Location = new System.Drawing.Point(13, 17);
            this.ResimKutusu.Margin = new System.Windows.Forms.Padding(4);
            this.ResimKutusu.Name = "ResimKutusu";
            this.ResimKutusu.Size = new System.Drawing.Size(197, 158);
            this.ResimKutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimKutusu.TabIndex = 0;
            this.ResimKutusu.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cikisbuton);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.yenioyunbuton);
            this.panel2.Location = new System.Drawing.Point(16, 215);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 373);
            this.panel2.TabIndex = 4;
            // 
            // cikisbuton
            // 
            this.cikisbuton.BackColor = System.Drawing.Color.Teal;
            this.cikisbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisbuton.Location = new System.Drawing.Point(24, 303);
            this.cikisbuton.Margin = new System.Windows.Forms.Padding(4);
            this.cikisbuton.Name = "cikisbuton";
            this.cikisbuton.Size = new System.Drawing.Size(176, 53);
            this.cikisbuton.TabIndex = 3;
            this.cikisbuton.Text = "ÇIKIŞ";
            this.cikisbuton.UseVisualStyleBackColor = false;
            this.cikisbuton.Click += new System.EventHandler(this.cikisbuton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aqua;
            this.panel5.Controls.Add(this.puan);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(13, 209);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 89);
            this.panel5.TabIndex = 2;
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.puan.Location = new System.Drawing.Point(72, 36);
            this.puan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(36, 39);
            this.puan.TabIndex = 1;
            this.puan.Text = "0";
            this.puan.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 32);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(63, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PUAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Controls.Add(this.sure);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(13, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 95);
            this.panel3.TabIndex = 1;
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.Location = new System.Drawing.Point(77, 43);
            this.sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(36, 39);
            this.sure.TabIndex = 1;
            this.sure.Text = "0";
            this.sure.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 32);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(63, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SÜRE";
            // 
            // yenioyunbuton
            // 
            this.yenioyunbuton.BackColor = System.Drawing.Color.Teal;
            this.yenioyunbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenioyunbuton.Location = new System.Drawing.Point(13, 16);
            this.yenioyunbuton.Margin = new System.Windows.Forms.Padding(4);
            this.yenioyunbuton.Name = "yenioyunbuton";
            this.yenioyunbuton.Size = new System.Drawing.Size(197, 73);
            this.yenioyunbuton.TabIndex = 0;
            this.yenioyunbuton.Text = "YENİ OYUN";
            this.yenioyunbuton.UseVisualStyleBackColor = false;
            this.yenioyunbuton.Click += new System.EventHandler(this.yenioyunbuton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(255, 15);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(371, 36);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATIK KUTULARI";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.organikBar);
            this.panel8.Controls.Add(this.organikBosaltButon);
            this.panel8.Controls.Add(this.liste1);
            this.panel8.Controls.Add(this.organikButon);
            this.panel8.Location = new System.Drawing.Point(255, 58);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 257);
            this.panel8.TabIndex = 5;
            // 
            // organikBar
            // 
            this.organikBar.Location = new System.Drawing.Point(7, 189);
            this.organikBar.Name = "organikBar";
            this.organikBar.Size = new System.Drawing.Size(169, 24);
            this.organikBar.TabIndex = 3;
            // 
            // organikBosaltButon
            // 
            this.organikBosaltButon.Location = new System.Drawing.Point(7, 220);
            this.organikBosaltButon.Margin = new System.Windows.Forms.Padding(4);
            this.organikBosaltButon.Name = "organikBosaltButon";
            this.organikBosaltButon.Size = new System.Drawing.Size(171, 33);
            this.organikBosaltButon.TabIndex = 2;
            this.organikBosaltButon.Text = "BOŞALT";
            this.organikBosaltButon.UseVisualStyleBackColor = true;
            this.organikBosaltButon.Click += new System.EventHandler(this.organikBosaltButon_Click);
            // 
            // liste1
            // 
            this.liste1.FormattingEnabled = true;
            this.liste1.ItemHeight = 16;
            this.liste1.Location = new System.Drawing.Point(7, 50);
            this.liste1.Margin = new System.Windows.Forms.Padding(4);
            this.liste1.Name = "liste1";
            this.liste1.Size = new System.Drawing.Size(169, 132);
            this.liste1.TabIndex = 1;
            // 
            // organikButon
            // 
            this.organikButon.Location = new System.Drawing.Point(7, 10);
            this.organikButon.Margin = new System.Windows.Forms.Padding(4);
            this.organikButon.Name = "organikButon";
            this.organikButon.Size = new System.Drawing.Size(171, 33);
            this.organikButon.TabIndex = 0;
            this.organikButon.Text = "ORGANİK ATIK";
            this.organikButon.UseVisualStyleBackColor = true;
            this.organikButon.Click += new System.EventHandler(this.organikButon_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Teal;
            this.panel9.Controls.Add(this.kagitBar);
            this.panel9.Controls.Add(this.kagitBosaltButon);
            this.panel9.Controls.Add(this.liste2);
            this.panel9.Controls.Add(this.kagitButon);
            this.panel9.Location = new System.Drawing.Point(444, 58);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(181, 257);
            this.panel9.TabIndex = 6;
            // 
            // kagitBar
            // 
            this.kagitBar.Location = new System.Drawing.Point(7, 189);
            this.kagitBar.Name = "kagitBar";
            this.kagitBar.Size = new System.Drawing.Size(169, 24);
            this.kagitBar.TabIndex = 4;
            // 
            // kagitBosaltButon
            // 
            this.kagitBosaltButon.Location = new System.Drawing.Point(7, 220);
            this.kagitBosaltButon.Margin = new System.Windows.Forms.Padding(4);
            this.kagitBosaltButon.Name = "kagitBosaltButon";
            this.kagitBosaltButon.Size = new System.Drawing.Size(171, 33);
            this.kagitBosaltButon.TabIndex = 2;
            this.kagitBosaltButon.Text = "BOŞALT";
            this.kagitBosaltButon.UseVisualStyleBackColor = true;
            this.kagitBosaltButon.Click += new System.EventHandler(this.kagitBosaltButon_Click);
            // 
            // liste2
            // 
            this.liste2.FormattingEnabled = true;
            this.liste2.ItemHeight = 16;
            this.liste2.Location = new System.Drawing.Point(7, 50);
            this.liste2.Margin = new System.Windows.Forms.Padding(4);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(169, 132);
            this.liste2.TabIndex = 1;
            // 
            // kagitButon
            // 
            this.kagitButon.Location = new System.Drawing.Point(7, 10);
            this.kagitButon.Margin = new System.Windows.Forms.Padding(4);
            this.kagitButon.Name = "kagitButon";
            this.kagitButon.Size = new System.Drawing.Size(171, 33);
            this.kagitButon.TabIndex = 0;
            this.kagitButon.Text = "KAĞIT";
            this.kagitButon.UseVisualStyleBackColor = true;
            this.kagitButon.Click += new System.EventHandler(this.kagitButon_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Teal;
            this.panel10.Controls.Add(this.camBar);
            this.panel10.Controls.Add(this.camBosaltButon);
            this.panel10.Controls.Add(this.liste3);
            this.panel10.Controls.Add(this.camButon);
            this.panel10.Location = new System.Drawing.Point(255, 331);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(181, 257);
            this.panel10.TabIndex = 6;
            // 
            // camBar
            // 
            this.camBar.Location = new System.Drawing.Point(7, 187);
            this.camBar.Name = "camBar";
            this.camBar.Size = new System.Drawing.Size(169, 24);
            this.camBar.TabIndex = 4;
            // 
            // camBosaltButon
            // 
            this.camBosaltButon.Location = new System.Drawing.Point(7, 220);
            this.camBosaltButon.Margin = new System.Windows.Forms.Padding(4);
            this.camBosaltButon.Name = "camBosaltButon";
            this.camBosaltButon.Size = new System.Drawing.Size(171, 33);
            this.camBosaltButon.TabIndex = 2;
            this.camBosaltButon.Text = "BOŞALT";
            this.camBosaltButon.UseVisualStyleBackColor = true;
            this.camBosaltButon.Click += new System.EventHandler(this.camBosaltButon_Click);
            // 
            // liste3
            // 
            this.liste3.FormattingEnabled = true;
            this.liste3.ItemHeight = 16;
            this.liste3.Location = new System.Drawing.Point(7, 50);
            this.liste3.Margin = new System.Windows.Forms.Padding(4);
            this.liste3.Name = "liste3";
            this.liste3.Size = new System.Drawing.Size(169, 132);
            this.liste3.TabIndex = 1;
            // 
            // camButon
            // 
            this.camButon.Location = new System.Drawing.Point(7, 10);
            this.camButon.Margin = new System.Windows.Forms.Padding(4);
            this.camButon.Name = "camButon";
            this.camButon.Size = new System.Drawing.Size(171, 33);
            this.camButon.TabIndex = 0;
            this.camButon.Text = "CAM";
            this.camButon.UseVisualStyleBackColor = true;
            this.camButon.Click += new System.EventHandler(this.camButon_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Teal;
            this.panel11.Controls.Add(this.metalBar);
            this.panel11.Controls.Add(this.metalBosaltButon);
            this.panel11.Controls.Add(this.liste4);
            this.panel11.Controls.Add(this.metalButon);
            this.panel11.Location = new System.Drawing.Point(444, 331);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(181, 257);
            this.panel11.TabIndex = 7;
            // 
            // metalBar
            // 
            this.metalBar.Location = new System.Drawing.Point(9, 187);
            this.metalBar.Name = "metalBar";
            this.metalBar.Size = new System.Drawing.Size(169, 24);
            this.metalBar.TabIndex = 4;
            // 
            // metalBosaltButon
            // 
            this.metalBosaltButon.Location = new System.Drawing.Point(7, 220);
            this.metalBosaltButon.Margin = new System.Windows.Forms.Padding(4);
            this.metalBosaltButon.Name = "metalBosaltButon";
            this.metalBosaltButon.Size = new System.Drawing.Size(171, 33);
            this.metalBosaltButon.TabIndex = 2;
            this.metalBosaltButon.Text = "BOŞALT";
            this.metalBosaltButon.UseVisualStyleBackColor = true;
            this.metalBosaltButon.Click += new System.EventHandler(this.metalBosaltButon_Click);
            // 
            // liste4
            // 
            this.liste4.FormattingEnabled = true;
            this.liste4.ItemHeight = 16;
            this.liste4.Location = new System.Drawing.Point(7, 50);
            this.liste4.Margin = new System.Windows.Forms.Padding(4);
            this.liste4.Name = "liste4";
            this.liste4.Size = new System.Drawing.Size(169, 132);
            this.liste4.TabIndex = 1;
            // 
            // metalButon
            // 
            this.metalButon.Location = new System.Drawing.Point(7, 10);
            this.metalButon.Margin = new System.Windows.Forms.Padding(4);
            this.metalButon.Name = "metalButon";
            this.metalButon.Size = new System.Drawing.Size(171, 33);
            this.metalButon.TabIndex = 0;
            this.metalButon.Text = "METAL";
            this.metalButon.UseVisualStyleBackColor = true;
            this.metalButon.Click += new System.EventHandler(this.metalButon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(637, 601);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ResimKutusu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yenioyunbuton;
        private System.Windows.Forms.Button cikisbuton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button organikBosaltButon;
        private System.Windows.Forms.ListBox liste1;
        private System.Windows.Forms.Button organikButon;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button kagitBosaltButon;
        private System.Windows.Forms.ListBox liste2;
        private System.Windows.Forms.Button kagitButon;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button camBosaltButon;
        private System.Windows.Forms.ListBox liste3;
        private System.Windows.Forms.Button camButon;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ListBox liste4;
        private System.Windows.Forms.Button metalButon;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Button metalBosaltButon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar organikBar;
        private System.Windows.Forms.ProgressBar kagitBar;
        private System.Windows.Forms.ProgressBar camBar;
        private System.Windows.Forms.ProgressBar metalBar;
    }
}

