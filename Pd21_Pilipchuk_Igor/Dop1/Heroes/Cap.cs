using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop1.Heroes
{
    class Cap : Ihero
    {
        private string name;
        private string power;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "Captain America";
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
                power = "throw a shield";
            }
        }
        public void hello()
        {
            Console.WriteLine($" Hi, I'm {Name}, and I can {Power}");
        }
    }
}
