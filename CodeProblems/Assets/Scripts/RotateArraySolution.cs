/*
Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.


Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

 

Constraints:

    1 <= nums.length <= 105
    -231 <= nums[i] <= 231 - 1
    0 <= k <= 105
*/


public static class RotateArraySolution
{
    public static void Rotate(int[] nums, int k)
    {
        if (k == 0)
        {
            return;
        }

        if (k > nums.Length)
        {
            k = k % nums.Length;
        }

        if (k == 0)
        {
            return;
        }

        if (k == nums.Length)
        {
            return;
        }

        int index = 0;
        int firstIndex = index;

        int adjustIndex = firstIndex;
        int adjustValue = nums[adjustIndex];

        for (int i = 0; i < nums.Length; i++)
        {
            int next = ((index - k) + nums.Length) % nums.Length;
            nums[index] = nums[next];
            int prevIndex = index;
            index = next;

            if (i != 0 && index == adjustIndex)
            {
                nums[prevIndex] = adjustValue;
                index = prevIndex;
                index--;
                index += nums.Length;
                index %= nums.Length;

                adjustIndex = index;
                adjustValue = nums[adjustIndex];
            }
        }
    }
}
