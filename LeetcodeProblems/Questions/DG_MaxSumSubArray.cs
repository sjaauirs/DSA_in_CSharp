public class DesignGuruMaximizeSum{
    public int MaximizeSum(int[] nums, int k) {
        int i = 0;
        int j = 0;
        var sum = 0;                                       //WindowSum
        while (j < k) {
            sum = sum + nums[j];
            j++;
        }
        j = k - 1;   // RESET j to WINDOW END            CASE1
        var maxSum = sum;
        /*WINDOW is INITIALIZED 
         * I --> WINDOW START
         * J -->WINDOW END
         * MAXSUM = WINDOW SUM = SUM OF WINDOW
         */

        while (j < nums.Length-1)   // Because WINDOW is going to be increased INSIDE loop and then used 
        {
            j++; i++;                       // As per the use case we need to increase the loop pointers or say window
            sum = sum + nums[j] - nums[i-1];  // Add the incoming item and remove the outgoing from the window
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum;
    }

   /*
    * Case1 : FIRST value of J is used ans then increased.. we know value will cross the boundry to break the loop
    * so we need to reset
    * 
    * case2 : because we are increasing and then used make sure to check pointers are valid
    */
}

