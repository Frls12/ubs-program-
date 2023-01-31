
namespace WinFormsApp1
{
    partial class admin_ekranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button sil_btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_ekranı));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.Güncelle = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.kln_btn = new System.Windows.Forms.Button();
            this.ders_btn = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sil_btn
            // 
            sil_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sil_btn.Dock = System.Windows.Forms.DockStyle.Top;
            sil_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            sil_btn.FlatAppearance.BorderSize = 0;
            sil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sil_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            sil_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sil_btn.ImageIndex = 6;
            sil_btn.ImageList = this.ımageList1;
            sil_btn.Location = new System.Drawing.Point(0, 180);
            sil_btn.Name = "sil_btn";
            sil_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            sil_btn.Size = new System.Drawing.Size(172, 43);
            sil_btn.TabIndex = 7;
            sil_btn.Text = "   Sil           ";
            sil_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            sil_btn.UseVisualStyleBackColor = true;
            sil_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "5.png");
            this.ımageList1.Images.SetKeyName(1, "42.png");
            this.ımageList1.Images.SetKeyName(2, "pngegg.png");
            this.ımageList1.Images.SetKeyName(3, "pngeg7.png");
            this.ımageList1.Images.SetKeyName(4, "pngegg.png");
            this.ımageList1.Images.SetKeyName(5, "pngegg (1).png");
            this.ımageList1.Images.SetKeyName(6, "pngegg (2).png");
            this.ımageList1.Images.SetKeyName(7, "pngegg (3).png");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(522, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(522, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 29);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(522, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 29);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(522, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 29);
            this.textBox4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(655, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.Location = new System.Drawing.Point(689, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Aktiflik";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkGray;
            this.panel_menu.Controls.Add(this.Güncelle);
            this.panel_menu.Controls.Add(sil_btn);
            this.panel_menu.Controls.Add(this.ekle_btn);
            this.panel_menu.Controls.Add(this.kln_btn);
            this.panel_menu.Controls.Add(this.ders_btn);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(172, 435);
            this.panel_menu.TabIndex = 10;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // Güncelle
            // 
            this.Güncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Güncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Güncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Güncelle.FlatAppearance.BorderSize = 0;
            this.Güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Güncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Güncelle.ImageIndex = 7;
            this.Güncelle.ImageList = this.ımageList1;
            this.Güncelle.Location = new System.Drawing.Point(0, 223);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(172, 43);
            this.Güncelle.TabIndex = 8;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ekle_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekle_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ekle_btn.FlatAppearance.BorderSize = 0;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle_btn.ImageIndex = 3;
            this.ekle_btn.ImageList = this.ımageList1;
            this.ekle_btn.Location = new System.Drawing.Point(0, 137);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ekle_btn.Size = new System.Drawing.Size(172, 43);
            this.ekle_btn.TabIndex = 6;
            this.ekle_btn.Text = "  Ekle";
            this.ekle_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // kln_btn
            // 
            this.kln_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kln_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kln_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kln_btn.FlatAppearance.BorderSize = 0;
            this.kln_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kln_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kln_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kln_btn.ImageIndex = 2;
            this.kln_btn.ImageList = this.ımageList1;
            this.kln_btn.Location = new System.Drawing.Point(0, 94);
            this.kln_btn.Name = "kln_btn";
            this.kln_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.kln_btn.Size = new System.Drawing.Size(172, 43);
            this.kln_btn.TabIndex = 5;
            this.kln_btn.Text = "  Kullancılar";
            this.kln_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kln_btn.UseVisualStyleBackColor = true;
            this.kln_btn.Click += new System.EventHandler(this.kln_btn_Click);
            // 
            // ders_btn
            // 
            this.ders_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ders_btn.BackColor = System.Drawing.Color.Transparent;
            this.ders_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ders_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ders_btn.FlatAppearance.BorderSize = 0;
            this.ders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ders_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ders_btn.ForeColor = System.Drawing.Color.Black;
            this.ders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ders_btn.ImageIndex = 5;
            this.ders_btn.ImageList = this.ımageList1;
            this.ders_btn.Location = new System.Drawing.Point(0, 51);
            this.ders_btn.Name = "ders_btn";
            this.ders_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ders_btn.Size = new System.Drawing.Size(172, 43);
            this.ders_btn.TabIndex = 4;
            this.ders_btn.Text = " Ders Programı";
            this.ders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ders_btn.UseVisualStyleBackColor = false;
            this.ders_btn.Click += new System.EventHandler(this.ders_btn_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.DimGray;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(172, 51);
            this.panel_logo.TabIndex = 3;
            this.panel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admin_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 435);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_ekranı";
            this.Text = " ";
            this.Load += new System.EventHandler(this.admin_ekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button ders_btn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button kln_btn;
        private System.Windows.Forms.Button Güncelle;
    }
}