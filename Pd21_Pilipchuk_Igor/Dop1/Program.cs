using Dop1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider Hero = new Spider { Name = "hero" , Power="ability" };
            Hero.hello();
            Hulk Hero1 = new Hulk { Name = "hero", Power = "ability" };
            Hero1.hello();
            IronMan Hero2 = new IronMan{ Name = "hero", Power = "ability" };
            Hero2.hello();
            Thor Hero3 = new Thor { Name = "hero", Power = "ability" };
            Hero3.hello();
            Cap Hero4 = new Cap { Name = "hero", Power = "ability" };
            Hero4.hello();
        }
    }
}
