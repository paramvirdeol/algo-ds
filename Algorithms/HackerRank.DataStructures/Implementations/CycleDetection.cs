using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    
    public class CycleDetection
    {
        public bool HasCycle(Node head)
        {
            if (head == null) return false;
            Node fast = head.Next;
            Node slow = head;
            while (fast!=null && fast.Next !=null && slow !=null)
            {
                if (fast == slow) return true;
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            return false;
        }


    }

    
}
