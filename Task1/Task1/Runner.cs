using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Configuration;
using System.Resources;
using System.Reflection;

namespace Task1
{
    class Runner
    {
        static void Main(string[] args)
        {
            try
            {
                Action action;
                Operations op;
                var config = ConfigurationManager.AppSettings["config"];

                switch (config)
                {
                    case "Console":
                        action = new Action();
                        Console.WriteLine(action.Sum(action.GetNumber(), action.GetNumber()));
                        break;

                    case "Library":
                        int firstNumber;
                        int secondNumber;
                        action = new Action();
                        op = new Operations();
                        firstNumber = action.GetNumber();
                        secondNumber = action.GetNumber();
                        Console.WriteLine(op.Sum(firstNumber, secondNumber));
                        Console.WriteLine(op.Diverence(firstNumber, secondNumber));
                        Console.WriteLine(op.Multi(firstNumber, secondNumber));
                        Console.WriteLine(op.Dev(firstNumber, secondNumber));
                        break;

                    case "Resource":
                        ResourceManager rm = new ResourceManager("Task1.Resource1", Assembly.GetExecutingAssembly());
                        String str1 = rm.GetString("number1");
                        String str2 = rm.GetString("number2");
                        Console.WriteLine(Int32.Parse(str1)+ Int32.Parse(str2));
                        break;

                    default:
                        Console.WriteLine("fail");
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }
}
