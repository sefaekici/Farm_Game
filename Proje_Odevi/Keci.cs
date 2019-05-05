using System.Media;
using System;
namespace Proje_Odevi
{
    class Keci:Hayvan,IHayvanInterface
    {
        public int keciSutu = 0;
        public string KeciDizin = "keci.wav";
        public int KeciSutFiyati = 8;
        public Keci()
        {
            CanAzalma = 6;
        }
        public void SesCikar(string KeciDizin)
        {
            SoundPlayer HayvanSes = new SoundPlayer();
            HayvanSes.SoundLocation = KeciDizin;
            HayvanSes.Play();
        }
        


    }
}
