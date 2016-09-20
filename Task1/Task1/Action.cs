using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Action
    {
        public int GetNumber()
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid iput, please enter number");
            }
            return number;
        }

        public string Sum(double firstNumber, double secondNumber)
        {
            return "Sum = " + (firstNumber + secondNumber);
        }

    }
}
