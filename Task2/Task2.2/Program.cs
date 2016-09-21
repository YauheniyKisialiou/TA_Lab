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
            //text = File.ReadAllLines(@"D:\Yauheniy_Kisialiou\task2_2.txt").ToList<string>();
            List<string> parsedText = new List<string>();
            int _integer = 0;
            int _double = 0;
            int sumInt = 0;
            double sumDouble = 0;
            string textInt = null;
            string textDouble = null;
            foreach (var line in text)
            {
                //Console.WriteLine(item);
                //pr.ParseString(item);
                int resultInt;
                double resultDouble;
                char[] seps = { ',' ,' ', '!', '?' ,'\n'};
                var splitedText = line.Split(seps);

                foreach (var piece in splitedText)
                {
                    if (Int32.TryParse(piece, out resultInt))
                    {
                        _integer++;
                        textInt += resultInt.ToString().PadLeft(13) + "\n";
                        sumInt += resultInt;
                    }
                    else
                    {
                        if (Double.TryParse(piece, out resultDouble))
                        {
                            _double++;
                            textDouble += resultDouble.ToString("F", CultureInfo.InvariantCulture).PadLeft(13) + "\n";
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
            textInt += "Average" +(sumInt / _integer).ToString("F", CultureInfo.InvariantCulture).PadLeft(6);
            textDouble += "Average" +(sumDouble / _double).ToString("F", CultureInfo.InvariantCulture).PadLeft(6);
            Console.WriteLine(textInt);
            Console.WriteLine(textDouble);

            //parsedText.Sort();
            //foreach (var item in parsedText)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            parsedText = pr.sortList(parsedText);
            foreach (var item in parsedText)
            {
                Console.WriteLine(item);
            }

        }

        List<string> sortList(List<string> parsedText)
        {
            for (int i = 0; i < parsedText.Count; i++)
            {
                int min = parsedText[i].Length;
                int iMin = i;
                for (int j = i + 1; j < parsedText.Count; j++)
                {
                    if (parsedText[j].Length < min)
                    {
                        string temp = parsedText[i];
                        min = parsedText[j].Length;
                        iMin = j;
                        parsedText[i] = temp;
                    }
                }
                if (i != iMin)
                {

                    string temp = parsedText[i];

                    parsedText[i] = parsedText[iMin];

                    parsedText[iMin] = temp;
                }
            }
            return parsedText;
            
        }
    }
}
