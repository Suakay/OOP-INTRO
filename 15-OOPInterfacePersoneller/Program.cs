using _15_OOPInterfacePersoneller;

Muhasebe muhasebe = new Muhasebe();
muhasebe.AdSoyad = "Ayşe Fasülye";
muhasebe.ICıktiAlablir=false;
muhasebe.DogumTarihi = new DateTime(2000, 5, 6);
muhasebe.Gorevi = "uzman";
muhasebe.IseGirisTarih = new DateTime(2024, 2, 4);
muhasebe.Maasi = 15000;
muhasebe.OdemeAlabilir = false;
muhasebe.OdemeYapabilir = true;




InsanKaynakları ınsanKaynakları = new InsanKaynakları()
{
    AdSoyad = "Zehra Dörter",
    DogumTarihi = new DateTime(1996, 4, 6),
    Gorevi = "IK MÜDÜRÜ",
    Maasi=50000,
    IseAlimYapabilir=true,
    MaasiGorebilir=true,
    YemekSiparisEdeblir=true,
   
};