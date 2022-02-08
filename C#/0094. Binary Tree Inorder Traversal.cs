/*
    What is an in-order traversal of a binary search tree?: 
    https://www.educba.com/inorder-traversal-of-binary-tree/
    https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    
    InOrder Traversal:
    ==================
    InOrder(root.left);
    list.Add(root.val);  <= action in middle in inorder
    InOrder(root.right);
*/

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
