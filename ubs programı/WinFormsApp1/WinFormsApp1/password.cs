    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class password : Form
    {
        // SqlCommand cmd2;
        bool durum;
        public password()
        {
            InitializeComponent();
        }
        //baglanti
        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7IJOGQ4;Initial Catalog=gp_proje;Integrated Security=True");

        void denetimpass()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from users  where password='" + Form2.MD5Sifrele(textBox1.Text) + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            dr.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //password dogrsu ise kullanıcı sayfasına giriş
            denetimpass();
            if (textBox1.Text != "")
            {
                
                if (durum == false)
                {
                    /*SqlCommand komut = new SqlCommand("select * from users where rol_id = 1");
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read()) {

                        kullanıcı_girişi frm = new kullanıcı_girişi();
                        frm.Show();
                        this.Hide();
                    }
                    SqlCommand komut1 = new SqlCommand("select * from users where rol_id = 2");
                    SqlDataReader dr1 = komut.ExecuteReader();
                    while (dr.Read())
                    { */

                    admin_ekranı frm = new admin_ekranı();
                        frm.Show();
                        this.Hide();
                    
                   
                }
                else
                {
                    MessageBox.Show("girdiginiz şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("lütfen bir şifre giriniz!");
            }


            


        }
    }
}
