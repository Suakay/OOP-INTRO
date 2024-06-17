using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPPolymorphizim
{
    internal class Kare:GeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("KARENİN ALANI" + Yukseklik * Genislik);
        }
        public override void CevreHesapla()
        {
            Console.WriteLine("KARENİN CEVRESİ" + (Yukseklik + Genislik) * 2);
        }
    }
}
