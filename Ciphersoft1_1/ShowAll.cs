using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Lista test = new Lista();
            List<string> Lista2 = test.Alist;

            Console.Write("Total elements: {0}", Lista2.Count);

        }


    }
}
