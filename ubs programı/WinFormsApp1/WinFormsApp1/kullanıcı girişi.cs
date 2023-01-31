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
    public partial class kullanıcı_girişi : Form
    {
        public kullanıcı_girişi()
        {
            InitializeComponent();
        }
     

        SqlConnection bag = new SqlConnection(@"Data Source=LAPTOP-J7IJOGQ4;Initial Catalog=gp_proje;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

           


        }
        public static int depid = 0;
        public static int titleid = 0;
        private void kullanıcı_girişi_Load(object sender, EventArgs e)
        {
           

            bag.Open();
            SqlCommand komut = new SqlCommand("select * from users where   ='" +Form1. userid + "'", bag);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                label1.Text = dr["name"].ToString();
                label2.Text = dr["name2"].ToString();
                label3.Text = dr["surname"].ToString();
                depid = Convert.ToInt32( dr["dep_id"]);
                titleid = Convert.ToInt32(dr["title_id"]);

            }
            dr.Close();
          

           
            SqlCommand komut2 = new SqlCommand("select * from dep where dep_id  ='" + Form1.depid + "'", bag);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label4.Text = dr2["dep"].ToString();
            }
            dr2.Close();


            SqlCommand komut3 = new SqlCommand("select * from title where titl_id ='" + Form1.titleid + "'", bag);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label5.Text = dr3["title"].ToString();
            }
            dr3.Close();
          
            bag.Close();

            //pictureBox1.ImageLocation = "https://salihlimyo.mcbu.edu.tr/db_images/site_214/web/qzgbo4cl.jpg";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
