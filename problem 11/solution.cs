using System;

public class Solution {
    private static int CharToNum(char a) {
        switch (a) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    public int RomanToInt(string s) {
        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            if (i + 1 < s.Length && CharToNum(s[i]) < CharToNum(s[i + 1])) {
                result -= CharToNum(s[i]);
            } else {
                result += CharToNum(s[i]);
            }
        }
        return result;
    }
}

//example
class Program {
    static void Main() {
        Solution sol = new Solution();
        Console.WriteLine(sol.RomanToInt("IX"));   
        Console.WriteLine(sol.RomanToInt("LVIII"));
        Console.WriteLine(sol.RomanToInt("MCMXCIV")); 
    }
}
