using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_OopIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FirstClass firstclass =new FirstClass();
        private void Form1_Load(object sender, EventArgs e)
        {
    

        }

        private void btnIsim_Click(object sender, EventArgs e)
        {
            firstclass.Isim = "Melisa";
            firstclass.Soyisim = "Boz";
            firstclass.Yas = 25;

            MessageBox.Show("Hoşgeldiniz! "+firstclass.Isim+""+firstclass.Soyisim);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            firstclass.Isim = "Berkay";
            firstclass.Soyisim = "Üresin";
            firstclass.Yas = 25;
            firstclass.Boy = 1.70;
            firstclass.Kilo = 65;
            firstclass.Id = 123456;
            MessageBox.Show("Kullanıcı Bilgileri : "+ " Adı ve Soyadı "+firstclass.Isim+""+firstclass.Soyisim+"Yaşı ve kilosu " +firstclass.Yas+""+firstclass.Kilo+" ID numarası "+firstclass.Id);

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txtYas.Text);
            if (yas == firstclass.Yas)
            {
                txtYas.Text = firstclass.Isim;
            }
            else
            {
                MessageBox.Show("Veritabanımızda kayıtlı bu yaşta bir kullanıcı yoktur!...");
            }
        }
    }
}
