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
            //NAPRAVITI TAKO DA DELETE CLASS-a ČEKA BAREM 3 ENTRY-A IZ ADD KLASE
            



        }


        public string testing()
        {

            List<string> delet = File.ReadAllLines(@"C:\Users\Public\WriteLines.txt").ToList();
            string blab = delet[0];
            delet.RemoveAt(0);
  
            File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", delet.ToArray());
            return blab;
        }


    }
}
