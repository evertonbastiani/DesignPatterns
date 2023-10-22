using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStrategy
{
    internal class Onibus : IMeioTransporte
    {
        public void Mover()
        {
            Console.WriteLine("O ônibus anda.");
        }
    }
}
