using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPPolymorphizim
{
    internal class DİKDÖRTGEN:GeometrikSekil
    {
       
            public override void AlanHesapla()
            {
                Console.WriteLine("DİKÖRTGENİ ALANI" + Yukseklik * Genislik);
            }
            public override void CevreHesapla()
            {
                Console.WriteLine("DİKDÖRTGENİN  CEVRESİ" + (Yukseklik + Genislik) * 2);
            }
        
    }
}
