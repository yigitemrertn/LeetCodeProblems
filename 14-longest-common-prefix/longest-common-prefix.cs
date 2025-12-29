public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string result = "";
        int n = int.MaxValue;
        foreach (var item in strs)
        {
            if (item.Length < n)
            {
                n = item.Length;
            }
        }
        int length = strs.Length;
        for (int i = 0; i < n; i++)
        {
            char temp = strs[0][i];
            for (int j = 0; j < length; j++)
            {
                if (strs[j][i] != temp)
                {
                    return result;
                }
            }
            result += temp;
        }
        return result;
    }
}