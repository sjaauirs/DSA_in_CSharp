/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [340] Longest With K distinct
 *
 *https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/description/
 *
 * 
 * Given a string s and an integer k, return the length of the longest 
   substring
 of s that contains at most k distinct characters.
 * 
Example 1:

Input: s = "eceba", k = 2
Output: 3
Explanation: The substring is "ece" with length 3.
Example 2:

Input: s = "aa", k = 1
Output: 2
Explanation: The substring is "aa" with length 2.
 * 
 * 
 */

// @lc code=start
using System.Collections;

public class LongestSubstringWithAtMostKDistinct {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {

        var n = s.Length;
        if(n ==0 || k == 0) return 0;
        int r = 0; int i = 0;
        int max_size = 0;
        int dic_sum = 0; 
        var letters = new Dictionary<char, int>();

        while (r < n)
        {
            var charAtpos = s[r];

            if (letters.ContainsKey(charAtpos))                             // If letter exist in Dictionary, we it is not distict.. just increase the counter
            {
                var countOfLetter = letters[charAtpos];
                letters.Remove(charAtpos);  // remove and add will preserve insert order
                letters.Add(charAtpos, countOfLetter + 1);
                dic_sum++;                                                  // increase the counter for number of element in the list
                max_size = Math.Max(dic_sum, max_size);
            }
            else
            {
                if (letters.Keys.Count < k)                                // If element does not exist and we did not have K distinct Add to dictionary 
                {
                    letters.Add(charAtpos, 1);
                    dic_sum++;
                    max_size = Math.Max(dic_sum, max_size);
                }
                else
                {
                    bool WindowIsInvalid = true;
                    letters.Add(charAtpos, 1);
                    dic_sum++;                                         // Adding a new charracter make your Dictionary INVALID
                    while (WindowIsInvalid)                           // Move the right side of window till it become VALID  
                    {
                        var windowRightChar = s[i];
                        if (letters[windowRightChar] > 1)
                        {
                            letters[windowRightChar] = letters[windowRightChar]-1;
                        }
                        else if (letters[windowRightChar] == 1)
                        {
                            letters.Remove(windowRightChar);
                            WindowIsInvalid = false;
                        }
                        dic_sum--;
                        i++;
                    }
                    max_size = Math.Max(dic_sum, max_size);
                }
            }
            r++;
        }


        return max_size;
    }

#region DESIGN GURU IMPLEMENTATION -- BETTER CODE 

    public int findLength(string str, int k)
        {
            if (str == null || str.Length == 0 || str.Length < k)
                throw new ArgumentException();

            int windowStart = 0, maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();
            // in the following loop we'll try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                charFrequencyMap[rightChar] = charFrequencyMap.GetValueOrDefault(rightChar, 0) + 1;
                // shrink the sliding window, until we are left with 'k' distinct characters in
                // the frequency map
                while (charFrequencyMap.Count > k)
                {
                    char leftChar = str[windowStart];
                    charFrequencyMap[leftChar] = charFrequencyMap[leftChar] - 1;
                    if (charFrequencyMap[leftChar] == 0)
                    {
                        charFrequencyMap.Remove(leftChar);
                    }
                    windowStart++; // shrink the window
                }
                // remember the maximum length so far
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }

#endregion

    }
// @lc code=end

