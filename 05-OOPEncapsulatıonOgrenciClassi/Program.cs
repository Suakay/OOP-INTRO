using _05_OOPEncapsulatıonOgrenciClassi;

Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "Zafer";
ogrenci.Soyad = "DÖRTER";
ogrenci.DogumTarihi = new DateTime();
//ogrenci.Yas = 40;//SET METODU KAPALI OLDUĞU İÇİN ATAMA YAPILAMAZ.
ogrenci.OgrenciBilgileriniYaz();//öğrenci bilgilerini ekrana yaz
