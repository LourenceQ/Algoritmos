namespace _958CheckCompletenessofaBinaryTreeProj;

public class Solution {
    public bool IsCompleteTree(TreeNode root) {
        if(root == null) 
            return true;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        bool isEnd = false;

        q.Enqueue(root);

        while(q.Count > 0)
        {
            TreeNode cur = q.Dequeue();

            if(isEnd && cur != null)
                return false;
            
            if(cur == null)
                isEnd = true;
            
            if(cur != null)
            {
                q.Enqueue(cur.left);
                q.Enqueue(cur.right);
            }
        }

        return true;
    }
}