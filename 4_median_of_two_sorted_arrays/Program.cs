namespace MedianOfTwoSortedArrays;
class Program
{
    static void Main(string[] args)
    {
        var s1_arr1 = new[] { 1, 3 };
        var s1_arr2 = new[] { 2 };
        var s2_arr1 = new[] { 1, 2 };
        var s2_arr2 = new[] { 3, 4 };
        var s3_arr1 = new[] { 1, 2, 3, 7, 8 };
        var s3_arr2 = new[] { 2, 3, 10, 12, 13, 14, 15 };
        var s4_arr1 = new[] { 1, 3 };
        var s4_arr2 = new[] { 2 };

        var s = new Solution();

        Console.WriteLine("*********************** Set 1 ***********************");
        var result_1 = s.FindMedianSortedArrays(s1_arr1, s1_arr2);
        Console.WriteLine($"arr_1: [{string.Join(',', s1_arr1)}]");
        Console.WriteLine($"arr_2: [{string.Join(',', s1_arr2)}]");
        Console.WriteLine($"Result: {result_1}");

        Console.WriteLine("*********************** Set 2 ***********************");
        var result_2 = s.FindMedianSortedArrays(s2_arr1, s2_arr2);
        Console.WriteLine($"arr_1: [{string.Join(',', s2_arr1)}]");
        Console.WriteLine($"arr_2: [{string.Join(',', s2_arr2)}]");
        Console.WriteLine($"Result: {result_2}");

        Console.WriteLine("*********************** Set 3 ***********************");
        var result_3 = s.FindMedianSortedArrays(s3_arr1, s3_arr2);
        Console.WriteLine($"arr_1: [{string.Join(',', s3_arr1)}]");
        Console.WriteLine($"arr_2: [{string.Join(',', s3_arr2)}]");
        Console.WriteLine($"Result: {result_3}");

        Console.WriteLine("*********************** Set 4 ***********************");
        var result_4 = s.FindMedianSortedArrays(s4_arr1, s4_arr2);
        Console.WriteLine($"arr_1: [{string.Join(',', s4_arr1)}]");
        Console.WriteLine($"arr_2: [{string.Join(',', s4_arr2)}]");
        Console.WriteLine($"Result: {result_4}");

    }


    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = double.NaN;
            var merged_arr = nums1.Concat(nums2).OrderBy(x => x).ToArray();

            //Console.WriteLine($"Merged Array: [{string.Join(',', merged_arr)}]");
            if (merged_arr.Length % 2 == 0)
            {
                int lo_mid = (int)Math.Floor(merged_arr.Length / 2.0) - 1;
                result = (merged_arr[lo_mid] + merged_arr[lo_mid + 1]) / 2.0;
            }
            else
            {
                int lo_mid = (int)Math.Floor(merged_arr.Length / 2.0) - 1;
                result = merged_arr[lo_mid + 1];
            }

            return result;
        }
    }
}
