using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphersoft1_1
{
    public class Add
    {
        public Add()
        {



        }


        public void Adding()
        {

            string ime;
            string prezime;
            string adresa;
            string oib;

            Console.WriteLine("Ciphersoft1_1");
            Console.WriteLine("_______________");

            Console.WriteLine("\nUpišite Ime: ");
            ime = Console.ReadLine();

            Console.WriteLine("Upišite Prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("Upišite Adresu: ");
            adresa = Console.ReadLine();

            Console.WriteLine("Upišite OIB: ");
            oib = Console.ReadLine();

            string[] list = { ime, prezime, adresa, oib };

            Console.WriteLine("\nPonovo? Y/N");

            


            System.IO.File.AppendAllLines(@"C:\Users\Public\WriteLines.txt", list);

            if (Console.ReadLine().ToLower() == "y")
            {
                Adding();



            }

            else if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);




            }

        }




    }
}
