/*
  Although this problem is really neat, it's also horribly explained, Here's my attempt:
  CPUs are optimized to transfer words, which is a fixed-size unit of memory.
  In this context a word is 4-bytes, which is why this problem has you read 4 chars at a time since
  each char is 1 byte. 
  
  They ask you to read 'n' characters (the max size of the buffer)
  and no more, otherwise the buffer will overflow. However, the provided function 'Read4',
  which reads 4 chars into a buffer that is passed by reference and returns how many characters
  were read from the file (possibly 0-4), ALWAYS reads 4 characters.
  
  So, he way to solve this problem is to delcare a temporary buffer 'tempbuf' of 4 chars
  that acts as an intermediary between the source (the file) and the destination (the char buffer).

  TC: O(n)
  SC: O(1)
*/

/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf4);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
    public int Read(char[] buf, int n) 
    {
        char[] tempbuf = new char[4];
        int totalCopied = 0, charsRead = 4;
        
        while (totalCopied < n && charsRead == 4)
        {
            charsRead = Read4(tempbuf);
            
            for(int i=0; i < charsRead; ++i)
            {
                if (totalCopied == n)
                    return totalCopied;
                
                buf[totalCopied] = tempbuf[i];
                totalCopied++;
            }
        }
        
        return totalCopied;
    }
}
