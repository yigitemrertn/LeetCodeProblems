class Solution {
    public void MoveZeroes(int[] nums) {

      int l = 0;
       for (int r = 1; r < nums.Length; r++) {
            if (nums[l] == 0 && nums[r] != 0) {
                nums[l] = nums[r];
                nums[r] = 0;
                l++;
            } else if (nums[l] != 0) {
                l++;
                
            }
       }
   }  
}