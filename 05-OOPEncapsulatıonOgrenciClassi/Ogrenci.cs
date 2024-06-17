using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPEncapsulatıonOgrenciClassi
{
    internal class Ogrenci
    {
        public string Ad {  get; set; } 
        public string Soyad {  get; set; }  
        public string Sınıf {  get; set; }  
        private DateTime _dt;
        public DateTime DogumTarihi
        {
            get { return _dt; }
            set
            {
                _dt = value;
                _yas = DateTime.Now.Year - value.Year;
            }
        }
            private int _yas;
        public int Yas
        {
            get { return _yas; }    
            //set { _yas = value; }set{
            //salt okunur bir property oldu.DIŞARIDAN SET EDİLEMEZ.
            //PROPFULL=>FİELD+PROPERTY
            //field classın içinde değer atamak için private olarak tanımlayıp sadece classın içinde kullanabilriz.
            
        }
        public void OgrenciBilgileriniYaz()
        {

        }
       private void YasHesapla()//geriye değer döndürmeyen metot
        {
            _yas = DateTime.Now.Year - DogumTarihi.Year;
        }


    }
}
