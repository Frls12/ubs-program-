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




    public partial class kayıt_doğrulama : Form
    {



        public kayıt_doğrulama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Form2.rnds == textBox1.Text)
            {

                SqlCommand cmd = new SqlCommand();// veri ekleme


                Form2.bag.Open();
                cmd.Connection = Form2.bag;

                
                /* FileStream filesrm = new FileStream(Form2.imgyol, FileMode.Open, FileAccess.Read);
                BinaryReader binaryrdr = new BinaryReader(filesrm);
                byte[] resim = binaryrdr.ReadBytes((int)filesrm.Length);
                binaryrdr.Close();
                filesrm.Close();

                
                cmd.CommandText=   SqlCommand imgkomut = new SqlCommand   ("insert into image_id(image) values (@image) select scope_identity()");
                cmd.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim; 
                
                //Form2.bag.Close();
                int img = Convert.ToInt32(cmd.ExecuteScalar());
                */

                // masktxtbox telefon çekme kısmı
                cmd.CommandText = "insert into contact(tel,dahili) values (@tel,@dahili) select scope_identity()";

                cmd.Parameters.AddWithValue("@tel", Form2.kayıt3[0].Text);
                cmd.Parameters.AddWithValue("@dahili", Form2.kayıt3[1].Text);

                int a = Convert.ToInt32(cmd.ExecuteScalar());


                //departman 
                cmd.CommandText = "select * from dep where dep = '" + Form2.kayıt2[0].Text + "'";
                string dep_id = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dep_id = dr["dep_id"].ToString();
                }
                dr.Close();

                //title
                cmd.CommandText = "select * from title where title = '" + Form2.kayıt2[1].Text + "'";
                string titl_id = "";
                SqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {

                    titl_id = dr1["titl_id"].ToString();
                }
                dr1.Close();



                // textbox 
                cmd.CommandText = "Update users Set name=@name,name2=@name2,surname=@surname,mail=mail,password=@password,contact_id=@contact_id,adres=@adres,dep_id=@dep_id,title_id=@title_id,acd_id=@acd_id,rol_id =@rol_id Where mail=@mail";
                //"Update users Set(mail,name,name2,surname,password,contact_id,adres,dep_id,title_id,acd_id)values (@mail,@name,@name2,@surname,@password,@contact_id,@adres,@dep_id,@title_id,@acd_id)";

                cmd.Parameters.AddWithValue("mail", Form2.kayıt[4].Text);
                cmd.Parameters.AddWithValue("@name", Form2.kayıt[0].Text);
                cmd.Parameters.AddWithValue("@name2", Form2.kayıt[1].Text);
                cmd.Parameters.AddWithValue("@surname", Form2.kayıt[2].Text);
                cmd.Parameters.AddWithValue("@password", Form2.MD5Sifrele(Form2.kayıt[3].Text));

                cmd.Parameters.AddWithValue("@contact_id", a);
                //richbox
                cmd.Parameters.AddWithValue("@adres", Form2.kayıt4[0].Text);

                cmd.Parameters.AddWithValue("@dep_id", dep_id);

                cmd.Parameters.AddWithValue("@title_id", titl_id);
               // cmd.Parameters.AddWithValue("@acd_id",3);
               // cmd.Parameters.AddWithValue("@rol_id", 1);
               

                // cmd.Parameters.AddWithValue("@image", img);


                cmd.ExecuteNonQuery();
                Form2.bag.Close();
                MessageBox.Show("kaydınız başarıyla gerçekleşmiştir.");


              








            }
            else
            {
                MessageBox.Show("girdiginiz dogrulama kodu yanlış.");
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "gönderilen kodu girin")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;

            }
        }

    }
}
