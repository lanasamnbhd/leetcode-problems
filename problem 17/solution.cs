using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(); // stack for opening brackets
        
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c); // push opening bracket
            } else {
                // check if stack is empty or doesn't match
                if (stack.Count == 0 || 
                   (c == ')' && stack.Pop() != '(') || 
                   (c == '}' && stack.Pop() != '{') || 
                   (c == ']' && stack.Pop() != '[')) {
                    return false;
                }
            }
        }
        return stack.Count == 0; // valid if stack is empty
    }
}
