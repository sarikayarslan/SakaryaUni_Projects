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
    public partial class DepoForm : Form
    {
        public DepoForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysproje; userID=postgres; password=123456");

        private void depocueklebuton_Click(object sender, EventArgs e)
        {
            try
            {

                string isim = ekledepocuadtextbox.Text; ;
                string username = ekledepocuusernametextbox.Text;
                string sifre = ekledepocupasswordtextbox.Text;
                bool yetkili;
                int depoid = Int32.Parse(ekledepocudepoidtextbox.Text);
                if (yetkidurumucheck.Checked == true) //Eğer checkbox seçiliyse
                {
                    yetkili = true;
                }
                else
                {
                    yetkili = false;

                }

                baglanti.Open();
                NpgsqlCommand komut9 = new NpgsqlCommand("select depocuEkle(@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut9.Parameters.AddWithValue("@p1", isim);
                komut9.Parameters.AddWithValue("@p2", username);
                komut9.Parameters.AddWithValue("@p3", sifre);
                komut9.Parameters.AddWithValue("@p4", yetkili);
                komut9.Parameters.AddWithValue("@p5", depoid);
                komut9.ExecuteNonQuery();
                MessageBox.Show("Depocu Ekleme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bütün Bilgileri Girdiğinden Emin Ol");
                
            }

        }

        private void depoculistbuton_Click(object sender, EventArgs e)
        {
            string sorguDepocu = "select * from depocu";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorguDepocu, baglanti);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);
            dataGridView1.DataSource = ds10.Tables[0];
        }

        private void depocusilbuton_Click(object sender, EventArgs e)
        {
            try
            {
                int silid = Int32.Parse(depocusiltextbox.Text);
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("select * from depocuSil(@p1)", baglanti);
                komut5.Parameters.AddWithValue("@p1", silid);
                komut5.ExecuteNonQuery();
                MessageBox.Show("Depocu Silme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Böyle Bir Id Hatırlamıyorum.");

            }
          
        }

        private void depomagazabuton_Click(object sender, EventArgs e)
        {

            string sorguDepo = "select * from depo";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorguDepo, baglanti);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);
            dataGridView1.DataSource = ds10.Tables[0];
        }

 
 

        private void deposilbuton_Click(object sender, EventArgs e)
        {
            try
            {
                int silid = Int32.Parse(deposiltextbox.Text);
                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("call depo_sil(@p1)", baglanti);
                komut11.Parameters.AddWithValue("@p1", silid);
                komut11.ExecuteNonQuery();
                MessageBox.Show("Depo Silme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" Böyle Bir İd Hatırlamıyorum.");
            }
           
        }

        private void depoeklebuton_Click(object sender, EventArgs e)
        {
            string depoisim = depoekleisimtextbox.Text;
            string depoil = depoekleiltextbox.Text;
            if (depoisim != "" && depoil !="")
            {
                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("call depo_ekle(@p1,@p2)", baglanti);
                komut11.Parameters.AddWithValue("@p1", depoisim);
                komut11.Parameters.AddWithValue("@p2", depoil);
                komut11.ExecuteNonQuery();
                MessageBox.Show("Depo Ekleme İşlemi Başarıyla Gerçekleşti...");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Bilgileri de Mi Ben Gireyim? Biraz Hızlı Ol");
            }
           
        }

        private void DEPOguncellebuton_Click(object sender, EventArgs e)
        {
            try
            {
                int guncelleid = Int32.Parse(depoguncelletextbox.Text);
                string isim = depoekleisimtextbox.Text;
                string il = depoekleiltextbox.Text;

                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("select depoguncelle(@p1,@p2,@p3)", baglanti);
                komut11.Parameters.AddWithValue("@p1", guncelleid);
                komut11.Parameters.AddWithValue("@p2", isim);
                komut11.Parameters.AddWithValue("@p3", il);
                komut11.ExecuteNonQuery();
                MessageBox.Show("Mağaza Güncellendi");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler Yanlış Gidiyor. Formu Kontrol Et");
            }

        }


            private void guncellecheckbox_CheckedChanged(object sender, EventArgs e)
            {
                if (guncellecheckbox.Checked == true) //Eğer checkbox seçiliyse
                {
                ekledepocudepoidtextbox.Enabled = false;
                depocueklebuton.Enabled = false;
                guncelledepocubuton.Enabled = true;
                depoeklebuton.Enabled = false;
                DEPOguncellebuton.Enabled = true;
                guncelledepocuidtextbox.Enabled = true;
                depoguncelletextbox.Enabled = true;
                }
                else
                {
                depoguncelletextbox.Enabled = false;
                guncelledepocuidtextbox.Enabled = false;
                DEPOguncellebuton.Enabled = false;
                depoeklebuton.Enabled = true;
                guncelledepocubuton.Enabled = false;
                depocueklebuton.Enabled = true;
                ekledepocudepoidtextbox.Enabled = true;
                }
            }

        private void guncelledepocubuton_Click(object sender, EventArgs e)
        {
            try
            {

                if (guncellecheckbox.Checked)
                {

                    int guncelleid = Int32.Parse(guncelledepocuidtextbox.Text);
                    string isim = ekledepocuadtextbox.Text; ;
                    string username = ekledepocuusernametextbox.Text;
                    string sifre = ekledepocupasswordtextbox.Text;
                    bool yetkili;
                    if (yetkidurumucheck.Checked == true) //Eğer checkbox seçiliyse
                    {
                        yetkili = true;
                    }
                    else
                    {
                        yetkili = false;

                    }

                    baglanti.Open();
                    NpgsqlCommand komut12 = new NpgsqlCommand("select depocuguncelle(@p5,@p1,@p2,@p3,@p4)", baglanti);
                    komut12.Parameters.AddWithValue("@p1", isim);
                    komut12.Parameters.AddWithValue("@p2", username);
                    komut12.Parameters.AddWithValue("@p3", sifre);
                    komut12.Parameters.AddWithValue("@p4", yetkili);
                    komut12.Parameters.AddWithValue("@p5", guncelleid);
                    komut12.ExecuteNonQuery();
                    MessageBox.Show("Depocu Güncellendi");
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bütün Kutular Dolu ve Bilgier Doğru Değil Sanırım...");
                
            }
        }
    }
}
