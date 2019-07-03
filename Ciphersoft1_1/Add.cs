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



            string spremi = JsonConvert.SerializeObject(users); //serrialize-a objekt (Ime, Prezime, Adresa, Oib) u JSON
            Console.WriteLine("\nOvaj User je spremljen" + " " + spremi);

            Lista test = new Lista();
            List<string> Lista2 = test.Alist;
            Lista2.Add(spremi);
            



            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\WriteLines2.txt", true)) //Sad se lista append-a u text file-u, (tocnije to radi value 'true')
            {
                file.Write(spremi + "\n");

            }

            


            Console.WriteLine("\nPonovo? Y/N");

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
