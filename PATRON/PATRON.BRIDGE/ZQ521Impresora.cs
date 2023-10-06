using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.BRIDGE
{
    public class ZQ521Impresora : Impresora
    {
        public ZQ521Impresora(Dispositivo dispositivo) : base(dispositivo)
        {

        }

        public override void Conectar()
        {
            Console.WriteLine("ZQ420: Conectada!");
            this._dispositivo.Imprimir();
        }

        public override void Desconectar()
        {
            Console.WriteLine("ZQ420: Desconectada!");
        }
    }
}
