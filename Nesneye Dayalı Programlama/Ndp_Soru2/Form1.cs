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


using System;
using System.Drawing;
using System.Windows.Forms;

namespace B181210052_SORU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Listbox oluşturur
        ListBox ListX = new ListBox();
        ListBox ListY = new ListBox();

        //Textbox oluşturur
        TextBox Tx_XToplam = new TextBox();
        TextBox Tx_YToplam = new TextBox();

        //Yazıları oluşturur.
        Label LabelToplam = new Label();
        Label LabelX = new Label();
        Label LabelY = new Label();

        //ARKADAŞ MI BUTONUNA BASILDIĞINDA YAPILACAK İŞLEMLER
        private void btn_arkadasmi_Click(object sender, EventArgs e)
        {

            int XToplam = 0; //X sayısının bölenlerini bu sayıda biriktiririz.
            int YToplam = 0; //Y sayısının bölenlerini bu sayıda biriktiririz.
            int X = 0; //x sayisini tutar
            int Y = 0; // y sayisini tutar

            //Listboxlardaki itemleri temizler bu sayede önceki sayının bölenleri gözükmez.
            ListX.Items.Clear();
            ListY.Items.Clear();
            //X ve Y değerlerinin bulunduğu textboxları kontrol eder
            if (!String.IsNullOrEmpty(Tx_XDeger.Text) && !String.IsNullOrEmpty(Tx_YDeger.Text))
            {
                //Textboxdaki değerleri X ve Y ye göre 
                X = Convert.ToInt32(Tx_XDeger.Text);
                Y = Convert.ToInt32(Tx_YDeger.Text);

                this.Size = new System.Drawing.Size(576, 347);
                //Label X'i ve konumunu oluşturur.
                LabelX.Text = "X";
                this.Controls.Add(LabelX);
                LabelX.Location = new Point(300, 15);

                //Label Y'yi ve konumunu oluşturur.
                LabelY.Text = "Y";
                this.Controls.Add(LabelY);
                LabelY.Location = new Point(450, 15);

                //X'in bölenlerinin olduğu listenin özellikleri
                ListX.Width = 119;
                ListX.Height = 199;
                ListX.Location = new Point(250, 40);
                this.Controls.Add(ListX);

                //Y'nin bölenlerinin olduğu listenin özellikleri
                ListY.Width = 119;
                ListY.Height = 199;
                ListY.Location = new Point(400, 40);
                this.Controls.Add(ListY);

                //X'in toplamını gösteren textbox özellikleri
                Tx_XToplam.Width = 119;
                Tx_XToplam.Height = 20;
                Tx_XToplam.Location = new Point(250, 250);
                this.Controls.Add(Tx_XToplam);

                //y'nin toplamını gösteren textbox özellikleri

                Tx_YToplam.Width = 119;
                Tx_YToplam.Height = 20;
                Tx_YToplam.Location = new Point(400, 250);
                this.Controls.Add(Tx_YToplam);

                //Toplam Yazısınını Özellikleri
                LabelToplam.Text = "Toplamlar";
                LabelToplam.Location = new Point(180, 250);
                this.Controls.Add(LabelToplam);

                //X sayısının tam bölenlerini bulup toplar
                for (int i = 1; i < X; i++)
                {
                    if (X % i == 0)
                    {
                        //Listboxa bölenleri buldukça yazdırır  
                        ListX.Items.Add(i);
                        XToplam += i; //Bölenleri Toplar
                    }
                }

                //Y sayısının tam bölenlerini bulup toplar
                for (int i = 1; i < Y; i++)
                {
                    if (Y % i == 0)
                    {

                        //Listboxa bölenleri buldukça yazdırır
                        ListY.Items.Add(i);
                        YToplam += i; //Bölenleri Toplar
                    }
                }

                //Toplam degerlerini Textboxa yazdırır.
                Tx_XToplam.Text = Convert.ToString(XToplam);
                Tx_YToplam.Text = Convert.ToString(YToplam);
                if (XToplam == Y && YToplam == X)
                {
                    MessageBox.Show(X + " ve " + Y + " Arkadaş Sayılardır");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayıniz");
            }

        }

        //Son butonuna basılınca yapılacakları gösterir
        private void btn_son_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
