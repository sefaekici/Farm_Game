using System;
using System.Windows.Forms;

namespace Proje_Odevi
{
    
    public partial class Form1 : Form
    {
        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        Keci keci = new Keci();
        Inek inek = new Inek();
        Hayvan hayvan = new Hayvan();
        

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {           
            hayvan.gecenSure++;
            surelabel.Text = Convert.ToString(hayvan.gecenSure) +" "+"SN";
            if (tavukCanbar.Value > 0)
            {
                tavukCanbar.Value = tavukCanbar.Value - tavuk.CanAzalma;
                if (tavukCanbar.Value == 0)
                {
                    tavuk.UretimMiktari = 0;
                    tavuk.SesCikar(tavuk.TavukDizin);
                    tavukYemVerbutton.Enabled = false;
                    tavukDurumlabel.Text = hayvan.DurumText;
                }
            }
            
            if (keciCanbar.Value > 0)
            {
                keciCanbar.Value = keciCanbar.Value - keci.CanAzalma;
                if (keciCanbar.Value ==4)
                {
                   keciCanbar.Value = 0;
                    keci.UretimMiktari = 0;
                }
                if (keciCanbar.Value == 0)
                {

                    keci.SesCikar(keci.KeciDizin);
                    keciYemVerbutton.Enabled = false;
                    keciDurumlabel.Text = hayvan.DurumText;
                }
            }

            
            if (inekCanbar.Value > 0)
            {
                inekCanbar.Value = inekCanbar.Value - inek.CanAzalma;
                if (inekCanbar.Value ==4)
                {
                    inekCanbar.Value = 0;
                    inek.UretimMiktari = 0;
                }
                if (inekCanbar.Value == 0)
                {

                    inek.SesCikar(inek.InekDizin);                
                    inekDurumlabel.Text = hayvan.DurumText;
                    inekYemVerbutton.Enabled = false;
                    
                }
            }
            if (ordekCanbar.Value > 0)
            {
                ordekCanbar.Value = ordekCanbar.Value - ordek.CanAzalma;
                if (ordekCanbar.Value ==1)
                {
                    ordekCanbar.Value = 0;
                    ordek.UretimMiktari = 0;
                }
                if (ordekCanbar.Value == 0)
                {

                    ordek.SesCikar(ordek.OrdekDizin);               
                    ordekYemVerbutton.Enabled = false;
                    ordekDurumlabel.Text = hayvan.DurumText;
                }
            }
            if (hayvan.gecenSure % 3 == 0 && hayvan.gecenSure !=0)
            {
                tavuk.tavukYumurta = tavuk.tavukYumurta + tavuk.UretimMiktari;
                tavukYumlabel.Text = Convert.ToString(tavuk.tavukYumurta) + " " + hayvan.YumurtaText;
                
            }
            if (hayvan.gecenSure % 5 == 0 && hayvan.gecenSure != 0)
            {
                ordek.ordekYumurta = ordek.ordekYumurta + ordek.UretimMiktari;
                ordekYumlabel.Text = Convert.ToString(ordek.ordekYumurta) + " " + hayvan.YumurtaText;
             
            }
            if (hayvan.gecenSure % 8 == 0 && hayvan.gecenSure != 0)
            {
                inek.inekSutu = inek.inekSutu + inek.UretimMiktari;
                inekSutlabel.Text = Convert.ToString(inek.inekSutu) + " " + hayvan.SutText;
                
            }
            if (hayvan.gecenSure % 7 == 0 && hayvan.gecenSure != 0)
            {
                keci.keciSutu = keci.keciSutu + keci.UretimMiktari;
                keciSutlabel.Text = Convert.ToString(keci.keciSutu) + " " + hayvan.SutText;
               
            }
        }

        private void inekYemVerbutton_Click(object sender, EventArgs e)
        {
            inekCanbar.Value = 100;
            
        }

        private void tavukYemVerbutton_Click(object sender, EventArgs e)
        {
            tavukCanbar.Value = 100;
            
        }

        private void ordekYemVerbutton_Click(object sender, EventArgs e)
        {
            ordekCanbar.Value = 100;
            
        }

        private void keciYemVerbutton_Click(object sender, EventArgs e)
        {
            keciCanbar.Value = 100;
           
        }

        private void tavukSatbutton_Click(object sender, EventArgs e)
        {
            hayvan.kasa = hayvan.kasa+(tavuk.tavukYumurta * tavuk.TavukYumFiyati);
            kasalabel.Text = Convert.ToString(hayvan.kasa) + " " + "TL";
            tavuk.tavukYumurta = 0;
            tavukYumlabel.Text = "0 ADET";
        }

        private void ordekSatbutton_Click(object sender, EventArgs e)
        {
            hayvan.kasa = hayvan.kasa + (ordek.ordekYumurta * ordek.OrdekYumFiyati);
            kasalabel.Text = Convert.ToString(hayvan.kasa) + " " + "TL";
            ordek.ordekYumurta = 0;
            ordekYumlabel.Text = "0 ADET";
        }

        private void inekSatbutton_Click(object sender, EventArgs e)
        {
            hayvan.kasa = hayvan.kasa + (inek.inekSutu * inek.InekSutFiyati);
            kasalabel.Text = Convert.ToString(hayvan.kasa) + " " + "TL";
            inek.inekSutu = 0;
            inekSutlabel.Text = "0 KG";
        }

        private void keciSatbutton_Click(object sender, EventArgs e)
        {
            hayvan.kasa = hayvan.kasa + (keci.keciSutu * keci.KeciSutFiyati);
            kasalabel.Text = Convert.ToString(hayvan.kasa) + " " + "TL";
            keci.keciSutu = 0;
            keciSutlabel.Text = "0 KG";
        }
    }
}
