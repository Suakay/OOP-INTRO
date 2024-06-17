using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOPInherıtanceHayvanlarAlemi
{
      internal class BozAyı : Ayı
    {
        public string Adi { get; set; }
            public BozAyı()
        {
            this.Uyu();
            this.Adi = "";
           
        }
    }
}
