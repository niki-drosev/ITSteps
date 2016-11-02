using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//До 6 урок упражнения
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            bool parseSuccessFirst = false;
            string FirstStr = "";

        
            /* while (!parseSuccessFirst)
             {

                 FirstStr = Console.ReadLine();
                 parseSuccessFirst = Int32.TryParse(FirstStr, out a);
                 Console.WriteLine("Incorrect number ! Please enter a valid first number :");
             }*/

            /*bool parseSuccessFirst = false;
            string FirstStr = "";
            Console.WriteLine("Please enter a valid first number :");


            while (!parseSuccessFirst)
            {
                
                FirstStr = Console.ReadLine();
                parseSuccessFirst = Int32.TryParse(FirstStr, out a);
                Console.WriteLine("Incorrect number ! Please enter a valid first number :");
            }

            // Console.WriteLine(parseSuccessFirst ?"The number is " + FirstStr : "Invalid number!");

            Console.WriteLine("Please enter a second number :");
            string  SecondStr = Console.ReadLine();
            bool parseSuccessSecond = Int32.TryParse(SecondStr, out b);
            Console.WriteLine(parseSuccessSecond ? "The number is " + SecondStr : "Invalid number!");
            Console.WriteLine(a > b ? "Please enter a second number bigger than First" + FirstStr : "Correct!");*/
            Program search = new Program();
            //search.ElementsRow(a);
            // Console.WriteLine("The number is : {0}", search.ElementsRow(a));
            MyArrays mainObject = new MyArrays();

           // MyObjects myObjMethods = new MyObjects();            //search.ElementsRow(a);
          // Console.WriteLine("Please enter a valid  number 1");
           // int a = Int32.Parse(Console.ReadLine());
            Lists.StackSort();
            ///Console.WriteLine("The number is : {0}", myObjMethods.RandomNumbers());

            /*  Console.WriteLine("Please enter a valid  number 1");
              int a = Int32.Parse(Console.ReadLine());
              Console.WriteLine("Please enter a valid  number 2");
              int b = Int32.Parse(Console.ReadLine());
              Console.WriteLine("Please enter a valid  number 3");
              int c = Int32.Parse(Console.ReadLine());
              Console.WriteLine("The number is : {0}", myMethodsObj.TaskOne(myMethodsObj.TaskOne(a, b), c));
              */
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }

        public int OperatorsNumberTen(int a)
        {
            int result = a;

            int sum = 0;
            string number = Convert.ToString(a);

            string reverseNumber = "";
            for (int i = 0; i < Convert.ToInt32(number.Length); i++)
            {
                sum = sum + result % 10;
                reverseNumber += Convert.ToString(result % 10);
                result = result / 10;

                Console.WriteLine("Is : {0}", sum);
            }

            Console.WriteLine("Reverse number is : {0}", reverseNumber);

            return sum;
        }


        public int OperatorsNumberTenC(int a)
        {
            int result = a;
            int GetLastElement;
            int sum = 0;
            int k = 0;
            int j = 0;
            string newNumberReverseSecondThird = "";
            int lastNumber = 0;
            string number = Convert.ToString(a);
            int[] ReverseLastNumber = new int[number.Length];

            for (int i = 0; i < Convert.ToInt32(number.Length); i++)
            {
                k++;
                sum = sum + result % 10;


                ReverseLastNumber[Convert.ToInt32(number.Length) - k] = result % 10;

                result = result / 10;

            }

            lastNumber = ReverseLastNumber[ReverseLastNumber.Length - 1];
            string newNumber = Convert.ToString(lastNumber);
            for (int n = 0; n < ReverseLastNumber.Length - 1; n++)
            {
                newNumber += Convert.ToString(ReverseLastNumber[n]);
            }

            for (int n = 0; n < ReverseLastNumber.Length; n++)
            {
                switch (n)
                {
                    case 1:
                        newNumberReverseSecondThird += Convert.ToString(ReverseLastNumber[2]);
                        break;
                    case 2:
                        newNumberReverseSecondThird += Convert.ToString(ReverseLastNumber[1]);
                        break;
                    default:
                        newNumberReverseSecondThird += Convert.ToString(ReverseLastNumber[n]);
                        break;
                }


            }


            return Convert.ToInt32(newNumberReverseSecondThird);
        }

        public int InputOutputNumberFive(int a, int b)   //191 страница
        {

            int k = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    k++;
                }
            }
            return k;
        }
        public int InputOutputNumberEight(int a)   //191 страница
        {

            bool parseSuccessFirst = false;
            string number = "";
            int[] fiveNumbers = new int[6];
            int sum = 0;
            int i = 1;
            int k = 0;

            while (i <= 5)
            {

                number = Console.ReadLine();
                parseSuccessFirst = Int32.TryParse(number, out a);

                if (parseSuccessFirst)
                {
                    fiveNumbers[i] = a;
                    i++;
                    Console.WriteLine("Please enter a valid  number " + i + " :");
                    sum += a;
                }
                else
                {
                    Console.WriteLine("Incorrect number ! Please enter a valid  number " + i + " :");
                }

            }
            int maxNumber = fiveNumbers[1];
            int minNumber = fiveNumbers[1];
            for (int item = 2; item <= fiveNumbers.Length - 1; item++)
            {


                if (fiveNumbers[item] > maxNumber)
                {
                    maxNumber = fiveNumbers[item];
                }
                if (fiveNumbers[item] < minNumber)
                {
                    minNumber = fiveNumbers[item];
                }
                Console.WriteLine("k= {0}, item = {1} ,maxnumber = {2}, min Number = {3}", k, item, maxNumber, minNumber);

            }

            return maxNumber;
        }

        public void CyclesTen(int a)  //234 страница
        {
            for (int i = 0; i < a; i++)
            {
                for (int k = i + 1; k < a + i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }


        }
        public int ElementsRow(int a)
        {
            bool parseSuccessFirst = false;
            string number = "";
            int[] fiveNumbers = new int[10];
            int[] sequence = new int[10];


            int i = 1;
            int j = 0;
            int k = 0;
            int maxCount = 0;

            int maxStart = 0;

            int currentCount = 1;

            int currentStart = 0;

            do
            {
                Console.WriteLine("Please enter a valid  Nikolay number " + i + " :");
                number = Console.ReadLine();
                parseSuccessFirst = Int32.TryParse(number, out a);
                if (parseSuccessFirst)
                {
                    fiveNumbers[i] = a;
                    i++;
                    Console.WriteLine("Please enter a valid  number " + i + " :");
                }
                else
                {
                    Console.WriteLine("Incorrect number ! Please enter a valid  number Nikolay" + i + " :");
                }


            } while (number != "end");



            for (int n = 1; n < fiveNumbers.Length; n++)

            {

                if (fiveNumbers[n] > fiveNumbers[n - 1])

                {
                    maxCount = fiveNumbers[n - 1];

                    sequence[n] = maxCount;
                    //if (currentCount > maxCount) { maxCount = currentCount; maxStart = currentStart; }

                }


                Console.WriteLine("Max Count : {0}", maxCount);
                Console.WriteLine("Max currentStart : {0}", currentStart);

            }
            //int[] result = fiveNumbers.Skip(maxStart).Take(maxCount).ToArray();
            Console.WriteLine(string.Join(" ", sequence));
            return maxCount;
        }

        public void SortingMethod(int a)
        {


        }

    }
}
