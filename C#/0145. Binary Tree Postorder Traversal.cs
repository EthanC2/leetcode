/*
    What is a postorder traversal of a binary search tree?:
    
    Postorder Traversal
    ===================
    PostOrder(root.left);
    PostOrder(root.right);
    list.Add(root.val);      <= action last in postorder
*/

//Recursive approach
public class Solution 
{
    public IList<int> PostorderTraversal(TreeNode root) 
    {
      List<int> values = new();
      PostOrder(values, root);
      return values;
    }
  
    private void PostOrder(List<int> list, TreeNode root)
    {
      if (root is null) return;
      
      PostOrder(list, root.left);
      PostOrder(list, root.right);
      list.Add(root.val);
    }
}
