using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    public class NodeLinkedList
    {
        public void run()
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
                return new Node(data);
            else if (head.next == null)
            {
                head.next = new Node(data);
                return head;
            }
            else
            {
                var here = insert(head.next, data);
                return head;
            }
        }

        public void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
}
