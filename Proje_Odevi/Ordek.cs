using System.Media;
using System;
namespace Proje_Odevi
{
    class Ordek:Hayvan,IHayvanInterface
    {
        public int ordekYumurta = 0;
        public string OrdekDizin = "ordek.wav";
        public int OrdekYumFiyati = 3;

        public Ordek()
        {
            CanAzalma = 3;
        }
        public  void SesCikar(string OrdekDizin)
        {
            SoundPlayer HayvanSes = new SoundPlayer();
            HayvanSes.SoundLocation = OrdekDizin;
            HayvanSes.Play();
        }
        
    }
}
