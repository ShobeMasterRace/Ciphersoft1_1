using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Ciphersoft1_1
{
    public class Add  : LoadSave
    {


        public Add()
        {






        }


        public void Adding()
        {
            Load();

            Users users = new Users { Ime = Console.ReadLine(), Prezime = Console.ReadLine(), Adresa = Console.ReadLine(), Oib = Console.ReadLine() };
             
            Console.WriteLine("\nOvaj User je spremljen" + " " + users.Ime);

            DataList.Add(users);
            Save();
            

  


        }

            

    }
}
