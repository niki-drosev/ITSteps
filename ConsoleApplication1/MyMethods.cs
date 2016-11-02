using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyMethods
    {
        public int TaskOne(int a, int b)
        {
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        public int GetLastNumber(int a)
        {
            int last;
            last = a % (a / 10);

            return last;
        }
        public int GetHowManyTimesNumber(int a)
        {
            int num = 0;
            int[] myarray = { 2, 3, 9, 5, 21, 17, 3, 23, 3, 56, 34, 9, 19 };

            for (int i = 0; i < myarray.Length; i++)
            {
                if (a == myarray[i])
                {
                    num++;
                }
            }
            return num;
        }

        public int CompareNextPrevious(int a)
        {
            int num = 0;
            int[] myarray = { 2, 3, 9, 5, 21, 17, 3, 23, 3, 56, 34, 9, 19 };


            if (myarray[a] > myarray[a + 1])
            {
                Console.WriteLine("По-голям от a+1 = {0}", myarray[a + 1]);
            }
            else
            {
                Console.WriteLine("По-малък от a+1 = {0}", myarray[a + 1]);
            }
            if (myarray[a] > myarray[a - 1])
            {
                Console.WriteLine("По-голям от a-1 = {0}", myarray[a - 1]);
            }
            else
            {
                Console.WriteLine("По-малък от a-1 = {0}", myarray[a - 1]);
            }
            return myarray[a];
        }
        public int CompareNextPreviousMax()
        {
            int result = 0;
            int[] myarray = { 2, 3, 9, 5, 21, 17, 3, 23, 3, 56, 34, 9, 19 };

            for (int n = 1; n < myarray.Length - 1; n++)
            {
                Console.WriteLine("every number {0}", myarray[n]);
                if ((myarray[n] > myarray[n - 1]) && (myarray[n] > myarray[n + 1]))
                {
                    result = n;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            return result;
        }
        public int ReverseNumber(int a)
        {
            string ReverseNumber = "";
            int digit = 0;
            int sum = a;
            int[] myarray = new int[a.ToString().Length];
            for (int i = 0; i < a.ToString().Length; i++)
            {
                
                digit = sum % 10;
           
                sum = sum / 10;
                ReverseNumber += Convert.ToString(digit);
            
        
            }
            return Int32.Parse(ReverseNumber);
        }


    }
}
