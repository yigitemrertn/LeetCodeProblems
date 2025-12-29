public class Solution {
     public int RomanToInt(string s)
 {
     int res = 0;
     Dictionary<string, int> dict = new Dictionary<string, int>
     {
         {"I", 1 },{"IV", 4 },{"V", 5 },{"IX",9 },{"X", 10 },{"XL",40 },{"L",50 },
         {"XC", 90 },{ "C", 100},{ "CD", 400 },{"D",500 },{"CM", 900 },{"M",1000 }
     };

     int c = 0;
     while(c < s.Length)
     {
         string current = s[c].ToString();
         string next = c+1 < s.Length ? s[c+1].ToString() : "";
         if (dict.ContainsKey(current + next))
         {
             res += dict[current + next];
             c += 2;
         }
         else
         {
             res += dict[current];
             c++;
         }
     }
     return res;
 }
}