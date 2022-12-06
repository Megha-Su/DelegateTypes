using System;

namespace Calculator_using_Func
{
    class Program
    {

        static void Calculator(Func<int, int, int> input)
        {
            Console.WriteLine(input(10, 5));

        }

        static void Main(string[] args)
        {
            Func<int, int, int> calAdd = new Func<int, int, int>(Add);
            Func<int, int, int> calSub = new Func<int, int, int>(Subtract);
            Func<int, int, int> calMul = new Func<int, int, int>(Multiplication);
            Func<int, int, int> calDiv = new Func<int, int, int>(Divide);
            Calculator(calAdd);
            Calculator(calSub);
            Calculator(calMul);
            Calculator(calDiv);
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
