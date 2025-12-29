class Solution{
public bool IsPalindrome(int x)
{
    char[] span = x.ToString().ToCharArray();
    for (int l = 0, r = span.Length -1; l < r; l++, r--)
        {
        if (span[l] != span[r])
        {
            return false;
        }
    }
     return true;
}
}