using System;

namespace Action_Delegate
{
    class Program
    {

        static void Calculator(Action<int, int> input)
        {
            input(12, 5);

        }

        static void Main(string[] args)
        {
            Action<int, int> calAdd = new Action<int, int>(Add);
            Action<int,int> calSub = new Action<int, int>(Subtract);
            Action<int, int> calMul = new Action<int, int>(Multiplication);
            Action<int, int> calDiv = new Action<int, int>(Divide);

            Calculator(calAdd+= calSub+= calMul+= calDiv);
           
        }
       
        static void Add(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine ("Sum : "+ sum);
        }
        static void Subtract(int number1, int number2)
        {
            int balance = number1 - number2;
           Console.WriteLine("Remaining :"+ balance);
        }
        static void Multiplication(int number1, int number2)
        {
            int product = number1 * number2;
           Console.WriteLine("Product :"+product);
        }
        static void Divide(int number1, int number2)
        {
            int quotient = number1 / number2;
           Console.WriteLine("Quotient :"+quotient);
        }
        
        
    }
}
