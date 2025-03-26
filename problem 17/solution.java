import java.util.Stack;

class Solution {
    public boolean isValid(String s) {
        // stack to store opening brackets
        Stack<Character> stack = new Stack<>();
        // loop through the characters in the string
        for (char c : s.toCharArray()) {
            // push opening brackets onto the stack
            if (c == '(' || c == '{' || c == '[') {
                stack.push(c);
            } else {
                // if the stack is empty or doesn't match, return false
                if (stack.isEmpty() || 
                   (c == ')' && stack.pop() != '(') || 
                   (c == '}' && stack.pop() != '{') || 
                   (c == ']' && stack.pop() != '[')) {
                    return false;
                }
            }
        }
        // return true if the stack is empty
        return stack.isEmpty();
    }
}
