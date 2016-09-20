using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operations
    {
        public string Sum(double firstNumber, double secondNumber)
        {
            return "Sum = " + (firstNumber + secondNumber);
        }

        public string Dev(double firstNumber, double secondNumber)
        {
            return "Dev = " + (firstNumber/secondNumber);
        }

        public string Multi(double firstNumber, double secondNumber)
        {
            return "Multi = " + (firstNumber * secondNumber);
        }

        public string Diverence(double firstNumber, double secondNumber)
        {
            return "Div = " + (firstNumber - secondNumber);
        }
    }
}
