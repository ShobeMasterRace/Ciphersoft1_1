using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ciphersoft1_1
{
    public class Delete
    {

        public Delete()
        {



        }

        public string Deleting()
        {
            //IZBRISATI SVE
            //Console.WriteLine("Sve izbrisano");
            //File.WriteAllText(@"C:\Users\Public\WriteLines2.txt", String.Empty);

            List<string> tekst = File.ReadAllLines(@"C:\Users\Public\WriteLines2.txt").ToList();

            string text = File.ReadAllText(@"C:\Users\Public\WriteLines2.txt");
            Console.WriteLine(text);

            string firstItem = tekst[0];
            //quotelist.RemoveAt(Console.ReadLine()); //mislio sam tu stavit if statement ovisno o tome šta se upiše da tako izbriše red, ali razmišljam kako da stavim to generički

            File.WriteAllLines(@"C:\Users\Public\WriteLines2.txt", tekst.ToArray());
            return firstItem;

        }
    }
}
