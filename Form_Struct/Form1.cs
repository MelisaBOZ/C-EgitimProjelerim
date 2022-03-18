using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap k;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            k.Adi = "Aylak Adam";
            k.Turu = "Roman";
            k.YazarAdi = "Yusuf atılgan";
            k.ISBNNo = "9789750520976";
           


            Kitap book = new Kitap(1, "Savaş Atı", "Çocuk - Gençlik Edebiyatı Dizisi", "9786059604451", "Michael Morpurgo");
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            MessageBox.Show(k.ISBNNo + "-" + k.YazarAdi + " " + k.Adi + " " + k.Turu);
        }

        private void btnSealedClassCagir_Click(object sender, EventArgs e)
        {
            SealedClassYapisi scy = new SealedClassYapisi();
            scy.sayi1 = 10;
            scy.sayi2 = 20;
            int sonuc = scy.sayi1 + scy.sayi2;
            scy.sonucMetin = "Sayınızın sonucu: " + sonuc;

            MessageBox.Show(scy.sonucMetin);
            MessageBox.Show("**************************");
        }
    }
}
