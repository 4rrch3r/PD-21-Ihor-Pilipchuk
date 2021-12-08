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
    public class DiscPhone
    {
        public  void Call()
        {
            Console.WriteLine("Ring-Ring");
        }
    }
    public class ButtonPhone: DiscPhone
    {
        public void Messages()
        {
            Console.WriteLine("Lets send a message");
        }
    }
    public class WBPhone : ButtonPhone
    {
        public void Books()
        {
            Console.WriteLine("You can read a book now");
        }
    }
    public class ColorPhone : WBPhone
    {
        public void Films()
        {
            Console.WriteLine("You can watch films with me");
        }
    }
    public class SmartPhone : ColorPhone
    {
        public void Smart()
        {
            Console.WriteLine("You can do everything because I'm smart !");
        }
    }
}
