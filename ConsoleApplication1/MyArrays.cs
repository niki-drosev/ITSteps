using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//упражнения от глава Масиви
namespace ConsoleApplication1
{
    class MyArrays
    {

        public string SortingMethod()
        {
            int[] myArr = {5,3,9,21,13,15,11,2};
            int pos_min, temp;
            
            for (int i=0;i < myArr.Length-1;i++)
            {
                pos_min = i;
                for (int j = i+1; j < myArr.Length; j++)
                {
                    if (myArr[pos_min] > myArr[j])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = myArr[i];
                    myArr[i] = myArr[pos_min];
                    myArr[pos_min] = temp;
                }
            }


            return String.Join(" ", myArr);
        }

        public string SumSequenceMethod()
        {
            int[] myArr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int pos_min, temp;
            int sum = 0;
            temp = 0;
            string result = "";
            Console.WriteLine("Please Enter one number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < myArr.Length - 1; i++)
            {
                pos_min = i;
                sum = myArr[i];
                for (int j = i + 1; j < myArr.Length; j++)
                {

                    sum += myArr[j];
                    if (sum > temp)
                    {
                        temp = sum;
                     
                    }
                    
                }

              if (sum == number)
                {
                    result = "The result is found";
                }
                   
                
            }

            return result;


        }
        public int MostRecentElement()
        {
            int[] myArr = { 5,5,1,2,3,4,6,6,6};
            var repeatNumber = new int[myArr.Length];
            int mostRecent,max;
            int counter = 0;
            int tempCouter = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                mostRecent = myArr[i];
                counter = 0;
                for (int j = i ; j < myArr.Length; j++)
                {

                
                    if (mostRecent == myArr[j] )
                    {
                        
                        repeatNumber[i] = mostRecent;
                        counter++;
                        
                    }

                }
                
                if (tempCouter < counter)
                {
                    tempCouter = counter;
                  
                }
            }

            return tempCouter;
        }

        public int BinarySereach ()
        {
            Console.WriteLine("Въведи едно число :");
            int number = Int32.Parse(Console.ReadLine());
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
          
            int index = Array.BinarySearch(myArr, number);
            if (index >= 0) { return index; } else { return 0; }
           
        }

    }
}
