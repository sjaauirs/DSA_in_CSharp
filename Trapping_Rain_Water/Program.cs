int[] input = {3,0,0,2,0,4}; 
new Solution().trappingWater(input); 

class Solution
    {
        public long trappingWater(int[] arr) 
        { 
            var leftarray = getLeftMaxArray(arr);
            var rightarray = getRightMaxArray(arr);
            
            return 0; 
        }

        public IEnumerable<int> getLeftMaxArray(int[] arr){
            var left = new List<int>();
            left[0] = arr[0];
            for(int i = 1; i<arr.Length-1; i++){
                left[i] = maxOfTwo(left[i-1], arr[i]);
            }
            return left; 
        }

        public IEnumerable<int> getRightMaxArray(int[] arr){
            var right = new List<int>();
            var n = arr.Length; 
            right[n- 1] = arr[n-1];
            for(int i = n-1; i >= 0; i--){
                right[i] = maxOfTwo(right[i], arr[i]);
            }
            return right; 
        }

        public int maxOfTwo(int a, int b){
            if(a>=b){return a; }
            return b; 
        }
    }


    