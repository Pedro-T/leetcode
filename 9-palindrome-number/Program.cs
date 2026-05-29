using System.Diagnostics;

class Program
{
    public static bool IsPalindrome(int x)
    {
        string seq = x.ToString();
        for (int i = 0; i <= seq.Length / 2; i++)
        {
            if (seq[i] != seq[^(i+1)])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        Debug.Assert(IsPalindrome(55) == true);
        Debug.Assert(IsPalindrome(4) == true);
        Debug.Assert(IsPalindrome(101) == true);
        Debug.Assert(IsPalindrome(1004) == false);
        Debug.Assert(IsPalindrome(-4) == false);
    }
}