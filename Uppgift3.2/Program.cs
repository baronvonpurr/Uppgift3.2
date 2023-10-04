using System;

namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut ur gymnasiet?");
            Console.WriteLine("J för Ja, N för Nej");
            string gymnasiet = Console.ReadLine().ToUpper();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiet == "J" && ålder <= 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
                Console.ReadKey();
            }
        }
    }
}