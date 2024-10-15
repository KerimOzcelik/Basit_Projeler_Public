
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
           
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            string islem = textBox3.Text;
            double sonuc = 0;

            switch (islem)
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc= sayi1 * sayi2; break;
                case "/": 
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        MessageBox.Show("Paydadaki sayı 0 olamaz.");
                       return;
                    }
                    break;

          
                    default:
                    MessageBox.Show("Geçersiz operatör.");
                    return ;
            }

            label5.Text = "" + sonuc.ToString();
        }
    }
}
