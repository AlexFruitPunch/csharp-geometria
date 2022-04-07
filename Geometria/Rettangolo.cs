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
            //disegno base alta del rettangolo
            for(int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("--");
            }
            //disegno altezza sinistra e destra insieme
            for (int i = 0; i < altezzaRettangolo; i++)
            {
                if (i == 0)
                {
                    Console.Write("\n|");
                }
                else
                {
                    Console.Write("|");
                }
                for (int ind = 0; ind < baseRettangolo; ind++)
                    {
                        if (ind < (baseRettangolo - 1))
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write("|\n");
                        }
                    }
                
            }
            //disegno l'altra base del Rettangolo
            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("--");
            }
        }
    }
}

    