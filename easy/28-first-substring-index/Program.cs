using System.Diagnostics;

class Program
{
    
    static int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        if (haystack.Equals(needle))
        {
            return 0;
        }
        int idx = 0;
        while (idx < (haystack.Length - needle.Length + 1))
        {
            for (int i = 0; i < needle.Length; i++)
            {
                if (needle[i] != haystack[idx+i])
                {
                    break;
                }
                if (i == needle.Length - 1)
                {
                    return idx;
                }
            }
            idx++;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Debug.Assert(StrStr("leetcode", "leeto") == -1);
        Debug.Assert(StrStr("sadbutsad", "sad") == 0);
        Debug.Assert(StrStr("sadbutsad", "but") == 3);
        Debug.Assert(StrStr("a", "a") == 0);
        Debug.Assert(StrStr("abc", "c") == 2);
    }
}