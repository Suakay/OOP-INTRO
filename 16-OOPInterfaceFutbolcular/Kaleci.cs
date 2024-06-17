using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOPInterfaceFutbolcular
{
    internal class Kaleci : IFutbolcu
    {
        public string AdSoyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FormanUmarasi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private byte _sutGucu;
        public byte SutGucu
        {
            get { return _sutGucu; }
            set
            {
                if (value > 70)
                {
                    _sutGucu = 70;
                    Console.WriteLine("Bir defans oyucusunun şut gücü enfazla 70 olabilir./nŞut 70 oarak ayarlandı!");

                }
                else
                {
                    _sutGucu = value;
                }
            }                                                                               
        }
        public byte Refleks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Agrasiflik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MilliMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Dayaniklili { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SolAyakMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Sakatlan()
        {
            return "Sakatlandı";
        }

        public string SutCek()
        {
            return "Uzaktan şut çek";
        }

        public string TopKurtar()
        {
            return "Rakip oyuncuya markaj yaptı";
        }
    }
}
