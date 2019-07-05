using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ispitivac
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSet GS = new GetSet { Ime = Console.ReadLine(), Prezime = Console.ReadLine(), ID = Console.ReadLine(), BrojKartice = Console.ReadLine() };

            string proba = JsonConvert.SerializeObject(GS);

            List.DataList.Add(GS.Ime);
            List.DataList.Add(GS.Prezime);
            List.DataList.Add(GS.ID);
            List.DataList.Add(GS.BrojKartice);


            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\WriteLines3.txt", true))
            {
                file.Write(proba + "\n");

            }

            Console.WriteLine("Total elements: {0}", List.DataList.Count);
            List.DataList.ForEach(Console.WriteLine);

        }
    }
}
