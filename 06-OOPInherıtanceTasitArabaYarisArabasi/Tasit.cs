using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOPInherıtanceTasitArabaYarisArabasi
{
    internal class Tasit
    {
        public int ID {  get; set; }    
        public int TekerlekSayısı {  get; set; }    
        public int MaksimumHiz {  get; set; }   
        //protected int MaksimumHiz{get;set;} olarak işaretlenen bir öge kendi içerisinden ya da kendisinden miras alan classlardan erişilebiliri
        public int Kapasite {  get; set; }  
        //Access Modifiers:private,protected,internaliprotected internal,public
        //ctor :Constructor method oluşturuyotuz
        public Tasit()
        {
            MaksimumHiz = 200;//protected olarak işaretlenmiş bir öğeye türeyen sınıftan ulaşabiliriz.

           
        }
        internal int ArabaninHiziniVer()
        {
            return MaksimumHiz;
        }

    }
}
