using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOPInterfacePersoneller
{
    internal interface IKartusDegistireblir
    {
        public bool KagitEkleyebilir { get; set; }
        public bool KartusDedistirebilir { get; set; }
    }
}
