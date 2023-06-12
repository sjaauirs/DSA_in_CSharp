// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Solution
{
    //Complete this function
    public void reverseInGroups(int[] A, int N, int K)
    {
        var result = new int[N];
        for (int i = 0; i < N + N % K; i++)
        {
            var part1 = K - (K % i);
            var part2 = K*(Math.Floor((double)i/K));

            var final = part1 + part2;
            if(final< N)
            {
                result[i] = A[(int)final]; 
            }
        }
        A = result;
    }

}
