using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMPOSITE
{
    public class Medidor : AmarreComponent
    {
        private string _name;
        private List<AmarreComponent> _medidores;
        public Medidor(string name)
        {
            _name = name;
            _medidores = new List<AmarreComponent>();
        }
        public override void Add(AmarreComponent amarreComponent)
        {
            _medidores.Add(amarreComponent);
        }

        public override void Remove(AmarreComponent amarreComponent)
        {
            _medidores.Remove(amarreComponent);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Medidor: " + _name);
            Console.WriteLine("Componentes:");
            foreach (AmarreComponent item in _medidores)
            {
                item.ShowInfo();
            }
        }
    }
}
