using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ciphersoft1_1
{
    public class ShowAll
    {
        public ShowAll()
        {



        }

        public void ShowsAll()
        {
            Console.WriteLine("\nStisni Y za cijelu listu: ");



            string path = @"C:\Users\Public\WriteLines.txt";
            string sve;



            if (Console.ReadLine().ToLower() == "y")
            {

                sve = File.ReadAllText(path);
                Console.WriteLine("\n____________");
                Console.WriteLine(sve);



            }







            Console.ReadLine();
        }


    }
}
