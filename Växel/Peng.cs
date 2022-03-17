using System;
//jessika gyllström jesgyl-0
//Inlämning 2 L0002B
namespace Peng
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program som räknar ut hur mycket växel man får tillbaka
            //1: Be användaren skriva in pris
            //2: Be användaren skriva in given summa
            //3: Räkna ut hur många av de olika valörerna som skall ges tillbaka
            //4: Skriv ut resultatet av växel tillbaka
           
            //Skapar variabler för pris och mottaget belopp
            int pris;
            int mottaget;

            //skapar while-loop
            while (true)
            {

                Console.Write("Ange Pris: ");
                pris = int.Parse(Console.ReadLine());

                Console.Write("Mottaget belopp: ");
                mottaget = int.Parse(Console.ReadLine());
                //om mottagen summa är mindre än än priset avbryts loopen
                if (mottaget <= pris)
                {
                    Console.WriteLine("Fel inmatning, testa igen");
                    break;
                }
                int tillbaka = mottaget - pris;

                //räknar ut hur mycket av varje valör som skall ges tillbaka
                int femhundra = tillbaka / 500;
                int v = tillbaka % 500;

                int hundra = v / 100;
                v = v % 100;

                int femtio = v / 50;
                v = v % 50;

                int tjugo = v / 20;
                v = v % 20;

                int tio = v / 10;
                v = v % 10;

                int fem = v / 5;
                v = v % 5;

                int en = v / 1;
                v = v % 1;

                //Skriv ut hur mycket växel som ges tillbaka
                if (femhundra > 0)
                {
                    Console.WriteLine("500-lappar: {0}", femhundra);
                }
                if (hundra > 0)
                {
                    Console.WriteLine("100-lappar: {0}", hundra);
                }
                if (femtio > 0)
                {
                    Console.WriteLine("50-lappar: {0}", femtio);
                }
                if (tjugo > 0)
                {
                    Console.WriteLine("20-lappar: {0}", tjugo);
                }
                if (tio > 0)
                {
                    Console.WriteLine("10-kronor: {0}", tio);
                }
                if (fem > 0)
                {
                    Console.WriteLine("5-kronor: {0}", fem);
                }
                if (en > 0)
                {
                    Console.WriteLine("1-kronor: {0}", en);
                }
            }
        }
    }
}