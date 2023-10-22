using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStrategy
{
    internal class MeioTransporte
    {
        private readonly TipoMeioTransporte _tipoMeioTransporte;

        public MeioTransporte(TipoMeioTransporte tipoMeioTransporte)
        {
            _tipoMeioTransporte = tipoMeioTransporte;
        }

        public void Mover()
        {
            if(_tipoMeioTransporte == TipoMeioTransporte.Onibus)
            {
                Console.WriteLine("O ônibus anda.");
            }
            if (_tipoMeioTransporte == TipoMeioTransporte.Aviao)
            {
                Console.WriteLine("O avião voa.");
            }
            if (_tipoMeioTransporte == TipoMeioTransporte.Barco)
            {
                Console.WriteLine("O barco navega.");
                //ferra toda a classe
            }

        }
    }
}
