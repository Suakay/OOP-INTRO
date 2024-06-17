using _04_OOPEncapsulatıonUtuClassi2;

Utu utu = new Utu();

Console.WriteLine("Lütfen ütünün markasını giriniz");
utu.Marka = Console.ReadLine();
Console.WriteLine("Lütfen ütünün rengini giriniz:");
utu.Renk = Console.ReadLine();
utu.Sicaklik = 0;
Console.WriteLine("ütü nesnesi yaratıldı!/NMarkası:{0}/n Rengi:{1}/Sıcaklık:{2}",utu.Marka,utu.Renk,utu.Sicaklik);