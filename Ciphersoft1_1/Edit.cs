using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace Ciphersoft1_1
{
    public class Edit : LoadSave
    {
        public Edit()
        {

            Load();

        }



        public void Editing()
        {
            Console.WriteLine("Upiši Oib User-a: ");
            string nadi = Console.ReadLine(); //nadi user-a


            Users userZaEdit = DataList.FirstOrDefault(a => a.Oib == nadi);

            if (userZaEdit != null)
            {
                Console.WriteLine("User pronađen: " + userZaEdit.ToString());
                Console.WriteLine("Upiši koji dio želiš promjeniti: ");

                string imeVarijable = Console.ReadLine();

                Console.WriteLine("Koju vrijednost želiš staviti? ");
                string vrijednostVarijable = Console.ReadLine();

                switch (imeVarijable)
                {
                    case "Ime":
                        userZaEdit.Ime = vrijednostVarijable;
                        break;
                    case "Prezime":
                        userZaEdit.Prezime = vrijednostVarijable;
                        break;
                    case "Adresa":
                        userZaEdit.Adresa = vrijednostVarijable;
                        break;
                    default:
                        break;

                }

                Save();


                //if(imeVarijable == "Ime")
                //{
                //    userZaEdit.Ime = vrijednostVarijable;
                //}
                //else if(imeVarijable == "Prezime")
                //{
                //    userZaEdit.Prezime = vrijednostVarijable;
                //}
                //else if(imeVarijable == "Adresa")
                //{
                //    userZaEdit.Adresa = vrijednostVarijable;
                //}
                // Isto kao switch 


            }




            
            //for(int i = 0; i < DataList.Count; i++)
            //{
            //    if(DataList[i].Oib == nadi)
            //    {
            //        // aafda


            //        break;
            //    }
            //}
            //   Isto šta i FirstOrDefault



        }


    }
}
