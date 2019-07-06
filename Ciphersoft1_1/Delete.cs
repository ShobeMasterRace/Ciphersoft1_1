using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ciphersoft1_1
{
    public class Delete : LoadSave
    {

        public Delete()
        {



        }

        public void Deleting()
        {
            string oib = ""; // Console.readline...

            Load();
            Users userZaBrisanje = DataList.FirstOrDefault(user => user.Oib == oib);
            if(userZaBrisanje != null)
            {
                DataList.Remove(userZaBrisanje);
                Save();
            }

        }
    }
}
