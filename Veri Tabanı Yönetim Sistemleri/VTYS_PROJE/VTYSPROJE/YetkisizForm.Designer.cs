
namespace vtysproje
{
    partial class YetkisizForm
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
            this.urunAraTextBox = new System.Windows.Forms.TextBox();
            this.MagazaAraTextBox = new System.Windows.Forms.TextBox();
            this.DepoAraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunAraButon = new System.Windows.Forms.Button();
            this.depoAraButon = new System.Windows.Forms.Button();
            this.magazaAraButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunlistcombobox = new System.Windows.Forms.ComboBox();
            this.filtreUrunCombo = new System.Windows.Forms.ComboBox();
            this.depoAraCombo = new System.Windows.Forms.ComboBox();
            this.magazaAraCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunAraTextBox
            // 
            this.urunAraTextBox.Location = new System.Drawing.Point(121, 44);
            this.urunAraTextBox.Name = "urunAraTextBox";
            this.urunAraTextBox.Size = new System.Drawing.Size(131, 22);
            this.urunAraTextBox.TabIndex = 0;
            // 
            // MagazaAraTextBox
            // 
            this.MagazaAraTextBox.Location = new System.Drawing.Point(121, 202);
            this.MagazaAraTextBox.Name = "MagazaAraTextBox";
            this.MagazaAraTextBox.Size = new System.Drawing.Size(131, 22);
            this.MagazaAraTextBox.TabIndex = 1;
            // 
            // DepoAraTextBox
            // 
            this.DepoAraTextBox.Location = new System.Drawing.Point(121, 130);
            this.DepoAraTextBox.Name = "DepoAraTextBox";
            this.DepoAraTextBox.Size = new System.Drawing.Size(131, 22);
            this.DepoAraTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Türü:";
            // 
            // urunAraButon
            // 
            this.urunAraButon.Location = new System.Drawing.Point(121, 72);
            this.urunAraButon.Name = "urunAraButon";
            this.urunAraButon.Size = new System.Drawing.Size(131, 32);
            this.urunAraButon.TabIndex = 6;
            this.urunAraButon.Text = "URUN ARA";
            this.urunAraButon.UseVisualStyleBackColor = true;
            this.urunAraButon.Click += new System.EventHandler(this.urunAraButon_Click);
            // 
            // depoAraButon
            // 
            this.depoAraButon.Location = new System.Drawing.Point(121, 158);
            this.depoAraButon.Name = "depoAraButon";
            this.depoAraButon.Size = new System.Drawing.Size(131, 27);
            this.depoAraButon.TabIndex = 7;
            this.depoAraButon.Text = "DEPO ARA";
            this.depoAraButon.UseVisualStyleBackColor = true;
            this.depoAraButon.Click += new System.EventHandler(this.depoAraButon_Click);
            // 
            // magazaAraButon
            // 
            this.magazaAraButon.Location = new System.Drawing.Point(121, 230);
            this.magazaAraButon.Name = "magazaAraButon";
            this.magazaAraButon.Size = new System.Drawing.Size(131, 26);
            this.magazaAraButon.TabIndex = 8;
            this.magazaAraButon.Text = "MAĞAZA ARA";
            this.magazaAraButon.UseVisualStyleBackColor = true;
            this.magazaAraButon.Click += new System.EventHandler(this.magazaAraButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 486);
            this.dataGridView1.TabIndex = 9;
            // 
            // urunlistcombobox
            // 
            this.urunlistcombobox.FormattingEnabled = true;
            this.urunlistcombobox.Items.AddRange(new object[] {
            "Ekran Kartı",
            "İşlemci",
            "Anakart",
            "Ram",
            "Güç Kaynağı",
            "Depolama"});
            this.urunlistcombobox.Location = new System.Drawing.Point(121, 12);
            this.urunlistcombobox.Name = "urunlistcombobox";
            this.urunlistcombobox.Size = new System.Drawing.Size(131, 24);
            this.urunlistcombobox.TabIndex = 10;
            this.urunlistcombobox.Text = "ÜRÜN SEÇ";
            // 
            // filtreUrunCombo
            // 
            this.filtreUrunCombo.FormattingEnabled = true;
            this.filtreUrunCombo.Items.AddRange(new object[] {
            "marka",
            "model"});
            this.filtreUrunCombo.Location = new System.Drawing.Point(12, 42);
            this.filtreUrunCombo.Name = "filtreUrunCombo";
            this.filtreUrunCombo.Size = new System.Drawing.Size(103, 24);
            this.filtreUrunCombo.TabIndex = 11;
            this.filtreUrunCombo.Text = "FİLTRE SEÇ";
            // 
            // depoAraCombo
            // 
            this.depoAraCombo.FormattingEnabled = true;
            this.depoAraCombo.Items.AddRange(new object[] {
            "İl Adi:",
            "Depo Adi:"});
            this.depoAraCombo.Location = new System.Drawing.Point(12, 128);
            this.depoAraCombo.Name = "depoAraCombo";
            this.depoAraCombo.Size = new System.Drawing.Size(103, 24);
            this.depoAraCombo.TabIndex = 12;
            this.depoAraCombo.Text = "FİLTRE SEÇ";
            // 
            // magazaAraCombo
            // 
            this.magazaAraCombo.FormattingEnabled = true;
            this.magazaAraCombo.Items.AddRange(new object[] {
            "İl Adi:",
            "Magaza Adi:"});
            this.magazaAraCombo.Location = new System.Drawing.Point(12, 200);
            this.magazaAraCombo.Name = "magazaAraCombo";
            this.magazaAraCombo.Size = new System.Drawing.Size(103, 24);
            this.magazaAraCombo.TabIndex = 13;
            this.magazaAraCombo.Text = "FİLTRE SEÇ";
            // 
            // YetkisizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 506);
            this.Controls.Add(this.magazaAraCombo);
            this.Controls.Add(this.depoAraCombo);
            this.Controls.Add(this.filtreUrunCombo);
            this.Controls.Add(this.urunlistcombobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.magazaAraButon);
            this.Controls.Add(this.depoAraButon);
            this.Controls.Add(this.urunAraButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepoAraTextBox);
            this.Controls.Add(this.MagazaAraTextBox);
            this.Controls.Add(this.urunAraTextBox);
            this.Name = "YetkisizForm";
            this.Text = "YetkisizForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunAraTextBox;
        private System.Windows.Forms.TextBox MagazaAraTextBox;
        private System.Windows.Forms.TextBox DepoAraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button urunAraButon;
        private System.Windows.Forms.Button depoAraButon;
        private System.Windows.Forms.Button magazaAraButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox urunlistcombobox;
        private System.Windows.Forms.ComboBox filtreUrunCombo;
        private System.Windows.Forms.ComboBox depoAraCombo;
        private System.Windows.Forms.ComboBox magazaAraCombo;
    }
}