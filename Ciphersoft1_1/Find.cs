using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ciphersoft1_1
{
    public class Find
    {
        public Find()
        {



        }

        public void finding()
        {
            string text = File.ReadAllText(@"C:\Users\Public\WriteLines.txt");

            string rijec;

            Console.WriteLine("Koju riječ želite pronaći?");
            rijec = Console.ReadLine();

            if (File.ReadAllText(@"C:\Users\Public\WriteLines.txt").Contains(rijec))
            {

                Console.WriteLine("\nPronašlo!");

            }

            else
            {
                Console.WriteLine("\nNe postoji, probajte drugu rijec?");
                finding();

            }



        }




    }
}
