public class Solution {
    public int StrStr(string haystack, string needle)
    {
    int subLen = needle.Length;

    for (int i = 0; i < haystack.Length - subLen + 1; i++)
    {
        if (needle[0] == haystack[i] && needle == haystack.Substring(i, subLen)) return i; 
    }

    return -1;
    }
}