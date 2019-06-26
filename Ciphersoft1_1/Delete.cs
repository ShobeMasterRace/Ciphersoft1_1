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

        public void Deleting()
        {
            string path = @"C:\Users\Public\WriteLines.txt";
            string[] inputs;
            var booz = Console.ReadKey();
            string bris;

            inputs = File.ReadAllLines(path);


            for (int i = 0; i < inputs.Length; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Da li želite ovaj entry izbrisat?");
                    Console.WriteLine();
                    Console.WriteLine("{0}\n{1}\n{2}\n{3} ", inputs);

                    Console.WriteLine("_______________");
                    Console.WriteLine("Y / N");


                    //if (booz.KeyChar == 'y')
                    //{
                    //    List<string> delet = File.ReadAllLines(@"C:\Users\Public\WriteLines.txt").ToList();
                    //    if (delet.Count == 0)
                    //    {
                    //        throw new Exception("Data Empty!");
                    //    }

                    //    else
                    //    {
                    //        string firstItem = delet[0];
                    //        delet.RemoveAt(0);
                    //        delet.RemoveAt(1);
                    //        delet.RemoveAt(2);
                    //        delet.RemoveAt(3);


                    //    }




                    //    break;

                    //}

                    //break;



                }

            }
            //Console.WriteLine(inputs[0]);
            //Console.WriteLine(inputs[1]);
            //Console.WriteLine(inputs[2]);
            //Console.WriteLine(inputs[3]);


        }
    }
}
