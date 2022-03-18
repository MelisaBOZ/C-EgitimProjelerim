using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Struct
{
    class Kitap
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string ISBNNo { get; set; }
        public string YazarAdi { get; set; }


        public Kitap(int Id, string Adi, string Turu, string ISBNNo, string YazarAdi)
        {
            this.Id = Id;
            this.Adi = Adi;
            this.Turu = Turu;
            this.ISBNNo = ISBNNo;
            this.YazarAdi = YazarAdi;
        }
    }
}
