#include <stdio.h>
#include <stdlib.h>

int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    // Allocate memory for return array
    *returnSize = 2;
    int* result = (int*)malloc(2 * sizeof(int));
    
    // Iterate through each element
    for (int i = 0; i < numsSize; i++) {
        for (int j = i + 1; j < numsSize; j++) {
            // Check if the sum of nums[i] and nums[j] equals the target
            if (nums[i] + nums[j] == target) {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    
    // If no solution is found, return NULL
    *returnSize = 0;
    return NULL;
}

int main() {
    int numsSize, target;
    
    // Take input for the array size and elements
    printf("Enter the number of elements in the array: ");
    scanf("%d", &numsSize);
    int* nums = (int*)malloc(numsSize * sizeof(int));
    
    printf("Enter the numbers in the array separated by spaces:\n");
    for (int i = 0; i < numsSize; i++) {
        scanf("%d", &nums[i]);
    }
    
    // Take input for the target
    printf("Enter the target number: ");
    scanf("%d", &target);
    
    int returnSize;
    int* result = twoSum(nums, numsSize, target, &returnSize);
    
    // Print result
    if (result != NULL && returnSize == 2) {
        printf("Indices of the two numbers that add up to target: [%d, %d]\n", result[0], result[1]);
        free(result);
    } else {
        printf("No solution found.\n");
    }
    
    // Free allocated memory
    free(nums);
    return 0;
}
