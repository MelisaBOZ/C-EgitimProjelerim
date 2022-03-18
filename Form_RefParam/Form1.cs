using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_RefParam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void geriyeDegerDonduren(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi, 2);
          


        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            double yakalananSonuc;
            geriyeDegerDonduren(12, out yakalananSonuc);
           
            MessageBox.Show(yakalananSonuc.ToString());
        }

        private void btnOutIki_Click(object sender, EventArgs e)
        {
            int SilinenElemanSayisi;
            ListBoxunElemanlariniTemizle(listBox1, out SilinenElemanSayisi);
            MessageBox.Show("Listbox'tan toplam " + SilinenElemanSayisi + " eleman silinmiştir!");
        }
        void Hesapla(int sayiBir, int sayiIki, out int toplam, out int fark, out long carpim, out double bolum, out byte mod)
        {
            toplam = sayiBir + sayiIki;
            fark = sayiBir - sayiIki;
            carpim = sayiBir * sayiIki;
            bolum = sayiBir / sayiIki;
            mod = (byte)(sayiBir % sayiIki);
        }
        void ListBoxunElemanlariniTemizle(ListBox hangiListboxun, out int kacElemanSildim)
        {
            kacElemanSildim = hangiListboxun.Items.Count;
            hangiListboxun.Items.Clear();
        }

        private void btnOutUc_Click(object sender, EventArgs e)
        {
            int toplamaSonucu;
            int farkSonucu;
            long carpimSonucu;
            double bolumSonucu;
            byte modSonucu;

            Hesapla(9, 4, out toplamaSonucu, out farkSonucu, out carpimSonucu, out bolumSonucu, out modSonucu);
            MessageBox.Show(string.Format("Toplama İşlemi Sonucu : {0}\nÇıkartma İşlemi Sonucu : {1}\nÇarpma İşlemi Sonucu : {2}\nBölme İşlemi Sonucu : {3}\nMod Alma İşlemi Sonucu : {4}", toplamaSonucu, farkSonucu, carpimSonucu, bolumSonucu, modSonucu));
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            double odenecekTutar = FiyatlariHesapla(199.90, 24.60, 12.50, 42.99);
            MessageBox.Show("Ödemeniz gereken toplam tutar: " + odenecekTutar + " TL");
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            string[] elemanlar = new string[0];
            MailListecisi(ref elemanlar, txtMailAdresleri.Text);

            foreach (string eleman in elemanlar)
            {
                listBox1.Items.Add(eleman);
            }
        }
        void MailListecisi(ref string[] HangiDiziyeEklensin, string VerilerNeredenGeliyor)
        {
          
            string[] gelenDegerler = VerilerNeredenGeliyor.Split(';');

            for (int i = 0; i < gelenDegerler.Length; i++)
            {
                Array.Resize<string>(ref HangiDiziyeEklensin, HangiDiziyeEklensin.Length + 1);
                HangiDiziyeEklensin[i] = gelenDegerler[i];
            }
        }
        double FiyatlariHesapla(params double[] fiyatlar)
        {                 


            double toplamFiyat = 0;
            foreach (double fiyat in fiyatlar)
            {
                toplamFiyat += fiyat;
            }
            return toplamFiyat;
        }
    }
}
