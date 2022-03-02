/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

/*
  Traversing an N-ary tree is just like traversing a binary tree,
  except you don't know how many children each node has, so you 
  have to use a foreach-loop. Pretty simple.
*/
public class Solution 
{
    public IList<int> Postorder(Node root) 
    {
        List<int> values = new();
        PostOrder(root, values);
        return values;
    }
    
    private void PostOrder(Node root, List<int> values)
    {
        if (root is null) return;
        
        foreach(var node in root.children)
        {
            PostOrder(node, values);   
        }
        values.Add(root.val);
    }
}
