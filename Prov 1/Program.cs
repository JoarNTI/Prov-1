using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Välkommen till Sänka Skepp");

            while (i > 0)
            {
                Console.WriteLine("Välj en kordinat mellan [1-10]");

                {
                    string a = Console.ReadLine();
                    if (a == "7")
                    {
                        Console.WriteLine("Hit!");
                        i -= 1;
                    }
                    else if (a == "1" | a == "2" | a == "3" | a == "4" | a == "5" | a == "6" | a == "8" | a == "9" | a == "10")
                    {
                        Console.WriteLine("Miss!");

                    }
                    else if (a != "1" | a != "2" | a != "3" | a != "4" | a != "5" | a != "6" | a != "7" | a != "8" | a != "9" | a != "10")
                    {
                        Console.WriteLine("Inte ett tal, försök igen");
                    }


                    Console.ReadLine();




                }
            }

        }
    }
}







