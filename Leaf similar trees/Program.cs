namespace Leaf_similar_trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);

            var sol = new Solution();
            sol.LeafSimilar(root1, root1);
        }
    }



    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            bool same = true;
            string str1 = "";
            string str2 = "";
            void Inorder(TreeNode root, ref string str)
            {
                if (root == null) return;
                if (root.left == null && root.right == null) str = str + "_" + root.val.ToString();
                Inorder(root.left, ref str);
                Inorder(root.right, ref str);
            }

            Inorder(root1, ref str1);
            Inorder(root2, ref str2);
            return str1 == str2;
        }
    }
}
