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

namespace projem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
        }
    }
}
