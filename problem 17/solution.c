#include <stdbool.h>
#include <string.h>
#include <stdlib.h>

bool isValid(char * s) {
    char stack[strlen(s)];
    int top = -1;
    
    for (int i = 0; s[i] != '\0'; i++) {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[') {
            stack[++top] = s[i]; // push opening bracket
        } else {
            if (top == -1 || 
               (s[i] == ')' && stack[top] != '(') || 
               (s[i] == '}' && stack[top] != '{') || 
               (s[i] == ']' && stack[top] != '[')) {
                return false; // invalid if no match
            }
            top--; // pop the matching opening bracket
        }
    }
    return top == -1; // valid if stack is empty
}
