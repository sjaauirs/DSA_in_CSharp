namespace LeetcodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FastIO io = new FastIO(); 
               int elementsinTestCase = io.NextInt();
               var InputArray = new int[elementsinTestCase];
               int z = 0;
               while (elementsinTestCase-- > 0) {
                   int n = io.NextInt();
                InputArray[z] = n;
                z++;
               }
               int target = io.NextInt();

               Solution s = new Solution();
            var result=    s.NumSubarrayProductLessThanK(InputArray, target);
                
                io.Flush();
        }
    }

     class FastIO {
            private StreamReader reader;
            private StreamWriter writer;
            private string[] tokens;
            private int pointer;
        
            public FastIO() {
                reader = new StreamReader(@"E:\ComptativeProgramming\LeetcodeProblems\IO\input.txt");
                writer = new StreamWriter(@"E:\ComptativeProgramming\LeetcodeProblems\IO\output.txt");
                tokens = new string[0];
                pointer = 0;
            }
        
            public string Next() {
                while (pointer >= tokens.Length) {
                    tokens = reader.ReadLine().Split();
                    pointer = 0;
                }
                return tokens[pointer++];
            }
        
            public int NextInt() { return int.Parse(Next()); }
            public long NextLong() { return long.Parse(Next()); }
            public double NextDouble() { return double.Parse(Next()); }
        
            public void Flush() { writer.Flush(); }
        }
}

