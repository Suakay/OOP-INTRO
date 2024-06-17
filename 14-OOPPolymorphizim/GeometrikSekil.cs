using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPPolymorphizim
{
    internal abstract class GeometrikSekil
    {
        public double Genislik {  get; set; }   
        public double Yukseklik {  get; set; }
        public abstract void AlanHesapla();
        public abstract void CevreHesapla();
    }
}
