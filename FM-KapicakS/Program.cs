using System;

namespace FM_Zviratka
{
    class Program
    {
        static void Main()
        {
            // Vytvoření několika zvířat pomocí tovární metody
            Zvire kachna = VytvorZvire.VytvorKachnu(6);
            Zvire kocka = VytvorZvire.VytvorKocku(2);
            Zvire krava = VytvorZvire.VytvorKravu(5);
            Zvire slepice = VytvorZvire.VytvorSlepici(12);

            // Výpis vlastností a zvuků zvířat
            Console.WriteLine($"{kachna.druhy} má {kachna.veky} roky a vydává zvuk:");
            kachna.VydatZvuk();
            Console.WriteLine($"{kocka.druhy} má {kocka.veky} roky a vydává zvuk:");
            kocka.VydatZvuk();
            Console.WriteLine($"{krava.druhy} má {krava.veky} roky a vydává zvuk:");
            krava.VydatZvuk();
            Console.WriteLine($"{slepice.druhy} má {slepice.veky} let a vydává zvuk:");
            slepice.VydatZvuk();

            Console.ReadKey();
        }
    }
}