using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = FizikKutuphanesi.YerCekimiKuvveti.ToString();
            double kuvvet = Pow(3, 4);// Math.Pow(3,4);

            string isim = "BilGe SeLin Dersi";
            string yeniIsim = isim;

            MessageBox.Show("İsmin ilk hali: " + isim);
            MessageBox.Show("İsmin metot ile yenilenmiş hali: " + yeniIsim);
        }

        private double Pow(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
