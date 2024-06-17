using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOPInterFaceAracOzellikler
{
    internal interface IAracOzellikler
    {
        public string Marka {  get; }  
        public int Model {  get; set; } 
        public int Hız {  get; set; }   
        public decimal Fiyat {  get; set; }
        int Gosterge(int deger);
        void Bilgiler();
    }
}
