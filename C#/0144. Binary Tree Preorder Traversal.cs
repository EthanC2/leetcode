/*
    What is preorder traversal of a binary search tree?:
    https://www.javatpoint.com/preorder-traversal
    https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    
    Preorder Traversal
    ==================
    list.Add(root.val);  <= action first in preorder
    PreOrder(root.left);
    PreOrder(root.right);
*/

//Recursive
public class Solution 
{
    public IList<int> PreorderTraversal(TreeNode root) 
    {
      List<int> values = new();
      PreOrder(values, root);
      return values;
    }
  
    private void PreOrder(List<int> list, TreeNode root)
    {
      if (root is null) return;
      
      list.Add(root.val);
      PreOrder(list, root.left);
      PreOrder(list, root.right);
    }
}
