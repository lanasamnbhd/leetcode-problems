#include <stdio.h>
#include <limits.h>

int reverse(int x) {
    int rev = 0;
    while (x != 0) {
        int digit = x % 10;
        x /= 10;
        
        // Check for overflow before multiplying or adding
        if (rev > INT_MAX / 10 || (rev == INT_MAX / 10 && digit > 7)) return 0;
        if (rev < INT_MIN / 10 || (rev == INT_MIN / 10 && digit < -8)) return 0;

        rev = rev * 10 + digit;
    }
    return rev;
}

int main() {
    int x1 = 123, x2 = -123, x3 = 120;
    printf("Input: %d, Output: %d\n", x1, reverse(x1));
    printf("Input: %d, Output: %d\n", x2, reverse(x2));
    printf("Input: %d, Output: %d\n", x3, reverse(x3));
    return 0;
}
