using System;

namespace EnumExample
{
    class Program
    {
        enum DniTygodnia
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }

        enum EtapyPrania
        {
            Wypelnianie,
            Pranie,
            Plukanie,
            Suszenie
        }

        enum PosilkiDnia
        {
            Sniadanie,
            DrugieSniadanie,
            Obiad,
            Podwieczorek,
            Kolacja
        }

        enum BierkiSzachowe
        {
            Pion,
            Wieza,
            Skoczek,
            Goniec,
            Hetman,
            Krol,
            PionPromocja_Wieza = Pion + 10,
            PionPromocja_Skoczek = Pion + 11,
            PionPromocja_Goniec = Pion + 12,
            PionPromocja_Hetman = Pion + 13
        }

        static void Main(string[] args)
        {
            // Przykłady użycia zdefiniowanych typów wyliczeniowych
            DniTygodnia dzien = DniTygodnia.Sroda;
            Console.WriteLine("Dzisiejszy dzień tygodnia: " + dzien);

            EtapyPrania etap = EtapyPrania.Pranie;
            Console.WriteLine("Aktualny etap prania: " + etap);

            PosilkiDnia posilek = PosilkiDnia.Kolacja;
            Console.WriteLine("Dzisiejszy posiłek: " + posilek);

            BierkiSzachowe bierka = BierkiSzachowe.Wieza;
            Console.WriteLine("Wybrana bierka szachowa: " + bierka);

            BierkiSzachowe promocja = BierkiSzachowe.PionPromocja_Wieza;
            Console.WriteLine("Bierka po promocji piona: " + promocja);

            Console.ReadLine();
        }
    }
}