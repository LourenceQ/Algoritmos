/*
1491. Average Salary Excluding the Minimum and Maximum Salary
Easy
You are given an array of unique integers salary where salary[i] is the salary of
 the ith employee.

Return the average salary of employees excluding the minimum and maximum salary.
Answers within 10-5 of the actual answer will be accepted.

Example 1:

Input: salary = [4000,3000,1000,2000]
Output: 2500.00000
Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500
Example 2:

Input: salary = [1000,2000,3000]
Output: 2000.00000
Explanation: Minimum salary and maximum salary are 1000 and 3000 respectively.
Average salary excluding minimum and maximum salary is (2000) / 1 = 2000
 
Constraints:

3 <= salary.length <= 100
1000 <= salary[i] <= 106
All the integers of salary are unique.
*/

using System;
using System.Linq;

namespace AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sal = { 4000, 3000, 1000, 2000 };
            int[] sal2 = { 1000, 2000, 3000 };
            var res = Average4(sal2);
            System.Console.WriteLine(res);
        }

        //Error
        public static double Average(int[] sal)
        {
            double medium = 0, temp = 0;
            for (int x = 1; x < sal.Length; x++)
            {
                medium += sal[x - 1];
                for (int y = 0; y < sal.Length; y++)
                {
                    if (sal[x] < sal[y] && sal[x] < temp)
                        temp = sal[x];
                }
            }

            medium -= temp;

            for (int x = 1; x < sal.Length; x++)
            {
                for (int y = 0; y < sal.Length; y++)
                {
                    if (sal[x] > sal[y] && sal[x] > temp)
                    {
                        temp = sal[x];
                    }
                }
            }

            medium -= temp;


            return medium / 2;
        }

        public static double Average2(int[] sal)
        {
            int len = sal.Length;
            int sum = sal[0];
            int min = sal[0];
            int max = sal[0];

            for(int x=1; x<len; x++)
            {
                min = Math.Min(min, sal[x]);
                max = Math.Max(max, sal[x]);
                sum += sal[x];
            }

            sum = sum - min - max;
            return (sum) / (len - 2);
        }

        public static double Average3(int[] sal)
        {
            var medium = 0;

            var min = int.MaxValue;
            int max = int.MinValue;

            foreach(var item in sal)
            {
                medium += item;
                if(item > max) max = item;
                if(item < min) min = item;
            }

            medium -= max;
            medium -= min;

            return medium / (sal.Length -2.0);
        }

        public static double Average4(int[] sal)
        {
            int MaxSal = sal.Max();
            int minSal = sal.Min();

            return sal.Where(medium => (medium != MaxSal && medium != minSal)).Average();
        }

        public static double AverageLinq(int[] sal) =>
            (double)(sal.Sum() - sal.Min()) / (sal.Length - 2);

        public static double AverageLinq2(int[] sal)
        {
            return sal.OrderBy(s => s)
                .Skip(1)
                .Take(sal.Length-2)
                .Average();
        }

        public static double AverageLinq3(int[] sal)
        {
            int maxSal = sal.Max();
            int minSal = sal.Min();
            return sal.Where(e => (e != maxSal && e != minSal)).Average();
        }
    }
}
