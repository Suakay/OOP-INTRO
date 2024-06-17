using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BaseKitap
{
    internal   class Kitap:BaseKitap
    {
        public int ID {  get; set; }    
        public string KitapAdi { get; set; }    
        public string KitapTuru {  get; set; }  
        public string ISBNNO {  get; set; } 
        public string Yazar {  get; set; }
        //override keywod'ü ile atasından aldığı metodu isterse değiştirebilir.
        public override void GetLog()
        {
            //base.GetLog();
            Console.WriteLine("kİTAP cLASS'INDAN KAYIT GETİRİLİYOR");
        }

    }
}
