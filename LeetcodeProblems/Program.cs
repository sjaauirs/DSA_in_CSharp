using LeetcodeProblems.Questions.CanAttendMeetings;

namespace LeetcodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
       var prob = new LeetcodeProblems.Questions.CanAttendMeetings.Solution();
            int[][] inputArray = new int[][]
             {
                new int[] { 15, 16 },
                new int[] { 10, 15 },
                new int[] { 16, 25 }
             };

            int[] newIntal = { 4, 8 };
            var result = prob.CanAttendMeetings(inputArray);

          
            Console.ReadLine();
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

 