public class Solution {
    public string AddBinary(string a, string b)
{
    int len = a.Length > b.Length ? a.Length : b.Length;
    a = a.PadLeft(len, '0');
    b = b.PadLeft(len, '0');
    string fin = "";
    int cin = 0;
    for (int i = len-1; i >= 0; i--)
    {
        int inta = (int)char.GetNumericValue(a[i]);
        int intb = (int)char.GetNumericValue(b[i]);
        int sum = inta ^ intb ^ cin;
        cin =  inta & intb | inta & cin| intb & cin;
        fin = sum + fin;
    }
    if (cin != 0)
    {
        return cin + fin;
    }
    return fin;
}
}