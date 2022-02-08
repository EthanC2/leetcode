//What is an in-order traversal of a binary search tree?: https://www.educba.com/inorder-traversal-of-binary-tree/

//Recursive approach
public class Solution 
{
    public IList<int> InorderTraversal(TreeNode root) 
    {
      List<int> values = new();
      InOrder(values, root);
      return values;
    }
  
    void InOrder(List<int> list, TreeNode root)
    {
      if (root is null) return;
      
      InOrder(list, root.left);
      list.Add(root.val);
      InOrder(list, root.right);
    }
}



//Iterative approach
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public IList<int> InorderTraversal(TreeNode root) 
    {
      List<int> values = new();
      Stack<TreeNode> nodes = new();
      TreeNode temp = root;
      
      while (temp is not null || nodes.Count != 0)
      {
        if (temp is not null)
        {
          nodes.Push(temp);
          temp = temp.left;
        }
        else
        {
          temp = nodes.Pop();
          values.Add(temp.val);
          temp = temp.right;
        }
      }
      
      return values;
    }
}
