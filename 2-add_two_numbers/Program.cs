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

        ListNode head = null;
        ListNode temp = null;

        int carry = 0;
        // Finding the base case where we have reached the end of the list
        while (l1 != null || l2 != null)
        {
            //se the sum to what we are carrying out of the previous loop
            var sum = carry;

            //the dual ifs here account for lists of different size
            if (l1 != null)
            {
                //add the value and move to the next
                sum += l1.val;
                l1 = l1.next;
            }

            //same stuff but for l2
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            //create our new node and add the mod
            var node = new ListNode(sum % 10);

            // carry over the result of integer division
            carry = sum / 10;

            //swap the nodes to move to the next set and process the next "level"
            if (temp == null)
            {
                temp = node;
                head = node;
            }
            else
            {
                temp.next = node;
                temp = temp.next;
            }
        }

        //if there is a carry then do it again
        if (carry > 0)
        {
            temp.next = new ListNode(carry);
        }

        return head;

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
