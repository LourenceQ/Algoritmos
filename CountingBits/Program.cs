// C# Explained O(n) Linear single pass, O(n) Space
/*
This solution is designed without any bit manipulation. 
The intuition is that the result for n numbers is just the result of previour 
half incremented by 1. Let's take an example.

For num=1, we have 2 values in output
result = 0,1
For num=3, we have 4 values in output
result = 0,1,1,2. Notice that the next 2 values (i.e. for index 2,3) are just the 
values of index 0,1 incremented by 1
For num=7, we have 8 values in output
result = 0,1,1,2,1,2,2,3. Notice that the next 4 values (i.e. for index 4,5,6,7) 
are just the values of index 0,1,2,3 incremented by 1

Going on further we can easily calculate number of bits for n value by incrementing 
1 to the existing previous half set of n. So, the only thing we need to check is the 
nearest power of 2 to take the mod of the number.
E.g. to find for n=6, nearest power of 2 is 4. So num[6]=num[6%4]+1 = num[2]+1 = 1+1 =2.
*/
using System;

namespace CountingBits
{
    class Program
    {        
        static void Main(String[] args)
        {
            int n = 5;
            CountingBits(n);
        }
        public static int[] CountingBits(int num)
        {
            
            if (num == 0)
                return new int[] { 0 };

            int[] result = new int[num + 1];
            //set the value for result[1]=1. It is to avoid the divide by 0 error in log function
            result[1] = 1;

            //the nearest power of 2 below the number. Use this value to take the mod of 
            // the ith value to get the previous result and add 1 to it        
            int nearestPow = 1;

            for (int i = 2; i <= num; i++)
            {
                // condition to check if we have reached the new nearest power of 2. 
                // Math.Floor will always take the lower integer and hence newraestPow
                // will increment only if we have new power of 2. If yes, double the 
                // value of nearestPow(1,2,4,8,...)           
                if (Math.Floor(Math.Log(i, 2)) > Math.Floor(Math.Log(i - 1, 2)))
                    nearestPow = nearestPow * 2;
                //The result is just the value of i%nearestPow + 1
                result[i] = result[i % nearestPow] + 1;
            }

            for (int i = 0; i < num + 1; i++)
            {
                System.Console.WriteLine(result[i]);
            }
            return result;
        }
    }
}
