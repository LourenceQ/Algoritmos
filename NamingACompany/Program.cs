
Console.WriteLine("Hello, World!");
string[] ideas = {"coffee","donuts","time","toffee"};

Console.WriteLine(Solution.DistinctNames(ideas));
public static class Solution {
    public static long DistinctNames(string[] ideas) 
    {
        long res = 0;
        Dictionary<char, HashSet<string>> dict = new ();

        foreach(var idea in ideas)
        {
            if(!dict.ContainsKey(idea[0]))
                dict.Add(idea[0], new HashSet<string>());
            
            dict[idea[0]].Add(idea);
        }

        Dictionary<char, Dictionary<char,long>> set = new();

        foreach(var k1 in dict.Keys)
        {
            set.Add(k1, new Dictionary<char, long>());

            foreach(var k2 in dict.Keys)
            {
                if(k1 == k2) continue;
                set[k1].Add(k2, 0);

                foreach(var s in dict[k2])
                {
                    var s2 = $"{k1}" + s.Substring(1);
                    if(!dict[k1].Contains(s2)) set[k1][k2]++;

                }
            }
        }

        foreach(var k1 in dict.Keys)
        {
            foreach(var k2 in dict.Keys)
            {
                if(k1 == k2) continue;

                res += set[k1][k2] * set[k2][k1];
            }
        }

        return res;
        
    }
}