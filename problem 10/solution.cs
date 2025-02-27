using System;
using System.Collections.Generic;

public class Solution {
    public string IntToRoman(int num) {
        List<(int, string)> valueSymbols = new List<(int, string)> {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"), (100, "C"),
            (90, "XC"), (50, "L"), (40, "XL"), (10, "X"), (9, "IX"),
            (5, "V"), (4, "IV"), (1, "I")
        };

        string res = "";

        foreach (var (value, symbol) in valueSymbols) {
            if (num == 0)
                break;

            while (num >= value) {
                res += symbol;
                num -= value;
            }
        }

        return res;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        Console.WriteLine(solution.IntToRoman(1994)); // "MCMXCIV"
    }
}
