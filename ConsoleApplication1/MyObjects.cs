using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyObjects
    {
        public static void RandomNumbers()
        {


            Random a = new Random();
            Console.WriteLine("Nikolay");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a.Next(100, 201));
            }
        }

        public static void DayNumber()
        {
            int startTime = Environment.TickCount;
            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());

            DateTime dateValue = new DateTime(year, month, day);
            Console.WriteLine(dateValue.ToString("ddd"));
            int endTime = Environment.TickCount;
            Console.WriteLine("Time for processing program : {0} ", endTime - startTime);
        }
        // Изклюяения глава 12
        public static void FindNumber()
        {
            int number = 0;
            Console.WriteLine("Please enter one number between 6-49: ");

            try
            {
                number = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number Exception big");
            }
            finally
            {
                if (49 > number && number > 6)
                {
                    Console.WriteLine("Correct number");
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }

        }

        // Стрингове глава 13
        public static void ReverseString()
        {
            Console.WriteLine("Въведи произволен стринг");
            string mystring = Console.ReadLine();
            int count = 0;
            StringBuilder text = new StringBuilder(mystring.Length);
            string keyword = "in";
            int index = mystring.IndexOf(keyword);
            while (index != -1)
            {

                index = mystring.IndexOf(keyword, index + keyword.Length);



                Console.WriteLine("Correct : {0}", index);



            }
        }

        public static void MaxTwetySymbols()
        {
            Console.WriteLine("Въведи стринг максимулм до 20 символа: ");
            string text = Console.ReadLine();
            StringBuilder newTest = new StringBuilder(text.Length);
            char symbol = '*';
            if (text.Length < 20) {
                Console.WriteLine(text.PadRight(20, symbol));
            } else if (text.Length > 20) {
                Console.WriteLine(text.Substring(0, Math.Min(20, text.Length)));
            }
        }
        public static void FindWordSentence()
        {
            Console.WriteLine("Въведете текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Въведете дума:");
            string word = Console.ReadLine();

            string[] textArr = text.Split('.');
            
            StringBuilder result = new StringBuilder();
            foreach (string sentence in textArr)
            {
                int number = 0;
                //Console.WriteLine("Symbol before : {0}", sentence[sentence.IndexOf(word) - 1]);
                //Console.WriteLine("Symbol after : {0}", sentence[sentence.IndexOf(word) + word.Length + 1]);
               
                if (sentence.IndexOf(word) != -1)
                {
                    number = sentence.IndexOf(word, number + word.Length);
                    Console.WriteLine("Index of word are : {0}", word);
                }

                if (sentence.IndexOf(word) != -1 && !Char.IsLetter(sentence[number - 1]) && !Char.IsLetter(sentence[number + word.Length]))
                {
                    Console.WriteLine("New : {0}", Char.IsLetter(sentence[sentence.IndexOf(word) - 1]));
                    result.Append(sentence);
                }
            }
            Console.WriteLine("sentences are : {0}", result);
        }


    }
}
