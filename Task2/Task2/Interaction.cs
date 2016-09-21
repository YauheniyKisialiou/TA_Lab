using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Interaction
    {
        public void Start()
        {
            TextFormater tf = new TextFormater();
            String config;
            config = ConfigurationManager.AppSettings["config"];

            // choose from where take text
            if (config.Equals("file"))
            {
                String path;
                String pattern = @"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$";
                Console.WriteLine("Enter path to file with text");
                
                while (!Regex.IsMatch((path = Console.ReadLine()), pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Invalid enter");
                }

                tf.FileLogic(path);

            }
            if (config.Equals("console"))
            {
                tf.ConsoleLogic();
            }
            Console.ReadLine();
        }
    }
}
