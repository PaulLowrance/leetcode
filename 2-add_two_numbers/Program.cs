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

        Console.WriteLine($"l1_string: {l1_string}, l2_string: {l2_string}");

        var output_int = int.Parse(l1_string) + int.Parse(l2_string);

        var output_str = output_int.ToString();

        Console.WriteLine($"l1_string: {l1_string}, l2_string: {l2_string}, output_int: {output_int}, output_str: {output_str}");

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
        if (node.next == null)
        {
            sb.Append(node.val);
            return sb.ToString();
        }

        sb.Append(node.val);
        sb.Append(ConvertListNodeToNumericString(node.next, sb));
        return sb.ToString();

        /*         if (node.next != null)
                {
                    sb.Append(ConvertListNodeToNumericString(node.next, sb));
                }

                sb.Append(node.val);
                return sb.ToString(); */
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
