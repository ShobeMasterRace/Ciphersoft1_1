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


            //objekt koji sam napravio da bi ga koristio za 'if' statement
            var booz = Console.ReadKey();

            string path = @"C:\Users\Public\WriteLines.txt";
            string sve;



            if (booz.KeyChar == 'y')
            {

                sve = File.ReadAllText(path);
                Console.WriteLine("\n____________");
                Console.WriteLine(sve);



            }







            Console.ReadLine();
        }


    }
}
