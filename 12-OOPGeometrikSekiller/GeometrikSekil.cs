using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOPGeometrikSekiller
{
    public abstract class GeometrikSekil
    {
        public int Yukseklik {  get; set; } 
        public int Genislik {  get; set; }
        public abstract int CevreHesapla();
        public abstract int AlanaHesapla();
    }
}
