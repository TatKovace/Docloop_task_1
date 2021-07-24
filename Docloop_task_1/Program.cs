using System;

namespace Docloop_task_1
{
    class Program
    {
        /*
        Write an algorithm in C# to find a pair of 2 elements of integer array whose sum equals a provided value. 
        Take into consideration algorithm complexity. 
        Example: 
        arr = [1,2,3,6,8,1,6] 
        sum = 5 
        result = [2,3] 
        Explanation:  2+3=5
         */

        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 23, -8, 99, 3, 8, 10, 45 };
            int sum = 15;            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == sum)
                        Console.WriteLine(numbers[i] + ", " + numbers[j]);
                } 
            }            
        }
    }
}
