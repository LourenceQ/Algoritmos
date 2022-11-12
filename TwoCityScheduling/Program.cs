using System;
using System.Linq;

namespace TwoCityScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[][] costs = new int[][] 
            // {
            //     new int[] {259,770},
            //     new int[] {448,54},
            //     new int[] {926,667},
            //     new int[] {184,139},
            //     new int[] {840,118},
            //     new int[] {577,469}
            // };

            // int[][] costs = new int[][] 
            // {
            //     new int[] {515,563},
            //     new int[] {451,713},
            //     new int[] {537,709},
            //     new int[] {343,819},
            //     new int[] {855,779},
            //     new int[] {457,60},
            //     new int[] {650,359},
            //     new int[] {631,42}
            // };
            
            int[][] costs = new int[][] 
            {
                new int[] {10,20},
                new int[] {30,200},
                new int[] {400,50},
                new int[] {30,20}
            };
            var res = TwoCitySchedCost(costs);
            System.Console.WriteLine(res);
        }
        public static int TwoCitySchedCost(int[][] costs)
        {
            var list = costs.OrderByDescending(c => Math.Abs(c[0] - c[1])).ToList();

            int res = 0, a = 0, b = 0;

            foreach (var l in list)
            {
                if (a == costs.Length / 2) res += l[1];
                else if (b == costs.Length / 2) res += l[0];
                else
                {
                    res += Math.Min(l[0], l[1]);

                    if (l[0] < l[1])
                        a++;
                    else
                        b++;
                }
            }

            return res;
        }
    }
}
