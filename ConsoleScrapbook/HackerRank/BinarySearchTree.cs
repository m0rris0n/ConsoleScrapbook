using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    public class BinarySearchTree
    {
        public void run()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        public int getHeight(Node root)
        {
            //Write your code here
            if (root.left == null && root.right == null)
            {
                return 0;
            }

            int lDepth = 0;
            int rDepth = 0;

            if (root.left != null)
            {
                lDepth = 1 + getHeight(root.left);
            }
            if (root.right != null)
            {
                rDepth = 1 + getHeight(root.right);
            }
            if (lDepth >= rDepth)
                return lDepth;
            else
                return rDepth;

        }

        public Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}


