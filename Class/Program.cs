using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "MURO";
            kurs1.İzlenmeOrani = 20;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "beko";
            kurs2.İzlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "unity";
            kurs3.Egitmen = "ceto";
            kurs3.İzlenmeOrani = 20;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }
        }
    }
}