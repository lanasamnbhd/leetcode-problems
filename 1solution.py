def two_sum(nums, target):
    # Create a dictionary to store the index of each number
    num_dict = {}

    for i, num in enumerate(nums):
        # Calculate the complement that would sum to the target
        complement = target - num

        # If the complement is in the dictionary, return the indices
        if complement in num_dict:
            return [num_dict[complement], i]

        # Otherwise, store the index of the current number
        num_dict[num] = i


# Get input from the user
nums = list(map(int, input("Enter the numbers in the array separated by spaces: ").split()))
target = int(input("Enter the target number: "))

# Find the indices
result = two_sum(nums, target)

# Display the result
print("Indices of the two numbers that add up to target:", result)
