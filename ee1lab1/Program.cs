using System;

namespace ee1lab1
{
    class MainClass
    {
        /*
         * Scrieti un program care va calcula media aritmetica a trei numere citite de la
         * tastatura
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valorile pentru a calcula media aritmetica");

            int valoarePrimuluiNumar = int.Parse(Console.ReadLine());
            int valoareAlDoileaNumar = int.Parse(Console.ReadLine());
            int valoareaAlTreileaNumar = int.Parse(Console.ReadLine());

            int mediaAritmetica = (valoarePrimuluiNumar + valoareAlDoileaNumar + valoareaAlTreileaNumar) / 3;
            Console.WriteLine("media aritmetica: " + mediaAritmetica);
        }
    }
}
