using System;
using System.Linq;

namespace MinimumDominoRotationsForEqualRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tops = {2,1,2,4,2,2};
            int[] bottom = {5,2,6,2,3,2};
            var res = Solution2(tops,bottom);
            Console.WriteLine(res);
        }

        public static  int Solution(int[] tops, int[] bottoms)
        {
            var x = tops.Concat(bottoms)
                .GroupBy(g => g)
                .OrderBy(o => -o.Count())
                .Select(s => s.Key)
                .First();

            var rotateTop = 0;
            var rotateBottom = 0;

            for(int i=0; i<tops.Length; i++)
            {
                if(tops[i] != x && bottoms[i] != x) {return -1; }
                else if(tops[i] != x) { rotateTop ++;}
                else if(bottoms[i] != x) {rotateBottom ++;}
            }

            return Math.Min(rotateTop, rotateBottom);
        }

        public static int Solution2(int[] tops, int[] bottoms)
        {
            var freq = new int[7];

            for (int i = 0; i < tops.Length; i++)
            {
                freq[tops[i]]++;    
                System.Console.WriteLine(freq[tops[i]]++);
                freq[bottoms[i]]++;
                System.Console.WriteLine(freq[bottoms[i]]++);
            }

            var x = Array.IndexOf(freq, freq.Max());
            var rtTop = 0;
            var rtBt = 0;

            for (int i = 0; i < tops.Length; i++)
            {
                if (tops[i] != x && bottoms[i] != x) {return -1;}
                else if(tops[i] != x) {rtTop++;}
                else if(bottoms[i] != x) {rtBt++;}
            }

            return Math.Min(rtTop, rtBt);
        }
    }
}
