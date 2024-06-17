using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Base class
namespace _07_OOPInherıtanceHayvanlarAlemi
{
    public class Hayvan
    {
        public string Besin {  get; set; }  
        public string Barinak {  get; set; }    
        public string UykuSüresi {  get; set; } 

        protected void Uyu()
        {
            Console.WriteLine($"{UykuSüresi} {Besin} {Barinak}");
        }
        protected void Beslen()
        {
            Console.WriteLine($"{Besin} yedi");
        }
        public void BilgileriGoster()
        {
            Beslen();
            Uyu();
        }
        private void Beslen()
        {

        }
    }
}
