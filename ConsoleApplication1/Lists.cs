using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lists
    {
        public static void SequenceNumbers()
        {
            Console.WriteLine("Въведи числа: ");
            string numbers = Console.ReadLine();
            int sum = 0;
            List<int> myList = new List<int>();
            foreach (char c in numbers)
            {
                
                if (char.IsDigit(c))
                {
                    
                    myList.Add(int.Parse(c.ToString()));
                    
                }
            }
            foreach (int n in myList)
            {
                Console.WriteLine("Листа  е :{0}", n);
                sum += n;
            }
            int sredno = sum / 2;
            
            Console.WriteLine("Сумата е :{0}",sum );
            Console.WriteLine("Средно аретмитично: {0}", sredno);
        }
        public static void StackReverse()
        {
            int n;
            int k = 0;
            int numbers = 0;
            string number = "";
            string reverseNumber = "";
            Stack<int> myStack = new Stack<int>();
            int count = 0;
            do {
                Console.WriteLine("Въведи числа: ");
                number = Console.ReadLine();
                if (int.TryParse(number, out n) && number != "999") { 
                    numbers = n;
                    myStack.Push(n);
                } else {
                    Console.WriteLine("Въведи коректно число ,пендел: ");
                }
            } while (n != 999); Console.WriteLine("Въведи числа: ");
            count = myStack.Count;
            if (myStack.Contains(3))
            {
                Console.WriteLine("Сумата е :Bravo be");
            }
            while (k < count)
            {
                k++;
                reverseNumber += Convert.ToString(myStack.Pop());
                Console.WriteLine("k е :{0}", k);
               
            }

                Console.WriteLine("Сумата е :{0}", reverseNumber);
            
            


           // Console.WriteLine("Сумата е :{0}", Int32.Parse(reverseNumber));

        }

        public static void StackSort()
        {
            int n;
            int k = 0;
            int numbers = 0;
            string number;
           
            List<int> myStack = new List<int>();
            List<int> newStack = new List<int>();
            int temp = 0;
            do
            {
                Console.WriteLine("Въведи числа: ");
                number = Console.ReadLine();
                if (int.TryParse(number, out n) && number != "")
                {
                    numbers = n;
                    myStack.Add(n);
                }
                else
                {
                    Console.WriteLine("Въведи коректно число: ");
                }
            } while (number != "");
            
            for (int j=0;j< myStack.Count;j++)
            {
                for (int m=0;m<myStack.Count - 1; m++)
                {
                    if (myStack[m] > myStack[m + 1])
                    {
                        temp = myStack[m];
                        myStack[m] = myStack[m+1];
                        myStack[m+1] = temp;
                    } 

                }

            }
            foreach (int item in myStack)
            {
                Console.WriteLine("Сумата е :{0}", item);
            }
         
   
    

           




            // Console.WriteLine("Сумата е :{0}", Int32.Parse(reverseNumber));

        }

    }
}
