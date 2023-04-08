using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUkol
{
    internal class Heslo
    {
        private static bool JeCislo(char pismeno)
        {
            int UTF16_code = (int)pismeno;
            return UTF16_code >= 48 && UTF16_code <= 57;
        }

        private static bool JeVelkePismeno(char pismeno)
        {
            int UTF16_code = (int)pismeno;
            return UTF16_code >= 65 && UTF16_code <= 90;
        }

        private bool MaSpravnouDelku(int delka) => this.heslo.Length >= delka;
        private bool MaCislo()
        {
            foreach (char pismeno in this.heslo)
            {
                if (JeCislo(pismeno))
                    return true;
            }
            return false;
        }

        private bool MaVelkePismeno()
        {
            foreach (char pismeno in this.heslo)
            {
                if (JeVelkePismeno(pismeno))
                    return true;
            }
            return false;
        }

        private bool NeobsahujeStejnePsm()
        {
            for (int i = 0; i < this.heslo.Length - 1; i++)
            {
                if (this.heslo[i] == this.heslo[i + 1])
                    return false;
            }
            return true;   
        }

        private string heslo = "";
        private string NactiHeslo()
        {
            Console.Write("Zadej heslo: ");
            return Console.ReadLine();
        }

        private void Otestuj()
        {
            if (!MaSpravnouDelku(8))
                Console.WriteLine("Moc kratke!");
            else if (!MaCislo())
                Console.WriteLine("Musi mit cislo!");
            else if (!MaVelkePismeno())
                Console.WriteLine("Musi mit VELKE pismeno!");
            else if (!NeobsahujeStejnePsm())
                Console.WriteLine("Zadna 2 stejna pismena za sebou!");
            else
                Console.WriteLine("Heslo splňuje všechna kritéria.");
        }

        public Heslo()
        {
            this.heslo = NactiHeslo();
            Otestuj();
        }
    }
}
