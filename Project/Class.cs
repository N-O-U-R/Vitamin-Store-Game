using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{

    interface Imeyve
    {
        int Agirlik { get; set; }
        int VitaminA { get; set; }
        int VitaminC { get; set; }

        int Sivi { get; set; }

        

        int siviHesapla();
        int vitAHesapla(int iu,int Sivi);
        int vitCHesapla(int gr,int Sivi);
    }


    class narinciyeMeyve : Imeyve
    {
        public int nAgirlik;
        public int nVitA;
        public int nVitC;
        public int nSivi;

        Random rastgele = new Random();



        public int Agirlik { get { return nAgirlik; }  set { nAgirlik = value; } }
        public int VitaminA { get { return nVitA; } set { nVitA = value; } }
        public int VitaminC { get { return nVitC; } set { nVitC = value; } }
        public int Sivi { get { return nSivi; } set { nSivi = value; } }

        public int siviHesapla()
        {
            Agirlik = rastgele.Next(70, 120);
            Sivi = nAgirlik * rastgele.Next(30, 70) / 100;


            return nSivi;
        }

        public int vitAHesapla(int iu, int nSivi1)//100 gramda vitamin A'nın miktarı
        {
            siviHesapla();
            VitaminA = nSivi * iu / 100;

            return nVitA;

        }

        public int vitCHesapla(int gr, int nSivi1)//100 gramda vitamin C'nın miktarı
        {
            siviHesapla();
            VitaminC = nSivi * gr / 100;

            return nVitC;

        }
    }

    class katiMeyve : Imeyve
    {
        public int kAgirlik;
        public int kVitA;
        public int kVitC;
        public int kSivi;

        Random rastgele = new Random();


        public int Agirlik { get { return kAgirlik; } set { kAgirlik = value; } }
        public int VitaminA { get { return kVitA; } set { kVitA = value; } }
        public int VitaminC { get { return kVitC; } set { kVitC = value; } }
        public int Sivi { get { return kSivi; } set { kSivi = value; } }

        public int siviHesapla()
        {
            Agirlik = rastgele.Next(70, 120);
            Sivi = kAgirlik * rastgele.Next(80, 95) / 100;


            return kSivi;
        }

        public int vitAHesapla(int iu, int nSivi1)
        {
            
            VitaminA = nSivi1 * iu / 100;

            return kVitA;
        }

        public int vitCHesapla(int gr,int nSivi1)
        {
            
            VitaminC = nSivi1 * gr / 100;

            return kVitC;

        }
    }

    class portakal : narinciyeMeyve
    {
        

        public void SonucPortakal()
        {
            siviHesapla();

            vitAHesapla(225,nSivi);
            vitCHesapla(45,nSivi);

        }
        

    }
    class elma : katiMeyve
    {
        public void SonucElma()
        {

            siviHesapla();

            vitAHesapla(54, kSivi);
            vitCHesapla(5, kSivi);

        }

    }
    class cilek : katiMeyve
    {
        public void SonucCilek()
        {
            siviHesapla();

            vitAHesapla(12, kSivi);
            vitCHesapla(60, kSivi);
        }
    }
    class mandalina : narinciyeMeyve
    {
        public void SonucMandalina()
        {
            siviHesapla();

            vitAHesapla(681, nSivi);
            vitCHesapla(26, nSivi);

        }
    }
    class greyfurt : narinciyeMeyve
    {
        public void SonucGreyfurt()
        {
            siviHesapla();

            vitAHesapla(3, nSivi);
            vitCHesapla(44, nSivi);

        }
    }
    class armut : katiMeyve
    {
        public void SonucArmut()
        {
            siviHesapla();

            vitAHesapla(25, kSivi);
            vitCHesapla(5, kSivi);

        }
    }

    
}
