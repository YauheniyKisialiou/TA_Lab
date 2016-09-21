using System;
using System.Collections.Generic;
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
            //string str;
            List<string> text = new List<string>();
            //Console.WriteLine(@"Enter text. For exit enter ""end""");
            //while (!(str = Console.ReadLine()).Equals("end"))
            //{
            //    text.Add(str);
            //}

            //foreach (var item in text)
            //{
            //    Console.WriteLine(item);
            //}
            text = File.ReadAllLines(@"D:\Yauheniy_Kisialiou\task2_2.txt").ToList<string>();
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
