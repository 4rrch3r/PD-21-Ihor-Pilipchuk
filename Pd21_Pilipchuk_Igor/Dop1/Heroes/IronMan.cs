using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop1.Heroes
{
    class IronMan : Ihero
    {
        private string power;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "IronMan";
            }
        }
        public string Power
        {
            get
            {
                return power;
            }
            set
            {
                power = "destroy enemies with my Iron Skin";
            }
        }
        public void hello()
        {
            Console.WriteLine($" Hi, I'm {Name}, and I can {Power}");
        }
    }
}
