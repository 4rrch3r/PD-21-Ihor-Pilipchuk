using System;

namespace pop
{
    class Program
    {
        //Завдання 4
        //static void Reverse(int n ,int[] arr)
        //{
        //    Console.WriteLine();
        //    for (int i = n - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        // Завдання 5
        static void Reverse(int n, ref int[] arr)
        {


            Console.WriteLine();

            Console.WriteLine("Reversing");
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
        static void Main(string[] args)
        {
            //Завдання1 1.	Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)


            /* int digit;
            int reversed = 0;
            Console.WriteLine("Enter digit");
            digit = Convert.ToInt32(Console.ReadLine());
            while (digit > 0)
            {
                reversed = reversed * 10 + digit % 10;
                digit /= 10;
            }
            Console.WriteLine("Your reversed digit:  " + reversed); */

            //Завдання2 2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)

            /* string str;
             Console.WriteLine("Enter string");
             str = Console.ReadLine();
             for (int i = str.Length-1; i >=0; i--)
             {
                 Console.WriteLine("Letter: " + str[i] );
             } */

            //Завдання3 3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)

            //string text = "123456.45678";
            //Console.WriteLine("Enter digit");
            //text = Console.ReadLine();
            //string[] words = text.Split(new char[] { '.' });
            //int a;
            //int b;


            //a= Convert.ToInt32(words[0]);
            //b = Convert.ToInt32(words[1]);

            //int reverseda = 0;
            //int reversedb = 0;

            //while (a > 0)
            //{
            //    reverseda = reverseda * 10 + a % 10;
            //    a /= 10;
            //}

            //while (b > 0)
            //{
            //    reversedb = reversedb* 10 + b % 10;
            //    b /= 10;
            //}
            //Console.WriteLine("Your reversed digit: " + reverseda + "."+ reversedb);


            //Завдання 3.4.Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
            //int n = 5;
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Vvedite " + (i + 1) + " chislo v massiv");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();

            //Console.WriteLine("Reversing");

            //Reverse(n, arr);
            int n = 5;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vvedite " + (i + 1) + " chislo v massiv");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Reverse(n, ref arr);
        }

    }
}