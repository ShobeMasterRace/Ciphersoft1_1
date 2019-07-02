using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Ciphersoft1_1
{
    public class Add
    {


        public Add()
        {






        }


        public void Adding()
        {
            Users users = new Users { Ime = Console.ReadLine(), Prezime = Console.ReadLine(), Adresa = Console.ReadLine(), Oib = Console.ReadLine() };
            
            ShowAll.Users.Add(users);

            string spremi = JsonConvert.SerializeObject(users);
            Console.WriteLine(spremi);


            using (StreamWriter file = File.CreateText(@"C:\Users\Public\WriteLines2.txt"))
            {
                file.Write(spremi);
            }
            




            //    Users test = new Users();



            //    string ime = test.Ime;
            //    string prezime = test.Prezime;
            //    string adresa = test.Adresa;
            //    string oib = test.Oib;

            //    Console.WriteLine("Ciphersoft1_1");
            //    Console.WriteLine("_______________");

            //    Console.WriteLine("\nUpišite Ime: ");
            //    ime = Console.ReadLine();

            //    Console.WriteLine("Upišite Prezime: ");
            //    prezime = Console.ReadLine();

            //    Console.WriteLine("Upišite Adresu: ");
            //    adresa = Console.ReadLine();

            //    Console.WriteLine("Upišite OIB: ");
            //    oib = Console.ReadLine();

            //    string[] proba = { ime, prezime, adresa, oib };

            //    Console.WriteLine("\nPonovo? Y/N");


            //    System.IO.File.AppendAllLines(@"C:\Users\Public\WriteLines.txt", proba);

            //    if (Console.ReadLine().ToLower() == "y")
            //    {
            //        Adding();



            //    }

            //    else if (Console.ReadLine().ToLower() == "n")
            //    {
            //        Environment.Exit(0);




            //    }

            //}


        }

    }
}
