using System.Media;
using System;
namespace Proje_Odevi
{
    class Tavuk:Hayvan,IHayvanInterface
    {
        public int tavukYumurta = 0;
        public string TavukDizin = "tavuk.wav";
        public int TavukYumFiyati = 1;
        public Tavuk()
        {
            CanAzalma = 2;
        }
        public void SesCikar(string TavukDizin)
        {
            SoundPlayer HayvanSes = new SoundPlayer();
            HayvanSes.SoundLocation = TavukDizin;
            HayvanSes.Play();
        }
        
    }
}
