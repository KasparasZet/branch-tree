using System;
using System.Collections.Generic;

namespace Branch_Tree
{
    class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
    }        
    class Program
    {

        static void Main(string[] args)
        {
            int n = 0;

            // Recreating task tree
            // Root and 2 depth
            Branch root = new Branch();
            root.branches.Add(new Branch());
            root.branches.Add(new Branch());
            // Left
            // 3 Depth
            root.branches[0].branches.Add(new Branch());
            // Right
            // 3 Depth
            root.branches[1].branches.Add(new Branch());
            root.branches[1].branches.Add(new Branch());
            root.branches[1].branches.Add(new Branch());
            // 4 Depth
            root.branches[1].branches[0].branches.Add(new Branch());
            root.branches[1].branches[1].branches.Add(new Branch());
            root.branches[1].branches[1].branches.Add(new Branch());
            //5 Depth
            root.branches[1].branches[1].branches[0].branches.Add(new Branch());

            Console.WriteLine("Depth of the structure {0}",FindDepth(root, n));
        }

        public static int FindDepth(Branch root, int n)
        {
            int result = n + 1;
            foreach (var item in root.branches)
            {
                result = Math.Max(result, FindDepth(item, n + 1));
            }

            return result;
        }
    }
}
