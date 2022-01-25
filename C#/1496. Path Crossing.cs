/*
    To solve this problem, you have to store all the coordinates you have traversed. Naturally, you
    need two variables to represent the current coordinates (an x- and a y-coordinate) and a data structure
    to look them up with. A HashSet<T> has the fastest lookup of any non-associative data structure, so it's
    a natural choice. However, you have to keep in mind that you are storing pairs of coordinates, so you have
    to choose a second data structure to store them in. Here, I chose a ValueTuple instead of a standard Tuple
    because value types are more light-weight (due to not being subject to garbage collection).
*/

public class Solution {
    public bool IsPathCrossing(string path) {
    
        //Setup: declare variables
        int x = 0, y = 0;                              
        var traversed = new HashSet<ValueTuple<int,int>>();    
        traversed.Add((0,0));                                   
        
        //Traverse the string
        foreach(char direction in path)
        {
            switch (direction)
            {
                case 'N':
                    x++;
                    break;
                case 'S':
                    x--;
                    break;
                case 'E':
                    y++;
                    break;
                case 'W':
                    y--;
                    break;
            }
            
            //If the Add operation fails, then it's already in the set (already seen => return true)
            if (!traversed.Add(ValueTuple.Create(x,y)))
                return true;
        }
        
        //If coordinates have been exausted, the path does not cross itself (output: false)
        return false;
    }
}
