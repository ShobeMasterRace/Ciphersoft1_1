using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ciphersoft1_1
{
    public class Users
    {


        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Oib { get; set; }



        public override string ToString()
        {
            return Ime + " " + Prezime + ", OIB: " + Oib + ", Adresa: " + Adresa;
        }
    }







}

