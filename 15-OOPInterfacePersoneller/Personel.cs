namespace _15_OOPInterfacePersoneller
{
    //insan kaynakları base classdır
    internal class Personel : IYemekSoyleyebilir
    {
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal Maasi { get; set; }
        public DateTime IseGirisTarih { get; set; }
        public string Gorevi { get; set; }
        public bool YemekSiparisEdeblir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public bool CıktıAlabilir{get;set;} ayazarsak tüm personeller çıktı alabilir oldu.
    }
   
    
    
}
