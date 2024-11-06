using System;

namespace FM_Zviratka
{
    // Abstraktní třída Zvire s metodami a vlastnostmi, které budou společné pro všechna zvířata
    public abstract class Zvire
    {
        public string druhy { get; protected set; }
        public int veky { get; set; }

        // Konstruktor pro nastavení druhu zvířete a věku
        public Zvire(string druh, int vek)
        {
            druhy = druh;
            veky = vek;
        }

        // Abstraktní metoda pro vydávání zvuku
        public abstract void VydatZvuk();
    }

    // Třída Pes
    public class Pes : Zvire
    {
        public Pes(int vek) : base("Pes", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Woof");
        }
    }

    // Třída Kočka
    public class Kocka : Zvire
    {
        public Kocka(int vek) : base("Kočka", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Mňau");
        }
    }

    // Třída Kráva
    public class Krava : Zvire
    {
        public Krava(int vek) : base("Krava", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Mooo");
        }
    }

    // Třída Kůň
    public class Kun : Zvire
    {
        public Kun(int vek) : base("Kůň", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Ihá!");
        }
    }

    // Třída Ovečka
    public class Ovecka : Zvire
    {
        public Ovecka(int vek) : base("Ovečka", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Bé");
        }
    }

    // Třída Prase
    public class Prase : Zvire
    {
        public Prase(int vek) : base("Prase", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Chro!");
        }
    }

    // Třída Králík
    public class Kralik : Zvire
    {
        public Kralik(int vek) : base("Králík", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("TSTSTS");
        }
    }

    // Třída Slepice
    public class Slepice : Zvire
    {
        public Slepice(int vek) : base("Slepice", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Puaaap");
        }
    }

    // Třída Husa
    public class Husa : Zvire
    {
        public Husa(int vek) : base("Husa", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Gu gu gu");
        }
    }

    // Třída Kachna
    public class Kachna : Zvire
    {
        public Kachna(int vek) : base("Kachna", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Kač kač");
        }
    }
}