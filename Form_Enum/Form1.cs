using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Form_Enum.Personeller;

namespace Form_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbPersonelDepartmani.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));

        }
        List<Personeller> personeller = new List<Personeller>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            personel.AdSoyad = txtPersonelAdi.Text;
            personel.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbPersonelDepartmani.Text);

            personeller.Add(personel);

            foreach (var personell in personeller)
            {
                MessageBox.Show("Adı: " + personell.AdSoyad + " Departman: " + personell.Departman);
            }
        }
    }
}
