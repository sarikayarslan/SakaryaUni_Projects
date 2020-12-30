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
    public partial class LoginSayfasi : Form
    {
        public LoginSayfasi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti2 = new NpgsqlConnection("server=localHost; port=5432; Database=vtysproje; userID=postgres; password=123456");
       

        private void magazaloginbuton_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            baglanti2.Open();
            string _username = loginidtextbox.Text;
            string _password = loginpasstextbox.Text; 
            NpgsqlCommand komut2 = new NpgsqlCommand("select * from magazaci_login(@p1,@p2);", baglanti2);
            komut2.Parameters.AddWithValue("@p1",_username );
            komut2.Parameters.AddWithValue("@p2",_password );


            int result = (int)komut2.ExecuteScalar();
            Console.WriteLine(result);



            if (result==1)
            {
                MessageBox.Show("Hadi gir bakalim iceriye");
                girisForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Instagram bilgilerin degil bana yetkili bilgilerin lazim hadi cabuk ol...");

            }

            baglanti2.Close();
        }

        private void depologin_buton_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            baglanti2.Open();
            string _username = loginidtextbox.Text;
            string _password = loginpasstextbox.Text;
            NpgsqlCommand komut2 = new NpgsqlCommand("select * from depocu_login(@p1,@p2);", baglanti2);
            komut2.Parameters.AddWithValue("@p1", _username);
            komut2.Parameters.AddWithValue("@p2", _password);
            int result = (int)komut2.ExecuteScalar();
            Console.WriteLine(result);



            if (result == 1)
            {
                MessageBox.Show("Hadi gir bakalim iceriye");
                girisForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Instagram bilgilerin degil bana yetkili bilgilerin lazim hadi cabuk ol...");

            }

            baglanti2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YetkisizForm yetkisizForm = new YetkisizForm();
            yetkisizForm.ShowDialog();
        }
    }
}
