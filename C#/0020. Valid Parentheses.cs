//Problem explanation (C#): https://cis300.cs.ksu.edu/stacks-queues/paren/


/*
    To find a valid solution for this problem, you have to iterate over every character in the string,
    keeping track of the most recently opening parenthesis. If you coming across a closing parenthesis
    that does not match the most recently opening parenthesis, they the string is malformed (invalid).
    By the time you finish iterating over the string, you should have no unmatched opening parentheses
    (which means the stack should be empty)
*/
public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> stk = new();
        
        foreach(char paren in s)
        {
            if (paren == '(' || paren == '{' || paren == '[') //push onto stack
            {
                stk.Push(paren);
            }
            else if (stk.Count != 0) //match the paren
            {
                if (stk.Peek() == '(' && paren == ')')    //if ( and )
                { 
                    stk.Pop();
                }
                else if (stk.Peek() == '[' && paren == ']')  //if [ and ]
                {
                    stk.Pop();
                }
                else if (stk.Peek() == '{' && paren == '}')  //if { and }
                {
                    stk.Pop();
                }
                else
                    return false;
            }
            else
                return false;
                
        }
        
        //If all parentheses were matched, the stack should be empty
        return stk.Count == 0;
    }
}
