using System;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite datum pocetka osiguranja u formatu DD.MM.GGGG: ");
            string DatumPocetka = Console.ReadLine();
            DateTime DatumPocetkaOsiguranja = DateTime.ParseExact(DatumPocetka, "dd.MM.yyyy", null);
            Console.WriteLine("Uneli ste datum: " + DatumPocetkaOsiguranja);
            Console.Write("Unesite presecni datum u formatu DD.MM.GGGG: ");
            string Presecni = Console.ReadLine();
            DateTime DatumPreseka = DateTime.ParseExact(Presecni, "dd.MM.yyyy", null);
            Console.WriteLine("Uneli ste datum: " + DatumPreseka);
            //DateTime DatumPocetkaOsiguranja = new DateTime(2007, 03, 12);
            //DateTime DatumPreseka = new DateTime(2007, 07, 23);
            Console.WriteLine("Unesite nacin placanja 1 za MESECNO, 2 za KVARTALNO, 3 za POLUGODISNJE, 4 za GODISNJE ");
            string nacin = Console.ReadLine();
            TimeSpan razlika = DatumPreseka - DatumPocetkaOsiguranja;
            int izmedjuDana = razlika.Days;
            int nacinPlacanja = int.Parse(nacin); 

            if (nacinPlacanja == 1)
            {
                int rata = 30;
                int brojRata = izmedjuDana / rata;
                Console.WriteLine($"Broj rata je: {brojRata}");
                DateTime pretposlednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 1);
                DateTime poslednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 1 + 1 * 1);
                Console.WriteLine($"Datum pretposlednje rate je: {pretposlednjaRata}");
                Console.WriteLine($"Datum poslednje rate je: {poslednjaRata}");
                int daniTekuceRate = (DatumPreseka - pretposlednjaRata).Days;
                int preostaliDani = (poslednjaRata - DatumPreseka).Days;
                Console.WriteLine($"Broj dana u tekucoj rati je: {daniTekuceRate + preostaliDani}");
                Console.WriteLine($"Broj preostalih dana je: {preostaliDani}");
            }
            //kvartalno
            if (nacinPlacanja == 2)
            {
                int rata = 3 * 30;
                int brojRata = izmedjuDana / rata;
                Console.WriteLine($"Broj rata je: {brojRata}");
                DateTime pretposlednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 3);
                DateTime poslednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 3 + 1 * 3);
                Console.WriteLine($"Datum pretposlednje rate je: {pretposlednjaRata}");
                Console.WriteLine($"Datum poslednje rate je: {poslednjaRata}");
                int daniTekuceRate = (DatumPreseka - pretposlednjaRata).Days;
                int preostaliDani = (poslednjaRata - DatumPreseka).Days;
                Console.WriteLine($"Broj dana u tekucoj rati je: {daniTekuceRate + preostaliDani}");
                Console.WriteLine($"Broj preostalih dana je: {preostaliDani}");
            }
            //polugodisnje
            if (nacinPlacanja == 3)
            {
                int rata = 6 * 30;
                int brojRata = izmedjuDana / rata;
                Console.WriteLine($"Broj rata je: {brojRata}");
                DateTime pretposlednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 6);
                DateTime poslednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 6 + 1 * 6);
                Console.WriteLine($"Datum pretposlednje rate je: {pretposlednjaRata}");
                Console.WriteLine($"Datum poslednje rate je: {poslednjaRata}");
                int daniTekuceRate = (DatumPreseka - pretposlednjaRata).Days;
                int preostaliDani = (poslednjaRata - DatumPreseka).Days;
                Console.WriteLine($"Broj dana u tekucoj rati je: {daniTekuceRate + preostaliDani}");
                Console.WriteLine($"Broj preostalih dana je: {preostaliDani}");
            }
            //godisnje
            if (nacinPlacanja == 4)
            {
                int rata = 12 * 30;
                int brojRata = izmedjuDana / rata;
                Console.WriteLine($"Broj rata je: {brojRata}");
                DateTime pretposlednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 12);
                DateTime poslednjaRata = DatumPocetkaOsiguranja.AddMonths(brojRata * 12 + 1 * 12);
                Console.WriteLine($"Datum pretposlednje rate je: {pretposlednjaRata}");
                Console.WriteLine($"Datum poslednje rate je: {poslednjaRata}");
                int daniTekuceRate = (DatumPreseka - pretposlednjaRata).Days;
                int preostaliDani = (poslednjaRata - DatumPreseka).Days;
                Console.WriteLine($"Broj dana u tekucoj rati je: {daniTekuceRate + preostaliDani}");
                Console.WriteLine($"Broj preostalih dana je: {preostaliDani}");
            }
        }
    }
}
