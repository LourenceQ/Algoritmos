using static System.Console;

namespace BinaryTreeInOrderTraversal;


public class Progoram
{
    public static void Main(string[] args)
    {
        TreeNode tree = new();

        var res = InOrderTraversal(tree);

        for (int i = 0; i < res.Count; i++)
        {
            WriteLine($"Resultado : {res.ToString()}");    
        }
        
    }

    public static IList<int> InOrderTraversal(TreeNode root)
    {
        if(root == null)
            return new List<int>();

        Stack<TreeNode> s = new();    
        IList<int> res = new List<int>();

        s.Push(root);

        while(s.Count > 0)
            if(s.Peek().left != null)
                s.Push(s.Peek().left);
            else
                while(s.Count > 0)
                {
                    TreeNode cur = s.Pop();
                    res.Add(cur.val);

                    if(cur.right != null)
                    {
                        s.Push(cur.right);
                        break;
                    }
                }

        return res;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

