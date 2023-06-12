int[] input = {3,0,0,2,0,4}; 
new Solution().trappingWater(input, input.Length); 

class Solution
    {
        public long trappingWater(int[] arr, int n) 
        { 
            var leftarray = getLeftMaxArray(arr).ToArray();
            var rightarray = getRightMaxArray(arr).ToArray();
        // water stored at point i = min(left[i] and Right[i] ) - 1
        var TotalWater = 0; 
        for (int i = 0; i < arr.Length; i++)
        {
            var minHeightAtPoint = Math.Min(leftarray[i], rightarray[i]);
            TotalWater = TotalWater +( minHeightAtPoint - arr[i]);
        }
        return TotalWater; 
        }

    // get the left max value including current value
        public IEnumerable<int> getLeftMaxArray(int[] arr){
            var left = new int[arr.Length];
            left[0] = arr[0];
            for(int i = 1; i<=arr.Length-1; i++){

                left[i] = Math.Max(left[i-1], arr[i]);
            }
            return left; 
        }

    //get the right max value including curernt value
        public IEnumerable<int> getRightMaxArray(int[] arr){
            var right = new int[arr.Length];
            var n = arr.Length; 
            right[n- 1] = arr[n-1];
            for(int i = n-2; i >= 0; i--){
                right[i] = Math.Max(right[i+1], arr[i]);
            }
            return right; 
        }

}


    