using lab4.phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartphone = new SmartPhone();

            smartphone.Call();
            smartphone.Messages();
            smartphone.Books();
            smartphone.Films();
            smartphone.Smart();

        }
    }
 
    
  
   
   
}