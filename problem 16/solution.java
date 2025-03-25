import java.util.*;

class Solution {
    public List<List<Integer>> fourSum(int[] nums, int target) {
        List<List<Integer>> res = new ArrayList<>();
        List<Integer> total = new ArrayList<>();
        if (nums.length < 4) {
            return res;
        }
        Arrays.sort(nums);
        findSum(res, total, 4, (long) target, 0, nums);
        return res;
    }
    
    private void findSum(List<List<Integer>> res, List<Integer> total, int k, long target, int start, int[] nums) {
        if (k != 2) {
            for (int i = start; i < nums.length - k + 1; i++) {
                if (i > start && nums[i] == nums[i - 1]) {
                    continue;
                }
                total.add(nums[i]);
                findSum(res, total, k - 1, target - nums[i], i + 1, nums);
                total.remove(total.size() - 1);
            }
        } else {
            int left = start;
            int right = nums.length - 1;
            while (left < right) {
                if (((long) nums[left] + (long) nums[right]) == (long) target) {
                    total.add(nums[left]);
                    total.add(nums[right]);
                    res.add(new ArrayList<>(total));
                    total.remove(total.size() - 1);
                    total.remove(total.size() - 1);
                    left++;
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }
                } else if ((long) nums[left] + (long) nums[right] < (long) target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
    }
}
