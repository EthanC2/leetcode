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
public class Solution {
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var tree1 = new Stack<int>();
        var tree2 = new Stack<int>();
        var allElems = new List<int>();
        
        //Traverse both trees, filling the stacks
        DFS(tree1, root1);
        DFS(tree2, root2);
        
       while (tree1.Count != 0 && tree2.Count != 0)
       {
           if (tree1.Peek() <= tree2.Peek())
               allElems.Add(tree1.Pop());
           else
               allElems.Add(tree2.Pop());
       }
        
        while (tree1.Count != 0)
        {
            allElems.Add(tree1.Pop());
        }
        
        while (tree2.Count != 0)
        {
            allElems.Add(tree2.Pop());
        }
        
        return allElems;
    }
    
    //In-order depth first search using tree recursion
    public void DFS(Stack<int> stk, TreeNode node)
    {
        if (node is null) return;
        
        //Traverse tree
        DFS(stk, node.right);
        stk.Push(node.val);
        DFS(stk, node.left);
    }
}
