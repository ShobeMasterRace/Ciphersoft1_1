using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Ciphersoft1_1
{
    public class Edit
    {
        public Edit()
        {


        }


        public void Editing()
        {

            //Stavljeno da se može poogledat svaki line i lakše odabere koji se želi promjenit
            //Process.Start(@"notepad.exe", @"C:\Users\Public\WriteLines2.txt");
            
            string text = File.ReadAllText(@"C:\Users\Public\WriteLines2.txt");
            Console.WriteLine(text);

            Console.WriteLine("Upišite koju stavku želite editat: ");
            string find = Console.ReadLine();

            Console.WriteLine("Upišite promjenu: ");
            string proba = Console.ReadLine();

            text = text.Replace(find, proba);

            File.WriteAllText(@"C:\Users\Public\WriteLines2.txt", text);

            Console.WriteLine("\nJoš neka izmjena? Y/N");

            if (Console.ReadLine().ToLower() == "y")
            {
                Editing();

            }

            else if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);

            }


        }


    }
}
