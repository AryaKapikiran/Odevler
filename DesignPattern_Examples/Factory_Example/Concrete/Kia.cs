﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example.Concrete
{
    public class Kia : Araba
    {
        public override void Marka()
        {
            Console.WriteLine("Bu arabanın markası Kia");
        }
    }
}