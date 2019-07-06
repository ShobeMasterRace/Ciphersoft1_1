using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Ciphersoft1_1
{
    public abstract class LoadSave
    {

        public static List<Users> DataList = new List<Users>();



        public static void Save()
        {

            try
            {
                string JSON = JsonConvert.SerializeObject(DataList);
                File.WriteAllText(@"C:\Users\Public\WriteLines2.txt", JSON);
                // [ ... ] - nalazi se u array
                // { .. } - nalazi se u objektu
                // [ {} , {}, {} ]
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }





        public static void Load()
        {
        

            if (File.Exists(@"C:\Users\Public\WriteLines2.txt"))
            {

                try
                {

                    string JSON = File.ReadAllText(@"C:\Users\Public\WriteLines2.txt"); // prvo lodamo json

                    DataList = JsonConvert.DeserializeObject<List<Users>>(JSON); // ovo converta string u listu sa objektima (userima)


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } 
        }



    }
}
