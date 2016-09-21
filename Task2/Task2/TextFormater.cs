using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TextFormater
    {
        // method that convert caps to lowercase
        public String ToLowerCase(String text)
        {
            return text.ToLower();
        }

        // method that adds line break in the end of sentences
        // and add time-stamp
        public String ToLineBreak(String text)
        {
            DateTime dt = DateTime.Now;
            String time = dt.ToString("MM/dd/yyy HH:mm:ss.fff");
            text = time + " " + text;
            text = text.Replace("? ","?\n" + time + " ");
            text = text.Replace(". ", ".\n" + time + " ");
            text = text.Replace("! ", "!\n" + time + " ");
            text = text.Replace("... ", "!\n" + time + " ");
            text = text.Replace("?! ", "!\n" + time + " ");
            return text;
        }

        // work with console
        public void ConsoleLogic()
        {
            Console.WriteLine("Enter text");
            String text = Console.ReadLine();
            TextFormater tf = new TextFormater();
            text = tf.ToLowerCase(text);
            Console.WriteLine(text);
            text = tf.ToLineBreak(text);
            Console.WriteLine(text);
        }

        // work with file
        public void FileLogic(String path)
        {
            try
            {
                String text = File.ReadAllText(path);
                //Console.WriteLine(text);
                TextFormater tf = new TextFormater();
                text = tf.ToLowerCase(text);
                Console.WriteLine(text);
                text = tf.ToLineBreak(text);
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
                //Console.WriteLine(e);
            }
            
        }
    }
}
