using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPAbstructıonTasitlar
{
    internal class MotorluTasit
    {
        //virtual,override,abstruct
        //public ovverrde void Git() //kimseden miras almadığı için override keywordünü burada kullanmayız
        //virtual yada abstruct kullanılabilir.
        public  virtual void Git()
        {
            Console.WriteLine("motorlu tasit gidiyor");
        }
    }
}
