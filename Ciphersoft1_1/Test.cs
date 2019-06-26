using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ciphersoft1_1
{
    class Test
    {
        public Test()
        {




        }


        public void testing()
        {

            string path = @"C:\Users\Public\WriteLines.txt";
            string[] inputs;

            inputs = File.ReadAllLines(path);
            Console.WriteLine("{0}\n{1}\n{2}\n{3} ", inputs);

            Console.WriteLine(inputs);

        }


    }
}
