using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_var9
{
    class Program
    {

        //Варіант 20.20.	Даний масив цілих чисел розміру N.Визначити максимальну кількість його однакових елементів.
        static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[n];
            int maxvar = 0;
            int maxquan = 0;
            int quan;
            int var;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " element");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                var = arr[i];
                quan = 0;
                for (int j = 0; j < n; j++)
                {
                    if (var == arr[j])
                    {
                        quan++;
                    }
                }

                if (quan > maxquan)
                {
                    maxquan = quan;
                    maxvar = var;

                }
            }
            if (maxquan > 0)
            {
                Console.WriteLine("Digit with the most quantity was: " + maxvar + " with frequency:" + maxquan);
            }
            if (maxquan <= 0)
            {
                Console.WriteLine("Seems like every digit was unique");
            }

        }
    }
}