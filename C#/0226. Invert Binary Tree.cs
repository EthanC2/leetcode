/*
  Recursive Solution
  TC: O(n)
  SC: O(n)
  
  Since you have to return 'root', you have to write a helper function
*/
public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        InvertTreeHelper(root);
        return root;
    }
    
    public void InvertTreeHelper(TreeNode node)
    {
        if (node is null) return;
        
        (node.left, node.right) = (node.right, node.left);
        
        InvertTree(node.left);
        InvertTree(node.right);
    }
}


/*
  Iterative Solution
  TC: O(n)
  SC: O(n)
  
  Just a bit cleaner due to the lack of the helper function
*/
public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        if (root is null) return null;
        Queue<TreeNode> nodes = new();
        nodes.Enqueue(root);
        
        while (nodes.Count != 0)
        {
            TreeNode curr = nodes.Dequeue();
            (curr.left, curr.right) = (curr.right, curr.left);
            
            if (curr.left is not null) nodes.Enqueue(curr.left);
            if (curr.right is not null) nodes.Enqueue(curr.right);
        }
        
        return root;
    }
}
