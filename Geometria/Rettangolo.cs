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

        public void StampaRettangolo()
        {
            Console.WriteLine("La base del mio rettangolo è: " + baseRettangolo);
            Console.WriteLine("l'altezza del mio rettangolo è: " + altezzaRettangolo);
        }
    }
}

    