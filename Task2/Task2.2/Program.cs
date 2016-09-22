using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            string str;
            List<string> text = new List<string>();
            Console.WriteLine(@"Enter text. For exit enter ""end""");
            while (!(str = Console.ReadLine()).Equals("end"))
            {
                text.Add(str);
            }

            List<string> parsedText = new List<string>();
            int _integer = 0;
            int _double = 0;
            int sumInt = 0;
            double sumDouble = 0;
            string textInt = null;
            string textDouble = null;
            foreach (var line in text)
            {

                int resultInt;
                double resultDouble;
                char[] seps = { ',' ,' ', '!', '?' ,'\n'};
                var splitedText = line.Split(seps);

                foreach (var piece in splitedText)
                {
                    if (Int32.TryParse(piece, out resultInt))
                    {
                        _integer++;
                        textInt += resultInt.ToString().PadLeft(17) + "\n";
                        sumInt += resultInt;
                    }
                    else
                    {
                        if (Double.TryParse(piece, out resultDouble))
                        {
                            _double++;
                            textDouble += resultDouble.ToString("F", CultureInfo.InvariantCulture).PadLeft(17) + "\n";
                            sumDouble += resultDouble;
                        }
                        else
                        {
                            parsedText.Add(piece);
                        }
                    }

                }
                
            }
            Console.WriteLine($"integer: {_integer}");
            Console.WriteLine($"double: {_double}");
            textInt += "Average" +(sumInt / _integer).ToString("F", CultureInfo.InvariantCulture).PadLeft(10);
            textDouble += "Average" +(sumDouble / _double).ToString("F", CultureInfo.InvariantCulture).PadLeft(10);
            Console.WriteLine(textInt);
            Console.WriteLine(textDouble);

            parsedText = pr.SortList(parsedText);
            foreach (var item in parsedText)
            {
                Console.WriteLine(item);
            }

        }

        private List<string> SortList(List<string> parsedText)
        {
            parsedText.Sort(MagicComparer);
            return parsedText;
        }

        static int MagicComparer(String s1, String s2)
        {
            int cmp = s1.Length.CompareTo(s2.Length);
            return cmp == 0 ? s1.CompareTo(s2) : cmp;
        }

    }
}
