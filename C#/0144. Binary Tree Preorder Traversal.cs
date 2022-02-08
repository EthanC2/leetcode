/*

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
