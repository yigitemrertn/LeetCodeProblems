class Solution {
    public int[] productExceptSelf(int[] nums) {
         int n = nums.length;
        int[] total = new int[n];
        int left = 1, right = 1;
        for (int i = n-1; i > -1; i--) {
            total[i] = right;
            right *= nums[i];
        }
          for (int i = 0; i < n; i++) {
              total[i] *= left;  
              left *= nums[i];
              
          } 
        return total;
    }
}