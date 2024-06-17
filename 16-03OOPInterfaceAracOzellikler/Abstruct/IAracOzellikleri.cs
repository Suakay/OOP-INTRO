using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03OOPInterfaceAracOzellikler.Abstruct
{
    internal interface IAracOzellikleri
    {
        public string Model {  get; set; }  
        public int Hız {  get; set; }   
        public string Renk {  get; set; }    
         
        public int TekerlekSayisi {  get; set; }    


    }
}
