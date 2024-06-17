using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPAbstructıonTasitlar
{
    internal class Araba:MotorluTasit
    {
        //Base class içinde Git metodu virtual olduğu için ovverride edebiliriz.
        public override void Git()
        {
            Console.WriteLine("Araba Gidiyor");
        }
    }
}
