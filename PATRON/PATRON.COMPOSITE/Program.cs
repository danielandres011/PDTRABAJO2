using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMPOSITE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Medidor macro = new Medidor("M1504");
            //Macro Hijos
            Medidor mZ15041 = new Medidor("M15041");
            Medidor mZ15042 = new Medidor("M15042");
            //medidores
            Medidor u150412302 = new Medidor("U150412302");
            Medidor u15042303 = new Medidor("U15042303");

            //Jerarquia:
            macro.Add(mZ15041);
            macro.Add(mZ15042);
            mZ15041.Add(u150412302);
            mZ15041.Add(u15042303);
            macro.ShowInfo();
            Console.ReadKey();
        }
    }
}
