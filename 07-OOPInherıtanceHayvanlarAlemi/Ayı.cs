using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Derived class
namespace _07_OOPInherıtanceHayvanlarAlemi
{
    public class Ayı:Hayvan
    {
        public Ayı()
        {
            Console.WriteLine("AYI YARATILDI");
            base.Uyu();
            //bASE ANAHTAR KELİMESİ MİRAS ALINAN SINIFIN ÜYELERİNE ERİŞEBİLMEMİZİ SAĞLAR
            //BASE ANAHTAR KELİMESİ MİRAS ALINAN SINIFIN İZİN VERİLEN ÜYELERİNE ULAŞMAMIZI SAĞLAR.PRİVATE ÜYELERİNE ULAŞAMAM
            base.Uyu();
            //bU METOT PROTECTED OLARAK TANIMLNDIĞINDAN BURADAN ERİŞEBİLİRİZ
            //base.Beslen();bu metot private olarak tanımlandığı için buradan erişilemez
            //this anahtar kelimesi bu sınıfın miras aldıklarıda dahil tüm üyelere ulaşmamızı sağlar
            //base.Uyu() dedğimizde bu protected olarak tanımlandığından buradan erişebiliriiz.
            //base anahtar kelimes miras alınana sınıfın izin verlen üyelerine ulaşabiliriz.private üyelerine ulaşamama.
            //base.Beslen() bu metoto private olduğumuz için buradan erişemez.
        }

    }
}
