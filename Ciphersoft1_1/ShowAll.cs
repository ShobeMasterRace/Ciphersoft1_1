using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ciphersoft1_1
{
    public class ShowAll
    {
        public static List<Users> Users = new List<Users>();

        public ShowAll()
        {



        }

        public void ShowsAll()
        {
            Add ps = new Add();
            ps.Adding();

            Users mlem = JsonConvert.DeserializeObject<Users>(mlem);

            String Name = mlem.Ime;
            String Surname = mlem.Prezime;
            String Address = mlem.Adresa;
            String SSN = mlem.Oib;









































            //Add prob = new Add();
            //prob.Adding();

            //Console.WriteLine("\nStisni Y za cijelu listu: ");






            //if (Console.ReadLine().ToLower() == "y")
            //{

            //    using (StreamReader file = new StreamReader(@"C:\Users\Public\WriteLines2.txt"))
            //    {
            //        Console.WriteLine(file);
            //    }



            //}







            //Console.ReadLine();
        }


    }
}
