// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0;
        int j = height.Length - 1;
        int MaxArea = 0; 
        while(i < j)
        {
            var Area = Math.Min(height[i], height[j]) * (j - i);
            MaxArea = Math.Max(MaxArea, Area);
            if(height[i] < height[j])
            {
                i++; 
            }
            else
            {
                j--;
            }
        }

        return MaxArea; 
    }
}
