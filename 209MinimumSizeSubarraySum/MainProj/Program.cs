namespace _209MinimumSizeSubarraySumProj;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

public class Trie {
    private TrieNode head = null;
    
    public Trie() {
        head = new TrieNode();
    }
    
    public void Insert(string word) {
        Insert(head, word, 0);
    }
    
    private void Insert(TrieNode cur, string word, int i)
    {
        if (word.Length == i)
            cur.IsEnd = true;
        else
        {
            if (!cur.ContainsChar(word[i]))
                cur.AddChar(word[i]);
            
            Insert(cur[word[i]], word, i + 1);
        }
    }
    
    public bool Search(string word) {
        return Search(head, word, 0);
    }
    
    private bool Search(TrieNode cur, string word, int i)
    {
        if (word.Length == i)
            return cur.IsEnd;
        
        return cur.ContainsChar(word[i]) ? Search(cur[word[i]], word, i + 1) : false;
    }
    
    public bool StartsWith(string prefix) {
        return StartsWith(head, prefix, 0);
    }
    
    private bool StartsWith(TrieNode cur, string prefix, int i)
    {
        if (prefix.Length == i)
            return true;
        
        return cur.ContainsChar(prefix[i]) ? StartsWith(cur[prefix[i]], prefix, i + 1) : false;
    }
    
    public class TrieNode
    {
        private Dictionary<char, TrieNode> chars = new Dictionary<char, TrieNode>();
        
        public bool IsEnd { get; set; }
        
        public bool ContainsChar(char c)
        {
            return chars.ContainsKey(c);
        }
        
        public void AddChar(char c)
        {
            chars.Add(c, new TrieNode());
        }
        
        public TrieNode this[char c]
        {
            get => chars[c];
        }
    }
}