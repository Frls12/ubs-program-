using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.IO;


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        public static SqlConnection bag = new SqlConnection("Data Source=LAPTOP-J7IJOGQ4;Initial Catalog=gp_proje;Integrated Security=True");
        public static string imgyol;
        public Form2()
        {
            InitializeComponent();
        }
        public static SqlCommand cmd;// cmd nesnesi
        public static TextBox[] kayıt = new TextBox[5];
        public static ComboBox[] kayıt2 = new ComboBox[2];
        public static MaskedTextBox[] kayıt3 = new MaskedTextBox[2];
        public static RichTextBox[] kayıt4 = new RichTextBox[1];
        private void Form2_Load(object sender, EventArgs e)
        {
            // veri çekme kısmı
                
                //textbox
                kayıt[0] = textBox1;
                kayıt[1] = textBox2;
                kayıt[2] = textBox3;
                kayıt[3] = textBox4;
                kayıt[4] = txtmail;
                //combobox
                kayıt2[0] = comboBox1;
                kayıt2[1] = comboBox2;
                // masktxtbox
                kayıt3[0] = maskedTextBox1;
                kayıt3[1] = maskedTextBox2;
                //richtxtbox
                kayıt4[0] = richTextBox1;
               
            // ilk önce ıd sını çekip sonra isim olarak çekmek için  
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from dep", bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["dep"]);

            }
            read.Close();
            // ilk önce ıd sını çekip sonra isim olarak çekmek için  
            SqlCommand komut2 = new SqlCommand("select * from title", bag);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                comboBox2.Items.Add(read2["title"]);

            }
            read2.Close();
            bag.Close();

        }//combobox çekme

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//gereksiz



        bool durum = false;

        void tekrar()
        {
            durum = false;
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from users  where mail='" + txtmail.Text + "'", bag);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                /*SqlCommand komut1 = new SqlCommand("select * from users where acd_id = 3"); //aktiflik sorgu
                if (dr.Read())
                {
                    durum = true;
                }*/
            }

            dr.Close();
            bag.Close();
        }//aynı maille birden fazla kaydolmayı engelliyor



        private void button1_Click(object sender, EventArgs e)

        {
           ;
            bool tb1 = false;
            bool tb2 = false;
            bool tb3 = false;
            bool tb4 = false;
            bool tb5 = false;
            bool mtb = false;
            bool mtb2 = false;
            bool rtb = false;
            bool cmb = false;
            bool cmb2 = false;

            if (textBox1.Text != "")
            {
                tb1 = true;
            }
            if (textBox2.Text != "")
            {
                tb2 = true;
            }
            if (textBox3.Text != "")
            {
                tb3 = true;
            }
            if (textBox4.Text != "")
            {
                tb4 = true;
            }
            if (txtmail.Text != "")
            {
                tb5 = true;
            }
            if (maskedTextBox1.Text != "")
            {
                mtb = true;
            }
            if (richTextBox1.Text != "")
            {
                rtb = true;
            }
            if (comboBox1.Text != "")
            {
                cmb = true;
            }
            if (comboBox2.Text != "")
            {
                cmb2 = true;
            }
            if (maskedTextBox2.Text != "")
            {
                mtb2 = true;
            }

            if (tb1 && tb2 && tb3 && tb4 && tb5 && mtb && mtb2 && rtb && cmb && cmb2 == true)
            {
                tekrar();//mail tekrarı
                if (durum == false)
                {
                        bag.Open();
                        string srgmail = "SELECT *FROM  users  mail ";//maili sistemde varsa kaydet                       
                        cmd = new SqlCommand(srgmail, bag);
                        SqlDataReader dr = cmd.ExecuteReader();



                    while (dr.Read())
                        {


                            if (txtmail.Text == dr["mail"].ToString())
                            {

                            }








                        }


                        dr.Close();

                        bag.Close();
                    
                     

                    sendmail();

                    kayıt_doğrulama kytfrm = new kayıt_doğrulama();// sayfa yönlendirme
                    kytfrm.ShowDialog();
                    this.Hide();








                }
                else
                {
                    MessageBox.Show("Bu e posta daha önce kaydolmuştur.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }




            }
            else
                MessageBox.Show("boş alan");

            
                
        }
        public static void sendmail()
        {
            Random random = new Random();
            int rand = random.Next(10000, 99999);




            SmtpClient kullanıcı = new SmtpClient();

            kullanıcı.Credentials = new NetworkCredential("gpproje2021@gmail.com", "gp1212gp");
            kullanıcı.Port = 587;
            kullanıcı.Host = "smtp.gmail.com";
            kullanıcı.EnableSsl = true;

            MailMessage mail = new MailMessage();

            mail.CC.Add("kmlsnr12@gmail.com");
            mail.From = new MailAddress("gpproje2021@gmail.com", "CBU Salihli MYÖ");
            mail.Subject = "kayıt onaylama";
            mail.Body = "şifre yenileme kodunuz =" + rand;
            kullanıcı.Send(mail);

            rnds = rand.ToString();






        }
        public static string rnds = "";

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim seç"; 
            openFileDialog1.Filter = "jpeg dosyaları (*.jpeg) |*.jpeg| jpg dosyaları (*.jpg)|*.jpg| png dosyaları(*.png)|*.png| gif dosyaları(*.gif)|*.gif   ";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imgyol = openFileDialog1.FileName;
            }
        }
    }

}
