using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loops
{
    public partial class ForLoop2 : Form
    {
        public ForLoop2()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };

            for (int index = 0; index < takimlar.Length; index++)
            {
                listBox1.Items.Add(takimlar[index]);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

           
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
            int enBuyukEleman = 0;
            for (int index = 0; index < sayisal.Length; index++)
            {
                if (enBuyukEleman < sayisal[index])
                {
                    enBuyukEleman = sayisal[index];
                }
            }
            MessageBox.Show("En Büyük Eleman => " + enBuyukEleman);
         
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tekSayilar = 0;
            int ciftSayilar = 0;

            for (int index = 0; index < sayisal.Length; index++)
            {
                if (sayisal[index] % 2 == 0)
                {
                    ciftSayilar++;
                }
                else
                {
                    tekSayilar++;
                }
            }

            MessageBox.Show(string.Format("Bu dizide toplam {0} adet çift sayı, {1} adet tek sayı bulunmaktadır.", ciftSayilar, tekSayilar));
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            string text = "Game Developer";
            string terstenYazim = "";

            for (int index = text.Length - 1; index >= 0; index--)
            {
                terstenYazim += text[index];
            }
            MessageBox.Show("Tersten Yazım => " + terstenYazim);
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int karmasikSayi = rnd.Next(0, 101);
                listBox1.Items.Add(karmasikSayi);
            }
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Maroon;
                    this.Controls[i].ForeColor = Color.Orange;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkBlue;
                    this.Controls[i].ForeColor = Color.Yellow;
                    listBox1.Font = new Font("Tahoma", 13);
                }
            }
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {

            int add = 0;
            for (int i = 0; i < txtGirisAlani.Text.Length; i++)
            {
                int cevrilenDeger = Convert.ToInt32(txtGirisAlani.Text[i].ToString());
                add += cevrilenDeger;
            }
            MessageBox.Show(add.ToString());
        }
    }
}
