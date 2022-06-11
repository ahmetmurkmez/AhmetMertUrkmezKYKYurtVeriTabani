using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmetMertUrkmezKYKYurtVeriTabani
{
    public class ogrenciler {
        
        public Guid ogrenciID { get; set; }

        public decimal  ogrenciTC { get; set; }

        public string ogrencisim { get; set; }
        
        public string ogrencisoyisim { get; set; }

        public int ogrenciyas { get; set; }

        public string ogrencimemleket { get; set; }

        public string ogrencitelefon { get; set; }

        public string ogrencikangrubu { get; set; }


        public int ogrenciyemekhanebakiye { get; set; }

        }
    public class odalar
    {
        public Guid odaID { get; set; }

        public int odanumarasi { get; set; }

        public int odakati { get; set; }
    }
    public class personel
    {
        public Guid personelID { get; set; }

        public string personelisim { get; set; }

        public string personelsoyisim { get; set; }

        public int personelyas { get; set; }

        public int personelmaas { get; set; }

        public int personeltelefon { get; set; }

        public string personelcinsiyet { get; set; }

        public string personelvardiye { get; set; }

        public string personelmemleket { get; set; }

        public string personelmevkii { get; set; }

        public odalar odalar { get; set; }

    }
    public class kantinislem
    {
        public Guid kantinislemID { get; set; }

        public personel personel { get; set; }

        public int urunid { get; set; }

        public kantinurunler kantinurunler { get; set; }

        public int urunfiyat { get; set; }
    }
    public class kantinurunler
    {
        public Guid urunnumarasi { get; set; }

        public string urunismi { get; set; }

        public int urunbirimfiyat { get; set; }

        public int urunstokmiktar { get; set; }
    }

}
