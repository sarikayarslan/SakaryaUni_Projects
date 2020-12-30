
namespace vtysproje
{
    partial class LoginSayfasi
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
            this.loginidtextbox = new System.Windows.Forms.TextBox();
            this.loginpasstextbox = new System.Windows.Forms.TextBox();
            this.depologin_buton = new System.Windows.Forms.Button();
            this.magazalogin_buton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginidtextbox
            // 
            this.loginidtextbox.Location = new System.Drawing.Point(165, 60);
            this.loginidtextbox.Name = "loginidtextbox";
            this.loginidtextbox.Size = new System.Drawing.Size(163, 22);
            this.loginidtextbox.TabIndex = 0;
            // 
            // loginpasstextbox
            // 
            this.loginpasstextbox.Location = new System.Drawing.Point(165, 100);
            this.loginpasstextbox.Name = "loginpasstextbox";
            this.loginpasstextbox.PasswordChar = '*';
            this.loginpasstextbox.Size = new System.Drawing.Size(163, 22);
            this.loginpasstextbox.TabIndex = 1;
            // 
            // depologin_buton
            // 
            this.depologin_buton.Location = new System.Drawing.Point(203, 139);
            this.depologin_buton.Name = "depologin_buton";
            this.depologin_buton.Size = new System.Drawing.Size(125, 23);
            this.depologin_buton.TabIndex = 2;
            this.depologin_buton.Text = "DEPO GİRİS";
            this.depologin_buton.UseVisualStyleBackColor = true;
            this.depologin_buton.Click += new System.EventHandler(this.depologin_buton_Click);
            // 
            // magazalogin_buton
            // 
            this.magazalogin_buton.Location = new System.Drawing.Point(72, 139);
            this.magazalogin_buton.Name = "magazalogin_buton";
            this.magazalogin_buton.Size = new System.Drawing.Size(125, 23);
            this.magazalogin_buton.TabIndex = 3;
            this.magazalogin_buton.Text = "MAGAZA GİRİS";
            this.magazalogin_buton.UseVisualStyleBackColor = true;
            this.magazalogin_buton.Click += new System.EventHandler(this.magazaloginbuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(71, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 69);
            this.button1.TabIndex = 43;
            this.button1.Text = "STANDART GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magazalogin_buton);
            this.Controls.Add(this.depologin_buton);
            this.Controls.Add(this.loginpasstextbox);
            this.Controls.Add(this.loginidtextbox);
            this.Name = "LoginSayfasi";
            this.Text = "LoginSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginidtextbox;
        private System.Windows.Forms.TextBox loginpasstextbox;
        private System.Windows.Forms.Button depologin_buton;
        private System.Windows.Forms.Button magazalogin_buton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}