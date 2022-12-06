using System;

namespace FuncDelegate_Basic_
{
    class Program
    {
        static void Main(string[] args)
        {
            var addObj =new Func<int, int, int>(Add);
            Console.WriteLine (addObj(10, 3));

            var sumObj = new Func<int, int, int>(Subtract);
            Console.WriteLine(sumObj(6, 3));

            var mulObj = new Func<int, int, int>(Multiplication);
            Console.WriteLine(mulObj(8, 6));

            var divObj = new Func<int, int, int>(Divide);
            Console.WriteLine(divObj(10, 5));


        }
        static int Add(int number1, int number2)
        {
            return (number1 + number2);
        }

        static int Subtract(int number1, int number2)
        {
            return (number1 - number2);
        }
        static int Multiplication(int number1, int number2)
        {
            return (number1 * number2);
        }
        static int Divide(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}
