public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        
        Console.WriteLine(s.IsPalindrome(121));
        Console.WriteLine(s.IsPalindrome(-121));
        Console.WriteLine(s.IsPalindrome(10));
        Console.WriteLine(s.IsPalindrome(1000021));
    }
}

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x <= 0)
            return false;
        
        var digits = new List<int>();
        for (; x != 0; x /= 10)
            digits.Add(x % 10);

        var reversedArr = digits.ToArray();
        Array.Reverse(reversedArr);

        for (var i = 0; i < digits.Count; i++)
        {
            if (digits.ToArray()[i] != reversedArr[i])
                return false;
        }
        return true;
    }
}