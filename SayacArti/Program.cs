using System;

namespace SayacArti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string gir");
            string gelen = Console.ReadLine();
            Console.WriteLine("Sayaç kaç haneli olsun.. 5'e kadar olan bir sayı girin");
            int donus = Convert.ToInt32(Console.ReadLine());

            StringSayac stringSayac = new StringSayac();
            stringSayac.Sayac(gelen, donus);
        }
    }
}
