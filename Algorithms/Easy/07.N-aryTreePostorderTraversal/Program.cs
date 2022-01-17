namespace _07.N_aryTreePostorderTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
        }

        //Iterative
        public IList<int> PostOrder(Node root)
        {
            IList<int> result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            Node last = null; 
            Node temp = null;
            root = null;

            while (stack.Count > 0 || root != null)
            {
                if (root != null)
                {
                    foreach (var child in root.children.Reverse())
                    {
                        stack.Push(child);
                    }

                    root = null;
                }

                while (stack.Count > 0 && root == null)
                {
                    temp = stack.Peek();

                    if (temp.children.Count == 0 || temp.children[temp.children.Count - 1] == last)
                    {
                        result.Add(temp.value);
                        last = stack.Pop();
                    }
                    else
                    {
                        root = temp;
                    }
                }
            }

            return result;
        }

        //public IList<int> PostOrder(Node root)
        //{
        //    IList<int> result = new List<int>();
        //    Get(root);
        //    return result;
        //    // local func
        //    void Get(Node r)
        //    {
        //        if (r == null) return;
        //        foreach (var child in r.children)
        //            Get(child);
        //        result.Add(r.val);
        //    }

        //    return result;
        //}

        public void Get(Node r, IList<int> ans)
        {
            if (r == null) return;
            foreach (var child in r.children)
                Get(child, ans);
            ans.Add(r.value);
        }

        public class Node
        {
            public int value;
            public IList<Node> children;

            public Node() 
            { 

            }

            public Node(int value)
            {
                this.value = value;
            }

            public Node(int value, IList<Node> children)
            {
                this.value = value;
                this.children = children;
            }
        }
    }
}