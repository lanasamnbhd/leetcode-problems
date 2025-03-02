#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

int compare(const void *a, const void *b) {
    return (*(int*)a - *(int*)b);
}

int threeSumClosest(int* nums, int numsSize, int target) {
    qsort(nums, numsSize, sizeof(int), compare);
    int closest_sum = INT_MAX / 2; // Aşırı taşmayı önlemek için büyük bir değer

    for (int i = 0; i < numsSize - 2; ++i) {
        int left = i + 1, right = numsSize - 1;
        while (left < right) {
            int current_sum = nums[i] + nums[left] + nums[right];
            if (abs(current_sum - target) < abs(closest_sum - target)) {
                closest_sum = current_sum;
            }
            if (current_sum < target) {
                ++left;
            } else if (current_sum > target) {
                --right;
            } else {
                return current_sum;
            }
        }
    }
    return closest_sum;
}

int main() {
    int nums[] = {-1, 2, 1, -4};
    int target = 1;
    int numsSize = sizeof(nums) / sizeof(nums[0]);
    int result = threeSumClosest(nums, numsSize, target);
    printf("Closest sum: %d\n", result);
    return 0;
}
