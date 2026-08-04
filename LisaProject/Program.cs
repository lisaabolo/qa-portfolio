using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("The sum of the two numbers is: ");
            int sumOfNumbers = firstNumber + secondNumber;
            Console.WriteLine(sumOfNumbers);
        }
    }
}
