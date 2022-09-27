namespace _3_longest_substring_wo_repeating;
class Program
{
    static void Main(string[] args)
    {
        var input_1 = "abcabcbb";
        var input_2 = "bbbbbbbbbbbbbbbbbbb";
        var input_3 = "pwwkew";
        var input_4 = " ";
        var input_5 = "";
        var input_6 = "au";
        var input_7 = "aab";
        var input_8 = "abb";

        var s = new Solution();

        Console.WriteLine("********************INPUT 1****************************");
        var result_1 = s.LengthOfLongestSubstring(input_1);

        Console.WriteLine("********************INPUT 2****************************");
        var result_2 = s.LengthOfLongestSubstring(input_2);

        Console.WriteLine("********************INPUT 3****************************");
        var result_3 = s.LengthOfLongestSubstring(input_3);

        Console.WriteLine("********************INPUT 4****************************");
        var result_4 = s.LengthOfLongestSubstring(input_4);

        Console.WriteLine("********************INPUT 5****************************");
        var result_5 = s.LengthOfLongestSubstring(input_5);

        Console.WriteLine("********************INPUT 6****************************");
        var result_6 = s.LengthOfLongestSubstring(input_6);

        Console.WriteLine("********************INPUT 7****************************");
        var result_7 = s.LengthOfLongestSubstring(input_7);

        Console.WriteLine("********************INPUT 8****************************");
        var result_8 = s.LengthOfLongestSubstring(input_8);

        Console.WriteLine($"Input 1: {input_1} |Expects: 3 - Result 1: {result_1}");
        Console.WriteLine($"Input 2: {input_2} |Expects: 1 - Result 2: {result_2}");
        Console.WriteLine($"Input 3: {input_3} |Expects: 3 - Result 3: {result_3}");
        Console.WriteLine($"Input 4: {input_4} |Expects: 1 - Result 4: {result_4}");
        Console.WriteLine($"Input 5: {input_5} |Expects: 0 - Result 5: {result_5}");
        Console.WriteLine($"Input 6: {input_6} |Expects: 2 - Result 6: {result_6}");
        Console.WriteLine($"Input 7: {input_7} |Expects: 2 - Result 7: {result_7}");
        Console.WriteLine($"Input 7: {input_8} |Expects: 2 - Result 8: {result_8}");
    }
}


public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var arr = s.ToCharArray();
        var tmpArr = new List<char>();
        var charSeen = new Dictionary<char, int>();

        var longestSubstring = 0;
        var subStrStartIdx = 0;

        for (var i = 0; i < arr.Length; ++i)
        {
            //            Console.WriteLine($"Processing [idx]: {arr[i]}[{i}]...");

            if (charSeen.ContainsKey(arr[i]))
            {
                subStrStartIdx = Math.Max(subStrStartIdx, charSeen[arr[i]] + 1);
            }

            charSeen[arr[i]] = i;
            longestSubstring = Math.Max(longestSubstring, i - subStrStartIdx + 1);

            /*             if (longestSubstring < 1)
                            longestSubstring = 1;

                        if (tmpArr.Any(c => c == arr[i]))
                        {
                            //               Console.WriteLine($"tmpArray string: {new string(tmpArr.ToArray())}");
                            var tmpArrCount = tmpArr.Count();

                            if (tmpArrCount > longestSubstring)
                                longestSubstring = tmpArrCount;

                            var tmpArrStart = tmpArr.LastIndexOf(arr[i]) >= 0 ? tmpArr.IndexOf(arr[i]) : 0;

                            Console.WriteLine($"Array: {new string(tmpArr.ToArray())} - start idx: {tmpArrStart}");

                            tmpArr = tmpArr.GetRange(tmpArrStart, tmpArr.Count() - 1);

                            Console.WriteLine($"Modified Array: {new string(tmpArr.ToArray())} - start idx: {tmpArrStart}");
                        }
                        else
                        {
                            Console.WriteLine($"tmpArr Added: {arr[i]}...");
                            tmpArr.Add(arr[i]);

                            if (tmpArr.Count() > longestSubstring)
                                longestSubstring = tmpArr.Count();
                        } */
        }

        return longestSubstring;
    }
}