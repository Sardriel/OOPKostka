using System;

namespace OOPKostka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kostka kostkaJedna = new Kostka();
            Kostka kostkaDva = new Kostka();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Na první kostce padlo {0}", kostkaJedna.hod());
                Console.WriteLine("Na druhé kostce padlo {0}", kostkaDva.hod());
            }
            

        }
    }
}
