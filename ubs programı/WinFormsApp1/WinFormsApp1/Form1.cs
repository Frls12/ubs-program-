using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
      

        


        public Form1()
        {
            InitializeComponent();
        }


         
        public static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J7IJOGQ4;Initial Catalog=gp_proje;Integrated Security=True");

        bool durum;
        public static int userid;
        public static int depid;
        public static int titleid;
        public static int imagesid;
        public static int acd_id;





        void aktif()
            {
                con.Open();
                SqlCommand komut1 = new SqlCommand("select * from users where acd_id = '" + acd_id + "'", con);
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    durum = false;

                }

                dr1.Close();

                con.Close();



            }
        void denetle()//mail kontrolu
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from users  where mail ='" + txtuser.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                durum = false ;

                userid = Convert.ToInt32(dr["id"]);
                depid = Convert.ToInt32(dr["dep_id"]);
                titleid = Convert.ToInt32(dr["title_id"]);


            }
            dr.Close();
            con.Close();




        }


        private void Login_Click(object sender, EventArgs e)
        {
            denetle();
            if (txtuser.Text != "")
            {
                if (durum == false)
                {
                    
                 

                    password frm = new password();
                    frm.Show();
                    this.Hide();






                }
                else
                {

                    MessageBox.Show("e postanız sisteme kayıtlı degildir. lütfen kaydolun!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    button2.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("lütfen bir e posta giriniz!");            

            }

















        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyUp(object sender, KeyEventArgs e)
        {
           // bool SMTP;
            int i;
            string srgmail = "SELECT *FROM  users  mail ";
            con.Open();
            cmd = new SqlCommand(srgmail, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();

        }

        private void s(object sender, EventArgs e)
        {   
            
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

           






        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

