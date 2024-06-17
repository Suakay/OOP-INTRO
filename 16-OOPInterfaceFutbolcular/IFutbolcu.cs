using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOPInterfaceFutbolcular
{
    internal interface IFutbolcu
    {
        public string AdSoyad {  get; set; }    
        public int FormanUmarasi {  get; set; } 
        public byte SutGucu {  get; set; }  
        public byte Refleks {  get; set; }  
        public byte Agrasiflik {  get; set; }   
        public bool MilliMi {  get; set; }  
        public bool Dayaniklili {  get; set; }  
        public bool SolAyakMi {  get; set; }

        public string SutCek();
        public string TopKurtar();
        public string Sakatlan();
    }
}
