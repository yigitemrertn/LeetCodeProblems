class Solution {
    public int maxArea(int[] height) {
         int n = height.length;
        int result = 0;
        if (n < 2) {
            return 0;
        }
        
        int l = 0, r = n-1;
        while (l<r) {
            int w = r-l;
            int h = Integer.min(height[l], height[r]);
            
            if (w*h > result) {
                result = w*h;
            }

            if (height[r] < height[l]) {
                r--;
            }else{
                l++;
            }
        }

        return result;
    }
}