class Solution {
    public boolean isSubsequence(String s, String t) {
         if (s.length() == 0) {
            return true;
            
        }
         String temp = "";
        int tl = t.length();
        int i = 0;
        int j = 0;

        while (j < tl) {
            if (s.charAt(i) == t.charAt(j)) {
                temp += t.charAt(j);
                if (s.equals(temp)) {
                    return true;
                }
                i++;
                j++;

            } else {
                j++;
            }
        }

        return false;
    }
}