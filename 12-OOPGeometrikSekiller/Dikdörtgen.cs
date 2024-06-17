using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOPGeometrikSekiller
{
    internal class Dikdörtgen:GeometrikSekil
    {
            public override int AlanaHesapla()
            {
                return Yukseklik * Genislik;
            }

            public override int CevreHesapla()
            {
                return (Yukseklik + Genislik) * 2;
            }


        
    }
}
