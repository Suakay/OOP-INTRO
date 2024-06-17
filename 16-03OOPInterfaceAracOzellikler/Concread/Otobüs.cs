using _16_03OOPInterfaceAracOzellikler.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03OOPInterfaceAracOzellikler.Concread
{
    internal class Otobüs :Arac, ITekerlek
    {
        public int TekerlekSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
