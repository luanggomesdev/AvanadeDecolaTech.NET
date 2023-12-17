﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCelular.Models
{
    internal class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
       




        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativos {nome} no Nokia");
        }




    }
}
