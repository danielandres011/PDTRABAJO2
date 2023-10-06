using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.BRIDGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivoAndroid = new Android();
            Dispositivo dispositivoIphone = new Iphone();

            Impresora ZQ420Android = new ZQ420Impresora(dispositivoAndroid);
            Impresora ZQ521Iphone = new ZQ521Impresora(dispositivoIphone);

            ZQ420Android.Conectar();
            ZQ420Android.Desconectar();

            ZQ521Iphone.Conectar();
            ZQ521Iphone.Desconectar();

            Console.ReadKey();
        }
    }
}
