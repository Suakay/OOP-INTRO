//Inheritance:Miras Almak
//aRABA,bİSİKLET,mOTOR,sCOTTER
/*
 * ARABA
 * ıd
 * teker sayııs
 * maksimum hız
 * kapasite
 * kapı sayısıbunlar o arabayı temsil eden özellikler birer propertydir
 * YarışArabası
 * ıd
 * teker sayısı
 * kapasitesi
 * maksmum hızı
 
 */
using _06_OOPInherıtanceTasitArabaYarisArabasi;

Tasit araba=new Tasit();
araba.ID = 1;
araba.MaksimumHiz = 180;
araba.TekerlekSayısı = 4;
araba.Kapasite = 5;


Tasit bisiklet=new Tasit(); 
bisiklet.ID = 2;
bisiklet.MaksimumHiz = 20;
bisiklet.TekerlekSayısı = 2;

Araba araba1 = new Araba();
YarisArabasi  yarısArbasi = new YarisArabasi();

Araba araba2 = new Araba();
Console.WriteLine(araba2.ArabaninHiziniVer());//arabanın maksimum hızı özelği protectd olduğundan instacenı alıp kullanırız.Bu yüzden metoto aracılığı ile değeri alırız

