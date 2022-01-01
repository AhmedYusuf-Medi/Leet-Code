namespace _04.Linked_List_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = slow;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                { 
                    return true; 
                }
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}