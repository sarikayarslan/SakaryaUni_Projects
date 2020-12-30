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
    public partial class MagazaForm : Form
    {
        public MagazaForm()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysproje; userID=postgres; password=123456");

        private void magazacieklebuton_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = eklemagazaciadtextbox.Text; ;
                string username = eklemagazaciusernametextbox.Text;
                string sifre = eklemagazaciupasswordtextbox.Text;
                bool yetkili;
                int magazaid = Int32.Parse(eklemagazacimagazaidtextbox.Text);
                if (yetkidurumumagazacicheck.Checked == true) //Eğer checkbox seçiliyse
                {
                    yetkili = true;
                }
                else
                {
                    yetkili = false;

                }

                baglanti.Open();
                NpgsqlCommand komut9 = new NpgsqlCommand("select magazaciEkle(@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut9.Parameters.AddWithValue("@p1", isim);
                komut9.Parameters.AddWithValue("@p2", username);
                komut9.Parameters.AddWithValue("@p3", sifre);
                komut9.Parameters.AddWithValue("@p4", yetkili);
                komut9.Parameters.AddWithValue("@p5", magazaid);
                komut9.ExecuteNonQuery();
                MessageBox.Show("Mağazacı Ekleme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Girdiğin Bilgileri Kontrol Et. (Boş Kutu Kalmasın)");
            }
         
        }

        private void magazacisilbuton_Click(object sender, EventArgs e)
        {
            try
            {
                int silid = Int32.Parse(magazacisiltextbox.Text);
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("select magazaciSil(@p1)", baglanti);
                komut5.Parameters.AddWithValue("@p1", silid);
                komut5.ExecuteNonQuery();
                MessageBox.Show("Mağazacı Silme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Böyle Bir İd Hatırlamıyorum.");
            }

        }

        private void magazacilistbuton_Click(object sender, EventArgs e)
        {
            string sorguMagazaci = "select * from magazaci";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorguMagazaci, baglanti);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);
            dataGridView1.DataSource = ds10.Tables[0];
        }

        private void magazaeklebuton_Click(object sender, EventArgs e)
        {
            string magazaisim = magazaekleisimtextbox.Text;
            string magazail = magazaekleiltextbox.Text;
            if (magazaisim != "" && magazail !="")
            {
            baglanti.Open();
            NpgsqlCommand komut11 = new NpgsqlCommand("call magaza_ekle(@p1,@p2)", baglanti);
            komut11.Parameters.AddWithValue("@p1", magazaisim);
            komut11.Parameters.AddWithValue("@p2", magazail);
            komut11.ExecuteNonQuery();
            MessageBox.Show("Mağaza Ekleme İşlemi Başarıyla Gerçekleşti...");
            baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şu Kutuları Tam Doldurur Musun?");
            }
        }

        private void depomagazabuton_Click(object sender, EventArgs e)
        {
            string sorguMagaza = "select * from magaza";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorguMagaza, baglanti);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);
            dataGridView1.DataSource = ds10.Tables[0];
        }

        private void magazasilbuton_Click(object sender, EventArgs e)
        {
            try
            {
                int silid = Int32.Parse(magazasiltextbox.Text);
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("call magaza_sil(@p1)", baglanti);
                komut5.Parameters.AddWithValue("@p1", silid);
                komut5.ExecuteNonQuery();
                MessageBox.Show("Mağaza Silme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bu İd'ye Ait Bilgi Bulunmuyor");
            }
           
        }

        private void magazaguncellebuton_Click(object sender, EventArgs e)
        {
            try
            {
                int guncelleid = Int32.Parse(magazaguncelletextbox.Text);
                string isim = magazaekleisimtextbox.Text;
                string il = magazaekleiltextbox.Text;

                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("select magazaguncelle(@p1,@p2,@p3)", baglanti);
                komut11.Parameters.AddWithValue("@p1", guncelleid);
                komut11.Parameters.AddWithValue("@p2", isim);
                komut11.Parameters.AddWithValue("@p3", il);
                komut11.ExecuteNonQuery();
                MessageBox.Show("Mağaza Güncellendi");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Kutuları Doğru Doldurun");
            }
            
        }

        private void guncellemagazacibuton_Click(object sender, EventArgs e)
        {
            try
            {
                if (guncellecheckbox.Checked)
                {
                    int guncelleid = Int32.Parse(guncellemagazaciidtextbox.Text);
                    string isim = eklemagazaciadtextbox.Text; ;
                    string username = eklemagazaciusernametextbox.Text;
                    string sifre = eklemagazaciupasswordtextbox.Text;
                    bool yetkili;
                    if (yetkidurumumagazacicheck.Checked == true) //Eğer checkbox seçiliyse
                    {
                        yetkili = true;
                    }
                    else
                    {
                        yetkili = false;

                    }
                    baglanti.Open();
                    NpgsqlCommand komut12 = new NpgsqlCommand("select magazaciguncelle(@p5,@p1,@p2,@p3,@p4)", baglanti);
                    komut12.Parameters.AddWithValue("@p1", isim);
                    komut12.Parameters.AddWithValue("@p2", username);
                    komut12.Parameters.AddWithValue("@p3", sifre);
                    komut12.Parameters.AddWithValue("@p4", yetkili);
                    komut12.Parameters.AddWithValue("@p5", guncelleid);
                    komut12.ExecuteNonQuery();
                    MessageBox.Show("Mağazacı Güncellendi");
                    baglanti.Close();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Kutuları Düzgün Doldurman İçin Oraya Koyduk.");
            }
           
        }



        private void guncellecheckbox_CheckedChanged_1(object sender, EventArgs e)
        {

            if (guncellecheckbox.Checked == true) //Eğer checkbox seçiliyse
            {
                eklemagazacimagazaidtextbox.Enabled = false;
                magazacieklebuton.Enabled = false;
                guncellemagazacibuton.Enabled = true;
                magazaeklebuton.Enabled = false;
                magazaguncellebuton.Enabled = true;
                guncellemagazaciidtextbox.Enabled = true;
                magazaguncelletextbox.Enabled = true;
            }
            else
            {
                magazaguncelletextbox.Enabled = false;
                guncellemagazaciidtextbox.Enabled = false;
                magazaguncellebuton.Enabled = false;
                magazaeklebuton.Enabled = true;
                guncellemagazacibuton.Enabled = false;
                magazacieklebuton.Enabled = true;
                eklemagazacimagazaidtextbox.Enabled = true;
            }
        }
    }
}
