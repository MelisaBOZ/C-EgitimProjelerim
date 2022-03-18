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
    public partial class ForeachLoops : Form
    {
        public ForeachLoops()
        {
            InitializeComponent();
        }
  string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Bursa", "Eskişehir", "Trabzon", "Sivas", "Malatya" };
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (string sehirlerindex in sehirler)
            {
                listBox1.Items.Add(sehirlerindex);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };

            int bolunenler = 0;
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    bolunenler++;
                }

                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
            }
         
            MessageBox.Show($"Bu dizide hem 2 ye hem de 3 tam bölünen toplam {bolunenler} sayı vardır");
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            foreach (string eleman in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(eleman))
                {
                    listBox2.Items.Add(eleman);
                }
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                   
                    ctrl.BackColor = Color.Maroon;
                    ctrl.ForeColor = Color.Orange;
                    
                }
            }
        }
    }
}
