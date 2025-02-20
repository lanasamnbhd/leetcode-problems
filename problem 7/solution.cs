using System;

class Program {
    static int Reverse(int x) {
        int rev = 0;
        while (x != 0) {
            int digit = x % 10;
            x /= 10;
            
            // Check for overflow before multiplying or adding
            if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && digit > 7)) return 0;
            if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && digit < -8)) return 0;

            rev = rev * 10 + digit;
        }
        return rev;
    }

    static void Main() {
        Console.WriteLine($"Input: 123, Output: {Reverse(123)}");
        Console.WriteLine($"Input: -123, Output: {Reverse(-123)}");
        Console.WriteLine($"Input: 120, Output: {Reverse(120)}");
    }
}
