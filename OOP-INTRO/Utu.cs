using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_INTRO
{
    internal class Utu
    {
       //Property oluşturmak için prop+Tab+Tab'a basılı tut.
       //public access Modifieder
       //internal bir acces modifieder.
       //
        public string Marka {  get; set; }  
        public string Renk {  get; set; }   
        public int Sıcaklık {  get; set; }  
        public bool KazanlıMı {  get; set; }    

    }
    //Constructor yapıcı metot
    //ctor+tab+tab constructor.
    //Default constructor yazmak zorunda değildir.
    

    public Utu(string Marka,string Renk,bool KazanlıMı,int sıcaklık)
    {
        this.Marka = Marka;
        this.Renk = Renk;
        this.Sıcaklık = sıcaklık;
        this.KazanlıMı = true;
    }

    public Utu(string Marka)
    {

    }
}
