using System.Media;
using System;
namespace Proje_Odevi
{
    class Inek : Hayvan, IHayvanInterface
    {
        public int inekSutu = 0;
        public string InekDizin = "inek.wav";
        public int InekSutFiyati = 5;
        
        public Inek()
        {
            CanAzalma = 8;
        }

        public  void  SesCikar( string InekDizin)
        {
            SoundPlayer HayvanSes = new SoundPlayer();
            HayvanSes.SoundLocation = InekDizin;
            HayvanSes.Play();
        }

       
    }
}
