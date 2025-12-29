public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] final = new int[2];

        for(int i = 0; i < nums.Length-1; i++){
             for(int j = i+1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target) {
                    final[0] = i;
                    final[1] = j;
                    return final;
                }
             }
        }

        return final;
    }
}