using System;

public class ProgramMissingNumbers
{
    public int[] MissingNumbers(int[] nums)
    {
        int i = 0;
        bool t1 = false;
        bool t2 = false;
        int[] result = new int[2];
        while (i < nums.Length)
        {
            if (nums[i] > 0 && nums[i] < nums.Length)  // if it is a valid number  // CYCLE SORT
            {
                if (nums[i] != nums[nums[i] - 1]) // number is not at correct position 
                {
                    swap(nums, i, nums[i] - 1);
                }
                else { i++; }
            }
            else
            {
                if (nums[i] == nums.Length)
                {
                    t1 = true;
                }

                if (nums[i] == nums.Length + 1)
                {
                    t2 = true;
                }

                i++;
            }
        }
        int j = 0;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i+1 && j<2)
            {
                result[j] = i+1;
                j++;
            }
        }

        if (!t1) { result[result.Length] = nums.Length; }

        if (!t2) { result[result.Length] = nums.Length + 1; }


        return result;
    }

    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
