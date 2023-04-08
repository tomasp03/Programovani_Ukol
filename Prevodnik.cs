using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgUkol
{
    internal class Prevodnik
    {
        private int zakladZ;
        private int zakladDo;
        private string Vysledek = "";

        private int Pow(int zaklad, int exponent)
        {
            if (exponent == 0)
                return 1;

            return zaklad * Pow(zaklad, exponent - 1);
        }

        private int DoDesitkove(int cislo, int iterator)
        {
            if (cislo == 0)
                return 0;

            return cislo % 10 * Pow(this.zakladZ, iterator) + DoDesitkove(cislo / 10, iterator + 1);
        }

        private string DoPozadovane(int cislo)
        {
            if (cislo == 0)
                return "";

            return DoPozadovane(cislo / this.zakladDo) + (cislo % this.zakladDo).ToString();
        }

        public Prevodnik(int prevadene, int zakladZ, int zakladDo)
        {
            this.zakladZ = zakladZ;
            this.zakladDo = zakladDo;
            this.Vysledek = DoPozadovane(DoDesitkove(prevadene, 0));
            Console.WriteLine(this.Vysledek);
        }
    }
}
