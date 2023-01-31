using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;



namespace WinFormsApp1
{
    public partial class admin_ekranı : Form
    {

        private Button curretButton;
        private Random random;
        private int tempIndex;






        bool kontrol;
        int menu;


        public admin_ekranı()
        {
            InitializeComponent();

            //kontrol = false;
        


            textBox1.Text = text;
            textBox2.Text = text1;
            textBox3.Text = text2;
            textBox4.Text = textmail;

            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);
            textBox2.GotFocus += new EventHandler(textBox2_GotFocus);
            textBox3.GotFocus += new EventHandler(textBox3_GotFocus);
            textBox4.GotFocus += new EventHandler(textBox4_GotFocus);

            random = new Random();

        }
      




        string text = "kullanıcı adı";
        string text1 = "varsa 2. adı";
        string text2= "soyadı";
        string textmail = "e posta";
       
            

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }
        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
            
        }
        private void textBox3_GotFocus(object sender, EventArgs e)
        {
           
            textBox3.Text = "";
            
        }
        private void textBox4_GotFocus(object sender, EventArgs e)
        {
           
            textBox4.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == text)
            {
                textBox1.Text = "";
            }

          
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == text1)
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox3.Text == text2)
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == textmail)
            {
                textBox4.Text = "";
            }



        }
        







        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7IJOGQ4;Initial Catalog=gp_proje;Integrated Security=True");
        private void admin_ekranı_Load(object sender, EventArgs e)
        {
            griddoldur();



        }

       void griddoldur()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select *From users", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
            con.Close();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }


            //kullanıcı ekleme
        private void button2_Click(object sender, EventArgs e)
        {





            SqlCommand  cmd = new SqlCommand();
            /* commant.Open();
             commant.Connection = con;
             commant.CommandText = "insert into ogrenci(name,name2,surname,mail values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
             commant.ExecuteNonQuery(); 
             con.Close();
             griddoldur();*/

            string sorgu = "Insert into users (name,name2,surname,mail) values (@name,@name2,@surname,@mail)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@name2", textBox2.Text);
            cmd.Parameters.AddWithValue("@surname", textBox3.Text);
            //cmd.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@mail", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();



        }
        //kullanıcı güncelleme
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            /*con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update users set name ='" + textBox1.Text + "',name2='" + textBox2.Text + "',surname='" + textBox3.Text + "'mail=" + textBox4.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            */

            string sorgu = "Update users Set name=@name,name2=@name2,surname=@surname,mail=mail Where mail=@mail";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@name2", textBox2.Text);
            cmd.Parameters.AddWithValue("@surname", textBox3.Text);
           // komut.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@mail", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();

        }
        //kullanıcı silme
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from users where mail=" + textBox4.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //panel_logo.BackColor = System.Drawing.Color.FromArgb(4, 55, 74); 
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {
            

            // Desimal Kodu
            //panel_menu.BackColor = System.Drawing.Color.FromArgb(4, 77, 104); 

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(themeColor.ColorList.Count);
            while (tempIndex == index) {  
            

                random.Next(themeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = themeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void Activatebutton(object btnSender)
        {
            if (btnSender != null)
            {
                if (curretButton != null)
                {
                    Disiblebutton();
                    Color color = SelectThemeColor();
                    curretButton = (Button)btnSender;
                    curretButton.BackColor = color;
                    curretButton.ForeColor = Color.White;
                    curretButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }

            }


        }
        private void Disiblebutton()
        {
            foreach (Control ders_btn in panel_menu.Controls)
            {
                if (ders_btn.GetType() == typeof(Button))
                {
                    ders_btn.BackColor = Color.DarkGray;
                    ders_btn.ForeColor = Color.Black;
                    ders_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ders_btn_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void kln_btn_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }
    }
       
    }
















       
    

