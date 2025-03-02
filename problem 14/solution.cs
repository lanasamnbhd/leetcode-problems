using System;

class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closestSum = int.MaxValue / 2; // Büyük bir değer ama taşma yok

        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1, right = nums.Length - 1;
            while (left < right) {
                int currentSum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target)) {
                    closestSum = currentSum;
                }
                if (currentSum < target) {
                    left++;
                } else if (currentSum > target) {
                    right--;
                } else {
                    return currentSum;
                }
            }
        }
        return closestSum;
    }

    static void Main() {
        int[] nums = { -1, 2, 1, -4 };
        int target = 1;
        Solution solution = new Solution();
        int result = solution.ThreeSumClosest(nums, target);
        Console.WriteLine("Closest sum: " + result);
    }
}
