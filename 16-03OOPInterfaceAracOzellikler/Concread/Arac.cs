using _16_03OOPInterfaceAracOzellikler.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03OOPInterfaceAracOzellikler.Concread
{
    internal abstract class Arac : IAracOzellikleri
    {
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Hız { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Renk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TekerlekSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public abstract void Parket();
        public abstract void Sur();
        public abstract void VitesDegistir(int vites);
    }
}
