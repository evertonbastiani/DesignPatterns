﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStrategy
{
    internal class Barco : IMeioTransporte
    {
        public void Mover()
        {
            Console.WriteLine("O barco navega.");
        }
    }
}
