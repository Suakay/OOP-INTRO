using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BaseKitap
{
    //saled base sınıftan türetemiyorz.sealed olarak işaretlendiği için
    //base classında sealed olan metodu override edemeyiz..
    internal class YeniKitap:Kitap
    {
        public void GetLog()
        {
            Console.WriteLine("yENİ KİTAP CLASSINDAN KAYIT GETİRİLİYOR");
        }

    }
}
