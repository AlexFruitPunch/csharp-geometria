using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public void StampaRettangolo(int NumRettangoli)
        {
            Console.WriteLine("--- Rettangolo " + NumRettangoli + " ----\n");
            Console.WriteLine("Base: " + baseRettangolo + " cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + CalcolaArea() + " cm²");
        }

        public int CalcolaArea()
        {
            int Area;
            Area = baseRettangolo * altezzaRettangolo;
            return Area;
        }
        public int CalcolaPerimetro()
        {
            int Perimetro;
            Perimetro = (baseRettangolo + altezzaRettangolo) * 2 ;
            return Perimetro;
        }
        public void Disegna()
        {

        }
    }
}

    