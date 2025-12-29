public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> m = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        Stack<char> open = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (m.ContainsKey(s[i]))
            {
                open.Push(s[i]);
            }
            else
            {
                if (open.Count == 0) return false;
                char lastOpen = open.Pop();
                if (m[lastOpen] != s[i]) return false;
            }
        }

        return open.Count == 0;
    }

}