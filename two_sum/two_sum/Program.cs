// See https://aka.ms/new-console-template for more information

namespace two_sum;

public class Program
{
    public static void Main(string[] args)
    {
        var set1 = new[] { 2, 7, 11, 15 };
        var target1 = 9;
        var set2 = new[] { 3,2,4 };
        var target2 = 6;
        var set3 = new[] { 3,3 };
        var target3 = 6;

        var s = new Solution();

        var solution1 = s.TwoSum(set1, target1);
        var solution2 = s.TwoSum(set2, target2);
        var solution3 = s.TwoSum(set3, target3);
        
        Console.WriteLine($"[{solution1[0]}, {solution1[1]}]");
        Console.WriteLine($"[{solution2[0]}, {solution2[1]}]");
        Console.WriteLine($"[{solution3[0]}, {solution3[1]}]");
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var hashMap = new List<int[]>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var result = hashMap.FirstOrDefault(a => a[0] ==  nums[i]);
            if (result != null)
                return new []{result[1], i};
            
            hashMap.Add(new []{target - nums[i], i});
        }

        return new[] { -1, -1 };
    }
}