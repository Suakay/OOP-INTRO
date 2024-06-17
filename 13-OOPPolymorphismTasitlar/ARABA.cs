using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPPolymorphismTasitlar
{
    internal class ARABA:MotorluTasitalar
    {
        public override void  Git()
        {
            Console.WriteLine("ARABA GİDİYOR..");
        }
    }
}
