var isValid = function(s) {
    const stack = []; // stack for opening brackets
    const hash = { ')': '(', ']': '[', '}': '{' }; // matching pairs
    
    for (const char of s) {
        if (char in hash) {
            // check if stack is non-empty and matches the top element
            if (stack.length && stack[stack.length - 1] === hash[char]) {
                stack.pop(); // remove the matching opening bracket
            } else {
                return false; // invalid if no match
            }
        } else {
            stack.push(char); // push opening bracket
        }
    }
    return stack.length === 0; // valid if stack is empty
};
