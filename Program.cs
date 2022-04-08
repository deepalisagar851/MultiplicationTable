using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Table(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+"X"+i+"="+(num*i));
            }
        }
        static void Main(string[] args)
        {
            
                Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Table(num);
        

        }
    }
}
