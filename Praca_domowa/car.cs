using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_domowe
{
    class Car
    {

        private int rokProdukcji;
        private string marka;

        private String model;
        private int iloscDrzwi;
        private double srednieSpalanie;

        public Car(int rokProdukcji, string marka)
        {
            if (rokProdukcji <= 1769 || rokProdukcji >= 2017)
                throw new ArgumentException("zly rok produkcji");

            this.rokProdukcji = rokProdukcji;
            this.marka = marka;
        }

        override
        public String ToString()
        {
            return ("rok: " + rokProdukcji + " marka: " + marka);
        }

        public double obliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return obliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        private double obliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }

    }
}
