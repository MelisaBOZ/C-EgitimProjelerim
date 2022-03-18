using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_List
{
    public partial class ArrayList : Form
    {
        public ArrayList()
        {
            InitializeComponent();
        }
        string[] ListSehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(ListSehirler, 2, 3);
            Array.Clear(ListSehirler, 0, ListSehirler.Length);
            foreach (var diziElemani in ListSehirler)
            {
                MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            lst_ArrayBas.Items.Clear();
            string[] geciciDizi = new string[4];
            Array.Copy(ListSehirler, 7, geciciDizi, 0, geciciDizi.Length);
            foreach (var diziElemani in geciciDizi)
            {
                

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            int aranilanIndex = Array.IndexOf(ListSehirler, "Eskişehir");
            MessageBox.Show("Aradığınız şehrin indexi: " + aranilanIndex);
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            int aranilanSonIndex = Array.LastIndexOf(ListSehirler, "Eskişehir");

            MessageBox.Show("Aradığınız elemanın son indexi: " + aranilanSonIndex);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize<string>(ref ListSehirler, 32);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(ListSehirler);

            foreach (var diziElemani in ListSehirler)
            {
                
                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Array.Reverse(ListSehirler);

            foreach (var diziElemani in ListSehirler)
            {
                // MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }
        }
    }
}
