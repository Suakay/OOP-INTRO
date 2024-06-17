
namespace _16_OOPInterFaceAracOzellikler
{
    internal class BMW : IAracOzellikler,IAracPuanı
    {
        public string Marka { get ; set ; }
        public int Model { get ; set ; }
        public int Hız { get ; set ; }
        public decimal Fiyat { get ; set ; }

        public double AracPuani(double puan)
        {
            throw new NotImplementedException();
        }

        public void Bilgiler()
        {
            Console.WriteLine($"FİYAT:{Fiyat}/nGösterge{Hız}/nMarka{Marka}/nModel{Model});
        }

        public int Gosterge(int deger)
        {
            return deger;
        }
    }
}
