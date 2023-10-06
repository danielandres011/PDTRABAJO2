using System;

namespace PATRON.ADAPTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MedidorA medidorA = new MedidorA();
            medidorA.Lectura1();
            medidorA.Lectura2();

            MedidorB medidorB = new MedidorB();
            medidorB.Lectura1();
            medidorB.Lectura2();

            MacroMedidorAdapter macroMedidorAdapter = new MacroMedidorAdapter();
            macroMedidorAdapter.Lectura1();
            macroMedidorAdapter.Lectura2();
            macroMedidorAdapter.Lectura3();
            macroMedidorAdapter.Lectura4();
            macroMedidorAdapter.CalcularMecanico();

            Console.ReadKey();
        }
    }
}
