using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Варіант 20 20.Дані координати(як цілі від 1 до 8) двох різних полів шахівниці. Якщо ферзь за один хід може перейти з одного поля на інше, вивести логічне значення True, інакше вивести значення False. 
            bool a = true;
            int x1, y1, x2, y2;
            Console.WriteLine("Coordinates of the first point ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coordinates of the second point ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            if (x1 == x2 || y1 == y2 || x1 - y1 == x2 - y2 || x1 + y1 == x2 + y2)
            {
                Console.WriteLine(a);
            }
            else
            {
                a = false;
                Console.WriteLine(a);
            }
        }
    }
}