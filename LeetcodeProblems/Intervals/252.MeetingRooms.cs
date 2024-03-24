using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Questions.Intervals
{
    public class CanAttendMeetingsSolution
    {
        public bool CanAttendMeetings(int[][] interls)
        {
            if (interls == null || interls.Length == 0)
            {
                return true;
            }
            var intervals = Interval.ConvertToIntervalList(interls);
            intervals.Sort(new zerothValueComparer());  // sort the intervels

            int i = 0;
            while (i < intervals.Count - 1)
            {
                int j = i + 1;
                if (intervals[j].Start < intervals[i].End)
                {
                    return false;
                }
                else
                {
                    i = j;
                }
            }
            return true;
        }
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


    class zerothValueComparer : IComparer<Interval>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0].CompareTo(y[0]);

        }

        public int Compare(Interval x, Interval y)
        {
            if (x.End > y.Start)
            {
                return 1;
            }

            if (x.End == y.Start)
            {
                if (x.Start < y.Start) { return 1; }
                else { return 0; }
            }

            return 0;
        }
    }
}
