

namespace _16_OOPInterFaceAracOzellikler
{
    internal class Mercedes : IAracOzellikler
    {
        private string _marka = "MERCEDES";
        public string Marka
        {
            get
            {
                return _marka;
            }
        }
        public int Model { get ; set ; }
        public int Hız { get ; set ; }
        public decimal Fiyat { get; set; }

        public void Bilgiler()
        {
            Console.WriteLine($"FİYAT:{Fiyat}/nGösterge{Hız}/nMarka{Marka}/nModel{Model}");
        }

        public int Gosterge(int deger)
        {
            return deger;
        }
    }
}
