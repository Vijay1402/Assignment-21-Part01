using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21_1
{
    internal class Program
    {
        public delegate int ArithmeticOperation(int a, int b);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            ArithmeticOperation a = new ArithmeticOperation(Add);
            ArithmeticOperation s = new ArithmeticOperation(Subtract);
            ArithmeticOperation m = new ArithmeticOperation(Multiply);
            ArithmeticOperation d = new ArithmeticOperation(Divide);
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the operation:\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    Console.WriteLine("The result of Addition is = "+a(x, y));
                    break;
                case 2:
                    Console.WriteLine("The result of Subtraction is = "+s(x, y));
                    break;
                case 3:
                    Console.WriteLine("The result of Multiplication is = " + m(x, y));
                    break;
                case 4:
                    Console.WriteLine("The result of Division is = " + d(x, y));
                    break;
                default: Console.WriteLine("Wrong option entered");
                    break; 
            }
            Console.ReadKey();
        }
    }
}
