/*
   TC: O(n)
   SC: O(n)
*/
public class Solution 
{
    public bool ValidateStackSequences(int[] pushed, int[] popped) 
    {
        Stack<int> stk = new();
        
        int i = 0;
        foreach(int pushedNum in pushed)
        {
            stk.Push(pushedNum);
            
            while (stk.Count != 0 && stk.Peek() == popped[i])
            {
                stk.Pop();
                i++;
            }
        }
        
        return i == pushed.Length;
    }
}
