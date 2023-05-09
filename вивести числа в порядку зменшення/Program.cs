using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вивести_числа_в_порядку_зменшення
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int i;
            do
            {
                Console.WriteLine("Enter the number 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num1 < num2);
            
            do
            {
                for (i = num1; num1 >= num2; num1--)
                {
                    Console.WriteLine("{0}", num1);
                }
            } while (i != num2);

           

            

        }
    }
}
