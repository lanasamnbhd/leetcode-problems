import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class TwoSumSolution {

    public static int[] twoSum(int[] nums, int target) {
        // Create a HashMap to store the number and its index
        Map<Integer, Integer> numMap = new HashMap<>();
        
        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            
            // Check if the complement is already in the map
            if (numMap.containsKey(complement)) {
                return new int[] { numMap.get(complement), i };
            }
            
            // If not, add the current number and its index to the map
            numMap.put(nums[i], i);
        }
        
        // If no solution is found, return an empty array
        return new int[0];
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        // Take input for the array
        System.out.println("Enter numbers in the array separated by spaces:");
        String[] input = scanner.nextLine().split(" ");
        int[] nums = new int[input.length];
        
        for (int i = 0; i < input.length; i++) {
            nums[i] = Integer.parseInt(input[i]);
        }
        
        // Take input for the target
        System.out.println("Enter the target number:");
        int target = scanner.nextInt();
        
        // Find the indices
        int[] result = twoSum(nums, target);
        
        if (result.length > 0) {
            System.out.println("Indices of the two numbers that add up to the target: [" + result[0] + ", " + result[1] + "]");
        } else {
            System.out.println("No solution found.");
        }
        
        scanner.close();
    }
}
