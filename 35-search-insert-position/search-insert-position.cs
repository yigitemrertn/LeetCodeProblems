public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int res = Array.BinarySearch(nums, target);
        return res >= 0 ? res : Math.Abs(res+1);
    }
}