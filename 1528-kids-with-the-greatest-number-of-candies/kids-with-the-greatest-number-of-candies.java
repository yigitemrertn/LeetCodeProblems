import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
class Solution {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
     List<Boolean> list = new ArrayList<>(); 

        for (int i = 0; i < candies.length; i++) {
            int count = 0;
            for (int j = 0; j < candies.length; j++) {
                if (candies[i] + extraCandies >= candies[j]) {
                    count++;
                }
            }
            if (count == candies.length) {
                list.add(true);
            }
            else list.add(false);
        }

        return list;
    }
}