using System;

namespace PATRON.ADAPTER
{
    public class MedidorA : Medidor
    {
        public override void Lectura1()
        {
            Console.WriteLine("MedidorA: Lectura 1");
        }

        public override void Lectura2()
        {
            Console.WriteLine("MedidorA: Lectura 2");
        }
        public override void CalcularMecanico()
        {
            Console.WriteLine("MedidorA: Calculando medida mecánica.");
        }

    }
}