/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 *
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
 *
 * algorithms
 * Medium (34.57%)
 * Likes:    38848
 * Dislikes: 1817
 * Total Accepted:    5.5M
 * Total Submissions: 16M
 * Testcase Example:  '"abcabcbb"'
 *
 * Given a string s, find the length of the longest substring without repeating
 * characters.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "abcabcbb"
 * Output: 3
 * Explanation: The answer is "abc", with the length of 3.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3.
 * Notice that the answer must be a substring, "pwke" is a subsequence and not
 * a substring.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= s.length <= 5 * 10^4
 * s consists of English letters, digits, symbols and spaces.
 * 
 * 
 */

// @lc code=start
public class LongestSubstringWithoutRepeatingCharacters {
    public int LengthOfLongestSubstring(string s) {
        #region 25 June 2023 submission 

        //    int i = 0; int j = 0 ; 
        //    var i_to_j = 0;
        //    var max_i_to_j = 0;
        //    var set = new HashSet<char>();

        //    while (i < s.Length)
        //    {
        //        var charAtPos = s[i];
        //        if (!set.Contains(charAtPos))
        //        {  
        //             set.Add(charAtPos);
        //        }
        //    else{
        //            while(s[j] == charAtPos){
        //                j++;
        //            }
        //        }
        //       i_to_j = i-j+1; 
        //       max_i_to_j = Math.Max(max_i_to_j , i_to_j);
        //     i++;
        //}   
        //    return Math.Max(max_i_to_j , i_to_j);
        #endregion

        var letters = new Dictionary<char, int>(); // key:letter, val: latest index
        int maxCount = 0, j = 0, i;

        for (i = 0; i < s?.Length; i++)
        {
            char letter = s[i];

            if (letters.ContainsKey(letter))
            { // End the window
                j = Math.Max(j, letters[letter] + 1); // Update j of window        // We only Need logic to get the value of j
            }

            letters[letter] = i; //Update index of letter on map

            maxCount = Math.Max(maxCount, i - j + 1); // Get the longest window length 
        }

        return maxCount;



    }
}
// @lc code=end

