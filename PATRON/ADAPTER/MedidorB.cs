using System;

namespace PATRON.ADAPTER
{
    public class MedidorB : Medidor
    {
        public override void Lectura1()
        {
            Console.WriteLine("MedidorB: Lectura 1");
        }

        public override void Lectura2()
        {
            Console.WriteLine("MedidorB: Lectura 2");
        }
        public override void CalcularMecanico()
        {
            Console.WriteLine("MedidorB: Calculando medida mecánica.");
        }
    }
}