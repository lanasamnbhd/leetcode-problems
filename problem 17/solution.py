class Solution:
    def isValid(self, s: str) -> bool:
        # initialize an empty stack and a hash map for matching brackets
        stack = []
        hash = {')': '(', ']': '[', '}': '{'}
        
        # loop through each character in the string
        for char in s:
            if char in hash:
                # if it's a closing bracket, check the stack
                if stack and stack[-1] == hash[char]:
                    stack.pop()  # remove the matching opening bracket
                else:
                    return False  # invalid if no match
            else:
                # push opening brackets onto the stack
                stack.append(char)
        
        # return True if stack is empty, False otherwise
        return not stack
