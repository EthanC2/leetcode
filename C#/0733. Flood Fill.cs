/*
  Approach: depth-first search
*/
public class Solution 
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
    {
      if (image[sr][sc] != newColor)
        fill(image, sr, sc, image[sr][sc], newColor);
        
      return image;
    }
  
    private void fill(int[][] image, int row, int col, int color, int newColor)
    {
      if (image[r][c] == color)
      {
        image[r][c] = newColor;
        if (row >= 1) fill(image, row-1, col, color, newColor);
        if (col >= 1) fill(image, row, col-1, color, newColor);
        if (row+1 < image.Length) fill(image, row+1, col, color, newColor);
        if (col+1 < image[0].Length) fill(image, row, col+1, color, newColor);
      }
    }
}
