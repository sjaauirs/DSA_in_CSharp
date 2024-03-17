/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 *
 * https://leetcode.com/problems/insert-interval/description/
 *
 * algorithms
 * Medium (39.99%)
 * Likes:    10006
 * Dislikes: 762
 * Total Accepted:    1M
 * Total Submissions: 2.5M
 * Testcase Example:  '[[1,3],[6,9]]\n[2,5]'
 *
 * You are given an array of non-overlapping intervals intervals where
 * intervals[i] = [starti, endi] represent the start and the end of the i^th
 * interval and intervals is sorted in ascending order by starti. You are also
 * given an interval newInterval = [start, end] that represents the start and
 * end of another interval.
 * 
 * Insert newInterval into intervals such that intervals is still sorted in
 * ascending order by starti and intervals still does not have any overlapping
 * intervals (merge overlapping intervals if necessary).
 * 
 * Return intervals after the insertion.
 * 
 * Note that you don't need to modify intervals in-place. You can make a new
 * array and return it.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
 * Output: [[1,5],[6,9]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
 * Output: [[1,2],[3,10],[12,16]]
 * Explanation: Because the new interval [4,8] overlaps with
 * [3,5],[6,7],[8,10].
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= intervals.length <= 10^4
 * intervals[i].length == 2
 * 0 <= starti <= endi <= 10^5
 * intervals is sorted by starti in ascending order.
 * newInterval.length == 2
 * 0 <= start <= end <= 10^5
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int[][] Insert(int[][] interls, int[] newIntal) {

        if (interls == null || interls.Length == 0)
        {
           var oneresult = new List<Interval>();
            oneresult.Add(Interval.ToInterval(newIntal));
            return Interval.ReturnIntervalToArray(oneresult);
        }


        var intervals = Interval.ConvertToIntervalList(interls);
        var newInterval = Interval.ToInterval(newIntal);

        List<Interval> Results = new List<Interval>();

        int i = 0;

        while (i < intervals.Count && intervals[i].End < newInterval.Start)
        {

            Console.WriteLine("Processing {0} with {1}", intervals[i], newInterval);
            Console.WriteLine("Donothing -- Add to result Array");
            Results.Add(intervals[i]);
            i++;
        }

        while (i < intervals.Count && intervals[i].Start <= newInterval.End)
        {

            Console.Write("Kuch to kerna padega for {0} and {1}", intervals[i], newInterval);
        newInterval.Start = Math.Min(intervals[i].Start, newInterval.Start);
        newInterval.End = Math.Max(intervals[i].End, newInterval.End);
        
        Console.WriteLine("  Merge to =====>{0}", newInterval);
        i++;
        }

        // insert the newInterval
        Results.Add(newInterval);

        // add all the remaining intervals to the output
        while (i < intervals.Count)
        {
            Results.Add(intervals[i]);
            i++;
        }



        foreach (Interval interval in Results)
        {
            Console.WriteLine(interval);
        }

        return Interval.ReturnIntervalToArray(Results);


    }

    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"[{Start}, {End}]";
        }

        public static Interval ToInterval(int[] array)
        {
            return new Interval(array[0], array[1]);
        }

        public static List<Interval> ConvertToIntervalList(int[][] array)
        {
            List<Interval> intervals = new List<Interval>();

            foreach (int[] intervalArray in array)
            {
                int start = intervalArray[0];
                int end = intervalArray[1];
                intervals.Add(new Interval(start, end));
            }

            return intervals;
        }

        public static int[][] ReturnIntervalToArray(List<Interval> intervals)
        {
            int[][] intervalsArray = new int[intervals.Count][];

            for (int i = 0; i < intervals.Count; i++)
            {
                intervalsArray[i] = new int[] { intervals[i].Start, intervals[i].End };
            }

            return intervalsArray;
        }
    }
}
// @lc code=end

