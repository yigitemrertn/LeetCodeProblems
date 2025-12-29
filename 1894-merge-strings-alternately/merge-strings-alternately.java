class Solution {
    public String mergeAlternately(String word1, String word2) {
        String mergedWord = "";
        int i;

        if(word1.length()> word2.length()){
        for ( i = 0; i < word2.length(); i++) {
            mergedWord += word1.charAt(i);
            mergedWord+= word2.charAt(i);
        }
        for(int a = i; a<word1.length();a++){
            mergedWord+=word1.charAt(a);
        }
       }

       else if(word1.length()< word2.length()){
        for ( i = 0; i < word1.length(); i++) {
            mergedWord += word1.charAt(i);
            mergedWord+= word2.charAt(i);
        }
        for(int a = i; a<word2.length();a++){
            mergedWord+=word2.charAt(a);
        }
       }

       else{
        for ( i = 0; i < word1.length(); i++) {
            mergedWord += word1.charAt(i);
            mergedWord+= word2.charAt(i);
        }

       

    }
     return mergedWord;
}
}