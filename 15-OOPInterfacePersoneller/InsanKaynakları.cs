using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOPInterfacePersoneller
{
    //Derved Class(Türemiş)
    internal class InsanKaynakları : Personel, ICiktiAlabilir, IYemekSoyleyebilir
    {
        public bool IseAlimYapabilir { get; set; }
        public bool MaasiGorebilir { get; set; }
        public bool ICıktiAlablir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //çıktı alabilir olmasın
    }
}
