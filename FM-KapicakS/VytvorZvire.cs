using System;

namespace FM_Zviratka
{
    // Tovární třída pro vytváření instancí konkrétních zvířat
    public class VytvorZvire
    {
        public static Zvire VytvorPsa(int vek)
        {
            return new Pes(vek);
        }

        public static Zvire VytvorKocku(int vek)
        {
            return new Kocka(vek);
        }

        public static Zvire VytvorKravu(int vek)
        {
            return new Krava(vek);
        }

        public static Zvire VytvorKone(int vek)
        {
            return new Kun(vek);
        }

        public static Zvire VytvorOvecka(int vek)
        {
            return new Ovecka(vek);
        }

        public static Zvire VytvorPrase(int vek)
        {
            return new Prase(vek);
        }

        public static Zvire VytvorKralika(int vek)
        {
            return new Kralik(vek);
        }

        public static Zvire VytvorSlepici(int vek)
        {
            return new Slepice(vek);
        }

        public static Zvire VytvorHusu(int vek)
        {
            return new Husa(vek);
        }

        public static Zvire VytvorKachnu(int vek)
        {
            return new Kachna(vek);
        }
    }
}