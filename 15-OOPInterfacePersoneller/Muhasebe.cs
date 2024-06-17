using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOPInterfacePersoneller
{
     public class Muhasebe : Personel, ICiktiAlabilir
    {
        public bool OdemeYapabilir { get; set; }
        public bool OdemeAlabilir { get; set; }
        public bool ICıktiAlablir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //muhasebe çıktı alablir olsun
        //MUHASEBE YEMEK SİPARİŞİ VEREMEZ.
    }
}
