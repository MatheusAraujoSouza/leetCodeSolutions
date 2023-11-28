
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

namespace Problems.Problems.Array
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = j;
                        result[1] = i;
                        return result;
                    }
                }   
            }
            return result;

        }
    }
}
