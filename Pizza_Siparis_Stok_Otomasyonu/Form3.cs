using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Siparis_Stok_Otomasyonu
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
           


   
            if (Form1.yetki_user=="1")
            {
                
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_stok == "1")
            {

                Form5 frm5 = new Form5();
            frm5.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_cari == "1")
            {

                Form6 frm6 = new Form6();
            frm6.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_buy == "1")
            {

                Form7 frm7 = new Form7();
            frm7.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_log == "1")
            {


                Form8 frm8 = new Form8();
            frm8.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Form1.yetki_toptan== "1")
            {


                Form11 frm11 = new Form11();
                frm11.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Form1.yetki_user == "1")
            {

                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }

        }

        private void stokİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_stok == "1")
            {

                Form5 frm5 = new Form5();
                frm5.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void cariYönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_cari == "1")
            {

                Form6 frm6 = new Form6();
                frm6.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void loglarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Form1.yetki_log == "1")
            {


                Form8 frm8 = new Form8();
                frm8.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_buy == "1")
            {

                Form7 frm7 = new Form7();
                frm7.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void toptancıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Form1.yetki_toptan == "1")
            {


                Form11 frm11 = new Form11();
                frm11.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz Bulunmamaktadır");
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
