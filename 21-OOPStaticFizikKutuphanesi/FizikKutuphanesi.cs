using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPStaticFizikKutuphanesi
{
    internal static class FizikKutuphanesi
    {
        public decimal YerCekimiKuvveti {  get; set; }
        public const int KaldirmaKuvveti = 12;//CONST BİR FİELD2a tanımlandığı yerde atama işlemi yapılmadı.
        int x;//field
        const int y = 2;//const
        public int Z {  get; set; } //PROPERY
        public static readonly int kuvvet;
        //STATİC CONSTRUCTORLARDA ACCESS MOİFİER VERİLEMZ.
        //STATİC CONSTRUCTORLARA PARAMETRE VERİLMEZ.
        static FizikKutuphanesi(int deger)
        {
            kuvvet = y * 2;
        }
       
    }
}
