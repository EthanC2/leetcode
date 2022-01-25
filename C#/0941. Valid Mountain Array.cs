public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
        //Declare an iterator that can persist across loops
        int i = 0;
        
        //Walk up the mountain
        while (i+1 < arr.Length && arr[i] < arr[i+1])
            i++;
        
        //1. The transition point must have points on both sides
        //2. Implicitly takes care of 'arr.Length >= 3' requirement
        if (i == 0 || i == arr.Length-1) 
            return false;
        
        //Walk down the mountain
        while (i+1 < arr.Length && arr[i] > arr[i+1])
            i++;
        
        //If you reached the end, then you were successful
        return i == arr.Length-1;
    }
}
