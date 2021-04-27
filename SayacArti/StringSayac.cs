using System;
using System.Collections.Generic;
using System.Text;

namespace SayacArti
{
    public class StringSayac
    {


        public void Sayac(string gelen, int donus)
        {
            Console.Clear();

            int uzunluk = gelen.Length;
            Console.WriteLine();


            if (donus == 2)
            {
                for (int i = uzunluk; i < 10; i++)
                {
                    if (donus < 10)
                    {

                        Console.WriteLine(i);
                    }
                    System.Threading.Thread.Sleep(1000);
                    if (i == donus)
                    {
                        Console.WriteLine(donus);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }

            else if (donus == 3)
            {
                for (int i = uzunluk; i < 100; i++)
                {
                    if (i < 10)
                    {
                        Console.WriteLine("00" + i);

                    }
                    if (i >= 10 && i < 100)
                    {
                        Console.WriteLine("0" + i);
                    }
                    System.Threading.Thread.Sleep(1000);

                    if (i == donus)
                    {
                        Console.WriteLine(donus);
                        break;
                    }

                    else
                    {
                        Console.Clear();
                    }
                }
            }
            else if (donus == 4)
            {
                for (int i = uzunluk; i < 1000; i++)
                {
                    if (i < 10)
                    {
                        Console.WriteLine("000" + i);
                    }

                    if (i >= 10 && i < 100)
                    {
                        Console.WriteLine("00" + i);
                    }

                    if (i >= 100 && i < 1000)
                    {
                        Console.WriteLine("0" + i);
                    }

                    System.Threading.Thread.Sleep(1000);

                    if (i == donus)
                    {
                        Console.WriteLine(donus);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }

            else if (donus == 5)
            {
                for (int i = uzunluk; i < 10000; i++)
                {
                    if (i < 10)
                    {
                        Console.WriteLine("0000" + i);

                    }
                    if (i >= 10 && i < 100)
                    {
                        Console.WriteLine("000" + i);
                    }

                    if (i >= 100 && i < 1000)
                    {
                        Console.WriteLine("00" + i);
                    }

                    System.Threading.Thread.Sleep(1000);
                    if (i == donus)
                    {
                        Console.WriteLine(donus);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
        }
    }
}
