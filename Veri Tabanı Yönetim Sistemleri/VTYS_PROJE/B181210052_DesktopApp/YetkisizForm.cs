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
    public partial class YetkisizForm : Form
    {
        public YetkisizForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysproje; userID=postgres; password=123456");

        private void urunAraButon_Click(object sender, EventArgs e)
        {
            string tablo = urunlistcombobox.Text;
            string filtre = filtreUrunCombo.Text;
            string aranacakKelime = urunAraTextBox.Text;
            switch (tablo)
            {
                
                case "Ekran Kartı":
                    
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from ekrankarti where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from ekrankarti where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }
                    break;

                case "İşlemci":
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from islemci where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from islemci where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }

                    break;
                case "Anakart":
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from anakart where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from anakart where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }

                    break;
                case "Ram":
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from ram where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from ram where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }
                    break;
                case "Güç Kaynağı":
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from guckaynagi where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from guckaynagi where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }

                    break;

                case "Depolama":
                    switch (filtre)
                    {
                        case "model":
                            string sorguEkranKarti = "select * from depolama where model like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguEkranKarti, baglanti);

                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            break;

                        case "marka":
                            string sorguEkranKarti2 = "select * from depolama where marka like \'%" + aranacakKelime + "%\'";
                            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter(sorguEkranKarti2, baglanti);

                            DataSet ds14 = new DataSet();
                            da14.Fill(ds14);
                            dataGridView1.DataSource = ds14.Tables[0];
                            break;

                    }
                    break;

            }
            baglanti.Close();
        }

        private void depoAraButon_Click(object sender, EventArgs e)
        {
           string aranacakKelime =DepoAraTextBox.Text;
            string filtre = depoAraCombo.Text;


            switch (filtre)
            {
                case "İl Adi:":
                     string sorguDepo = "select * from depo where il like \'%" + aranacakKelime + "%\'";
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguDepo, baglanti);

                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    break;

                case "Depo Adi:":
                    string sorguDepo2 = "select * from depo where isim like \'%" + aranacakKelime + "%\'";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorguDepo2, baglanti);

                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];
                    break;
            }


           
        }

        private void magazaAraButon_Click(object sender, EventArgs e)
        {
            string aranacakKelime = MagazaAraTextBox.Text;
            string filtre = magazaAraCombo.Text;


            switch (filtre)
            {
                case "İl Adi:":
                    string sorguDepo = "select * from magaza where il like \'%" + aranacakKelime + "%\'";
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorguDepo, baglanti);

                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    break;

                case "Magaza Adi:":
                    string sorguDepo2 = "select * from magaza where isim like \'%" + aranacakKelime + "%\'";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorguDepo2, baglanti);

                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];
                    break;
            }


        }
    }
}
