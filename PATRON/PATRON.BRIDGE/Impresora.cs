using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.BRIDGE
{
    public abstract class Impresora
    {
        protected Dispositivo _dispositivo;

        public Impresora(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public abstract void Conectar();

        public abstract void Desconectar();
    }
}
