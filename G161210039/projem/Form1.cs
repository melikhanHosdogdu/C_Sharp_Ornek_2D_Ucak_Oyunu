/**********************************************************************************
**                                        SAKARYA ÜNİVERSİTESİ
**                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                     2016-2017 BAHAR DÖNEMİ
**
**                          ÖDEV NUMARASI..........:PROJE
**                          ÖĞRENCİ ADI............: Melikhan Muhammed Hoşdoğdu 
**                          ÖĞRENCİ NUMARASI.......: G 161210039
**                          DERSİN ALINDIĞI GRUP...:2B
************************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ucak_sayisi = 0, yer = 100;
        Random rnd = new Random(); 
       
        

        private void mermi_olustur()
        {
            PictureBox mermi = new PictureBox();
            mermi.Size = new Size(10, 20);
            mermi.SizeMode = PictureBoxSizeMode.Zoom;
            mermi.ImageLocation = "mermi.jpg";
            mermi.Tag = "mermi";
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            mermi.Location = new Point(x, y);
            mermi.Visible = true;
            this.Controls.Add(mermi);
          

           
        }

        private void ucak_olustur()
        {

            PictureBox ucak = new PictureBox();
            ucak.Tag = "ucak";
            yer = rnd.Next(10, 700);
            ucak.Size = new Size(40, 80);
            ucak.SizeMode = PictureBoxSizeMode.Zoom;
            ucak.ImageLocation = "ucak.png";
            ucak.Location = new Point(yer, 0);
            ucak.Visible = true;
            this.Controls.Add(ucak);
          


        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
        
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y; 
            if(e.KeyCode==Keys.Right && x<751)
            {
                x = x + 25;
                
            }
            if(e.KeyCode==Keys.Left && x>0)
            {
                x = x - 25;
            }
            pictureBox1.Location = new Point(x,y);
            if(e.KeyCode==Keys.Space)
            {
                mermi_olustur();
            }

        }//ucak savar hareket

        private void Form1_Load(object sender, EventArgs e)
        {
           
       
              ucak_olustur();
              timer1.Start();                                               
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ucak_sayisi++;
           
            for (int i = 0; i < this.Controls.Count; i++)
            {
                PictureBox mermi_ucak = (PictureBox)this.Controls[i];
                if (this.Controls[i].Tag == "mermi")
                {
                    mermi_ucak.Location = new Point(mermi_ucak.Location.X, mermi_ucak.Location.Y - 100);
                }
              else  if (this.Controls[i].Tag == "ucak")
                {
                    mermi_ucak.Location = new Point(mermi_ucak.Location.X, mermi_ucak.Location.Y +15);
                    if(mermi_ucak.Location.Y>=pictureBox1.Location.Y && mermi_ucak.Location.X<= pictureBox1.Location.Y+pictureBox1.Height)
                    {
                        timer1.Stop();
                        Form2 form2 = new Form2();
                        form2.Show();
                        Hide();
                    }
                }


                for (int a = 0; a < this.Controls.Count; a++)
                {
                    if (this.Controls[a].Tag == "ucak")
                    {
                        if (mermi_ucak.Location.X+ mermi_ucak.Width>this.Controls[a].Location.X && +mermi_ucak.Location.X+ mermi_ucak.Width< this.Controls[a].Location.X+this.Controls[a].Width)
                        {
                            if(mermi_ucak.Location.Y + mermi_ucak.Height > this.Controls[a].Location.Y && +mermi_ucak.Location.Y + mermi_ucak.Height < this.Controls[a].Location.Y + this.Controls[a].Height)
                            {
                                this.Controls.RemoveAt(a);
                                this.Controls.Remove(mermi_ucak); 
                            }

                        }
                    }
                }
           
                if (ucak_sayisi==20)
                {
                    ucak_sayisi = 0;
                    ucak_olustur();
                }
            }

        }
    }
}
