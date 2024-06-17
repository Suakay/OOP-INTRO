using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOPEncapsulatıonUtuClassi2
{
    internal class Utu
    {
        public string Marka {  get; set; }  

        public string Sicaklik {  get; set; }
        public string _renk;

        public string Renk
        {
            get { return _renk; }
            set
            {
                if (value == "Mavi")
                    _renk = value;
                else
                    _renk = "Belirtilmedi";
            }
        }
    }
}
