namespace longest_palindromic_substring;
class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();

        Console.WriteLine($"is radar: {s.IsPalindrome("radar")}");
        Console.WriteLine($"is boob: {s.IsPalindrome("boob")}");
        Console.WriteLine($"is cat: {s.IsPalindrome("cat")}");
        Console.WriteLine($"is dd: {s.IsPalindrome("dd")}");
    }
}

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var palindromes = new List<string>();
        int max_len, start_idx = 0;

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                var sub_str = s.Substring(i, j - i);
                if (IsPalindrome(sub_str))
                    palindromes.Add(sub_str);
            }
        }
        return palindromes.Aggregate("", (max, curr) => max.Length > curr.Length ? max : curr);
    }

    public bool IsPalindrome(string s)
    {
        var beginIdx = 0;
        var endIdx = s.Length - 1;

        for (var i = 0; i <= Math.Floor(s.Length / 2.0); i++)
        {
            if (s[i] == s[endIdx])
            {
                endIdx--;
                continue;
            }

            return false;
        }

        return true;
    }
}
