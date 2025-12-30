public class Solution {
     public int RemoveDuplicates(int[] nums)
 {
     if (nums.Length == 0) return 0;

     int i = 0; // Benzersizlerin index bekçisi

     for (int j = 1; j < nums.Length; j++)
     {
         // Eğer yeni bir sayı bulduysak (farklıysa)
         if (nums[j] != nums[i])
         {
             i++; // Yerimizi bir sağa kaydır
             nums[i] = nums[j]; // Oraya yeni sayıyı yaz (overwrite)
         }
     }

     // i index olduğu için, eleman sayısı i + 1 olur
     return i + 1;
 }
}