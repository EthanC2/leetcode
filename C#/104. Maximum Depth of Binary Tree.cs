/*
  Solution Credit: https://medium.com/@harycane/maximum-depth-of-a-binary-tree-609d129fa571
  TC: O(n)
  SC: O(n)
  
  The initial two checks are necessary because you cannot use relational operators with null (excluding == and !=).
  You store the results in 'l' and 'r' so you can reference them in the ternary (instead of calling them twice, which
  would be incredibly expensive for a recursive operation).
  
  Finally, the +1 on the end of the ternary is to represent the current node.
  
  3 == null : False
  3 != null : True
  3 > null : False
  3 < null : False
  3 >= null : False
  3 <= null : False

  null == 3 : False
  null != 3 : True
  null > 3 : False
  null < 3 : False
  null >= 3 : False
  null <= 3 : False
*/

public class Solution 
{
    public int MaxDepth(TreeNode root)
    {
      if (root is null) return 0;
      if (root.left is null && root.right is null) return 1;
      
      int l = MaxDepth(root.left);
      int r = MaxDepth(root.right);
      return ((l > r ? l : r) + 1);
    } 
}
