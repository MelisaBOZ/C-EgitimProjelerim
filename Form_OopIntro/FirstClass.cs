using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_OopIntro
{
    class FirstClass
    {
        private int ID;
        public int Id { get { return ID; } set { ID = value; } }

        private string _isim;
        public string Isim { get { return _isim; } set { _isim = value; } }

        private string _soyisim;
        public string Soyisim { get { return _soyisim; } set { _soyisim = value; } }


        private double _boy;
        public double Boy { get { return _boy; } set { _boy = value; } }


        private double _kilo;

        public double Kilo { get { return _kilo; } set { _kilo = value; } }

        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value >= 10 && value <= 90)
                {
                    _yas = value;
                }
                else
                {
                    MessageBox.Show("Yaş aralığı 10'dan küçük 90'dan büyük olamaz!..");
                }
            }
        }
    }
}
