/*
    TC: O(n) for iterating over the entire list
    SC: O(n) for storing it in a stack
*/
public class Solution 
{
    public string SimplifyPath(string path) 
    {
        LinkedList<string> deque = new();
        string[] dirs = path.Split('/', StringSplitOptions.RemoveEmptyEntries);  //takes care of corner case '/dir//subdir/'
        
        foreach(string dir in dirs)
        {
            switch (dir)
            {
                case ".":
                    continue;
                
                case "..":
                    if (deque.Count != 0)
                    {
                        deque.RemoveLast();
                    }
                    break;
                    
                default:
                    deque.AddLast(dir);
                    break;
            }
        }
        
        //Join results
        string result = "/" + String.Join("/", deque);
        return result.Length == 0 ? "/" : result;
    }
}
