    /*
 * @lc app=leetcode id=986 lang=csharp
 *
 * [986] Interval List Intersections
 *
 * https://leetcode.com/problems/interval-list-intersections/description/
 *
 * algorithms
 * Medium (71.46%)
 * Likes:    5464
 * Dislikes: 109
 * Total Accepted:    396.7K
 * Total Submissions: 555K
 * Testcase Example:  '[[0,2],[5,10],[13,23],[24,25]]\n[[1,5],[8,12],[15,24],[25,26]]'
 *
 * You are given two lists of closed intervals, firstList and secondList, where
 * firstList[i] = [starti, endi] and secondList[j] = [startj, endj]. Each list
 * of intervals is pairwise disjoint and in sorted order.
 * 
 * Return the intersection of these two interval lists.
 * 
 * A closed interval [a, b] (with a <= b) denotes the set of real numbers x
 * with a <= x <= b.
 * 
 * The intersection of two closed intervals is a set of real numbers that are
 * either empty or represented as a closed interval. For example, the
 * intersection of [1, 3] and [2, 4] is [2, 3].
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: firstList = [[0,2],[5,10],[13,23],[24,25]], secondList =
 * [[1,5],[8,12],[15,24],[25,26]]
 * Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: firstList = [[1,3],[5,9]], secondList = []
 * Output: []
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= firstList.length, secondList.length <= 1000
 * firstList.length + secondList.length >= 1
 * 0 <= starti < endi <= 10^9
 * endi < starti+1
 * 0 <= startj < endj <= 10^9 
 * endj < startj+1
 * 
 * 
 * NOTE : DesignGuru solution work with 2 pointer also. worth read.
 * 
 */

// @lc code=start

public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        // Each intervals is pairwise disjoint and in sorted order.

        var firstIntervals = Interval.ConvertToIntervalList(firstList);
        var secondIntervals = Interval.ConvertToIntervalList(secondList);

        var result =new List<Interval>();

        foreach (var interval in secondIntervals)
        {
         var res= findIntersections(firstIntervals, interval);
            result.AddRange(res);
        }


        return Interval.ReturnIntervalToArray(result);
    }

    private IEnumerable<Interval> findIntersections(List<Interval> firstIntervals, Interval mergingInterval)
    {
       var ans = new List<Interval>();

        int i = 0; 
        while (i < firstIntervals.Count && firstIntervals[i].end < mergingInterval.start) {   // ignore all intervals which come earlier
                i++;
            }
        while (i < firstIntervals.Count && firstIntervals[i].start <= mergingInterval.end)
        {
            // firstIntervals[i] is impacted from merging Interval
            var iStart = Math.Max(firstIntervals[i].start , mergingInterval.start);
            var iEnd = Math.Min(firstIntervals[i].end, mergingInterval.end);
            ans.Add(new Interval(iStart, iEnd));
            i++;
        }
        return ans; 
    }
}

public class Interval
{
    public int start { get; set; }
    public int end { get; set; }

    public Interval(int start, int end)
    {
        this.start = start;
        this.end = end;
    }

    public override string ToString()
    {
        return $"[{start}, {end}]";
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
            intervalsArray[i] = new int[] { intervals[i].start, intervals[i].end };
        }

        return intervalsArray;
    }
}

class IntervalComparer : IComparer<Interval>
{
    public int Compare(Interval x, Interval y)
    {
        if (x.start == y.start)
        {
            return x.end - y.end;
        }

        return x.start - y.start;
    }
}

// @lc code=end

