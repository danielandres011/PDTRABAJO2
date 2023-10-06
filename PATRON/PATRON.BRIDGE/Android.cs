using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.BRIDGE
{
    public class Android : Dispositivo
    {
        public void Imprimir()
        {
            Console.WriteLine("Android: Imprimiendo factura!");
        }
    }
}
