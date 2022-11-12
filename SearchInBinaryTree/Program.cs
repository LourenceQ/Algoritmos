using System;

namespace SearchInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] root = {4,2,7,1,3};
            // int val = 2;

            // TreeNode treeNd = new TreeNode(val, TreeNode left, TreeNode right); 
            // Console.WriteLine("Hello World!");
            // Solution.SearchBST(root, val);
        }
    }

    public class TreeNode
    {
        private Node root;
        private class Node
        {
            internal int value;
            internal Node lChild;
            internal Node rChild;
            public Node(int v, Node l, Node r)
            {
                this.value = v;
                this.lChild = l;
                this.rChild = r;
            }
            public Node(int v)
            {
                this.value = v;
                this.lChild = null;
                this.rChild = null;
            }
        }

        public TreeNode()
        {
            root = null;
        }

        public bool SearchBT(int value)
        {
            return SearchBTUtil(root, value);
        }

        private bool SearchBTUtil(Node curr, int value)
        {
            bool left, right;
            if(curr == null)
                return false;
            if (curr.value == value)
                return true;
            left = SearchBTUtil(curr.lChild, value);
            if(left)
                return true;
            
            right = SearchBTUtil(curr.rChild, value);
            if(right)
                return true;
            
            
            return false;
        }
    }
    
}
