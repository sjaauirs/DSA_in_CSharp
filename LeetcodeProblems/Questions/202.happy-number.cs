/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start

using System;

public class SolutionHappy {
    public bool IsHappy(int n) {
        var slowList = n;
        var fastList = n;
        while(true) 
        {
            slowList = CalculateNext(slowList);
            fastList = CalculateNext(CalculateNext(fastList));
            
            if (slowList == fastList)
            {
                break;
            }
        }

        if(slowList== 1) { return true; }

        return false;
    }

    private int CalculateNext(int num)
    {
        int sum = 0, digit;
        while (num > 0)
        {
            digit = num % 10;
            sum = sum+(digit * digit);
            num = num/ 10;
        }
        return sum;
    }
}
// @lc code=end

