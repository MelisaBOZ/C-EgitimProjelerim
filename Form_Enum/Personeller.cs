using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Enum
{
    class Personeller
    {
        public Departmanlar Departman { get; internal set; }
        public string AdSoyad { get; internal set; }

        public enum Departmanlar
        {
            Yazilim = 32, SistemAgUzmanligi, GrafikTasarim, Ingilicce, Muhasebe
        }
       public class Personel
        {

            private string _adSoyad;
            public string AdSoyad { get { return _adSoyad; } set { _adSoyad = value; } }

            private Departmanlar _departman;
            public Departmanlar Departman { get { return _departman; } set { _departman = value; } }

        }
    }
}
