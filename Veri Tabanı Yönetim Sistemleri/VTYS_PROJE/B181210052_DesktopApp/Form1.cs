using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysproje
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysproje; userID=postgres; password=123456");

        private void button1_Click(object sender, EventArgs e)
        {
        

            string secim = urunlistcombobox.Text;
            switch (secim)
            {
                case "Silinen Ürünler":
                    string sorguSilinen= "select * from silinenurun";
                    NpgsqlDataAdapter da7 = new NpgsqlDataAdapter(sorguSilinen, baglanti);
                    DataSet ds7 = new DataSet();
                    da7.Fill(ds7);
                    dataGridView1.DataSource = ds7.Tables[0];
                    break;

                case "Ekran Kartı":
                    string sorguEkranKarti = "select * from ekrankarti";
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    break;

                case "İşlemci":
                    string sorguIslemci = "select * from islemci";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorguIslemci, baglanti);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];

                    break;
                case "Anakart":
                    string sorguAnakart = "select * from anakart";
                    NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorguAnakart, baglanti);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);
                    dataGridView1.DataSource = ds3.Tables[0];

                    break;
                case "Ram":
                    string sorguRam = "select * from ram";
                    NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorguRam, baglanti);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    dataGridView1.DataSource = ds4.Tables[0];

                    break;
                case "Güç Kaynağı":
                    string sorguGucKaynagi = "select * from guckaynagi";
                    NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(sorguGucKaynagi, baglanti);
                    DataSet ds5 = new DataSet();
                    da5.Fill(ds5);
                    dataGridView1.DataSource = ds5.Tables[0];

                    break;
                case "Depolama":
                    string sorguDepolama = "select * from depolama";
                    NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(sorguDepolama, baglanti);
                    DataSet ds6 = new DataSet();
                    da6.Fill(ds6);
                    dataGridView1.DataSource = ds6.Tables[0];
                    break;

            }

        }

        private void eklebuton_Click(object sender, EventArgs e)
        {
            try
            {
                string urunturu = ekleurunturucombobox.Text;
                string marka = eklemarkatextbox.Text;
                string model = eklemodeltextbox.Text;
                int hamfiyat = Int32.Parse(eklehamfiyattextbox.Text);

                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("select urunEkle(@p1,@p2,@p3,@p4)", baglanti);
                komut1.Parameters.AddWithValue("@p1", urunturu);
                komut1.Parameters.AddWithValue("@p2", marka);
                komut1.Parameters.AddWithValue("@p3", model);
                komut1.Parameters.AddWithValue("@p4", hamfiyat);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Ürün Ekleme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }

            
        }

        private void urunsilbuton_Click(object sender, EventArgs e)
        {
            try
            {
                int silid = Int32.Parse(urunsiltextbox.Text);
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("select * from urunsil(@p1)", baglanti);
                komut5.Parameters.AddWithValue("@p1", silid);
                komut5.ExecuteNonQuery();
                MessageBox.Show("Ürün Silme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ya sen hafızanı kaybettin ya da ben. Böyle bir id bulamadım");
            }

            
        }

        private void DEPObuton_Click(object sender, EventArgs e)
        {
            DepoForm depoForm = new DepoForm();
            depoForm.Show();
        }

        private void MAGAZAbuton_Click(object sender, EventArgs e)
        {
            MagazaForm magazaForm = new MagazaForm();
            magazaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkisizForm yetkisizForm = new YetkisizForm();
            yetkisizForm.Show();
        }
    }
}
