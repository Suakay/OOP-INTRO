using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOPInherıtanceHayvanlarAlemi
{
    internal class Insan:Hayvan
    {
        public string Adi {  get; set; }    
        public string Düşünce {  get; set; }    
        public Insan()
        {
            Adi = "ZAFER";
        }
        internal void Dusun()
        {
            Console.WriteLine($"{Adi} {Düşünce} düşündü");
        }
       public void AşıkOl(string kime)
        {
            Console.WriteLine($"{Adi} {kime}");
        }
    }
}
