namespace Problems.Problems.Array.convert_sorted_array_to_binary_search_tree
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return BuildBST(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]);

            root.left = BuildBST(nums, left, mid - 1);
            root.right = BuildBST(nums, mid + 1, right);

            return root;
        }
    }
}
}
