using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStrategy
{
    internal class Aviao : IMeioTransporte
    {
        public void Mover()
        {
            Console.WriteLine("O avião voa.");
        }
    }
}
