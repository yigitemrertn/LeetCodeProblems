public class Solution {
    public string AddBinary(string a, string b)
{
   int len = a.Length > b.Length ? a.Length : b.Length;
a = a.PadLeft(len, '0');
b = b.PadLeft(len, '0');
var sb = new System.Text.StringBuilder();
int cin = 0;
for (int i = len-1; i >= 0; i--)
{
    int inta = (int)char.GetNumericValue(a[i]);
    int intb = (int)char.GetNumericValue(b[i]);
    int sum = inta ^ intb ^ cin;
    cin =  inta & intb | inta & cin| intb & cin;
    sb.Append(sum);
}

if (cin != 0)
{
    sb.Append(cin);
}

char[] result = new char[sb.Length];
sb.CopyTo(0, result, 0, sb.Length);
Array.Reverse(result);



return new string(result);
}
}