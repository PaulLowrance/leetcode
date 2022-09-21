using System.Text;

namespace Add_two_numbers;
class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();

        var firstSet_L1 = new[] { 2, 4, 3 };
        var firstSet_L2 = new[] { 5, 6, 4 };
        var resultNode1 = s.AddTwoNumbers(CreateNodeFromArray(firstSet_L1), CreateNodeFromArray(firstSet_L2));


        var secondSet_L1 = new[] { 0 };
        var secondSet_L2 = new[] { 0 };
        var resultNode2 = s.AddTwoNumbers(CreateNodeFromArray(secondSet_L1), CreateNodeFromArray(secondSet_L2));

        var thirdSet_L1 = new[] { 9, 9, 9, 9, 9, 9, 9 };
        var thirdSet_L2 = new[] { 9, 9, 9, 9 };
        var resultNode3 = s.AddTwoNumbers(CreateNodeFromArray(thirdSet_L1), CreateNodeFromArray(thirdSet_L2));

        var forthSet_L1 = new[] { 9 };
        var forthSet_L2 = new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9, };
        var resultNode4 = s.AddTwoNumbers(CreateNodeFromArray(forthSet_L1), CreateNodeFromArray(forthSet_L2));

    }

    private static ListNode CreateNodeFromArray(int[] arr, int counter = 0)
    {
        //handle array with only one value
        if (arr.Length == 1)
            return new ListNode(arr[0], null);

        //handle the last value in the array
        if (counter == arr.Length - 1)
            return new ListNode(arr[counter], null);

        return new ListNode(arr[counter], CreateNodeFromArray(arr, counter + 1));
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var l1_string = ConvertListNodeToNumericString(l1, new StringBuilder());
        var l2_string = ConvertListNodeToNumericString(l2, new StringBuilder());

        var l1_charArr = l1_string.ToCharArray();
        Array.Reverse(l1_charArr);
        var l2_charArr = l2_string.ToCharArray();
        Array.Reverse(l2_charArr);

        Console.WriteLine($"l1_string: {new string(l1_charArr)}, l2_string: {new string(l2_charArr)}");

        var output_int = int.Parse(new string(l1_charArr)) + int.Parse(new string(l2_charArr));

        var output_arr = output_int.ToString().ToCharArray();
        Array.Reverse(output_arr);
        var output_str = new string(output_arr);

        Console.WriteLine($"l1_string: {new string(l1_charArr)}, l2_string: {new string(l2_charArr)}, output_int: {output_int}, output_str: {output_str}");

        return ConvertOutputSumToListNode(output_str);
    }

    private ListNode ConvertOutputSumToListNode(string output_str)
    {
        if (output_str.Length == 1)
        {
            return new ListNode(int.Parse(output_str[0].ToString()), null);
        }
        return new ListNode(int.Parse(output_str[0].ToString()), ConvertOutputSumToListNode(output_str.Remove(0, 1)));
    }

    private string ConvertListNodeToNumericString(ListNode node, StringBuilder sb)
    {
        sb.Append(node.val);

        if (node.next == null)
            return sb.ToString();

        return ConvertListNodeToNumericString(node.next, sb);
    }

}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
