using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.BRIDGE
{
    public class ZQ420Impresora : Impresora
    {
        public ZQ420Impresora(Dispositivo dispositivo) : base(dispositivo)
        {

        }

        public override void Conectar()
        {
            Console.WriteLine("ZQ521: Conectada!");
            this._dispositivo.Imprimir();
        }

        public override void Desconectar()
        {
            Console.WriteLine("ZQ521: Desconectada!");
        }
    }
}
