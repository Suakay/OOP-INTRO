using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOPInterfacePersoneller
{
    internal class TeknikServis : Personel, ICiktiAlabilir, IKartusDegistireblir, IYemekSoyleyebilir
    {
        public bool BilgisayarAlabilir { get; set; }
        public bool AgKurabilir { get; set; }
        public bool ICıktiAlablir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool KagitEkleyebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool KartusDedistirebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
