using System.Net.NetworkInformation;

namespace ProjectStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MeioTransporte meioTransporte = new MeioTransporte(TipoMeioTransporte.Aviao);
            //meioTransporte.Mover();

            //meioTransporte = new MeioTransporte(TipoMeioTransporte.Onibus);
            //meioTransporte.Mover();

            IMeioTransporte meioTransporte = new Aviao();
            meioTransporte.Mover();

            meioTransporte = new Barco();
            meioTransporte.Mover();

            Console.ReadLine();     
        }
    }


   
}