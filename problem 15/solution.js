class Solution {
    solve(index, digits, comb, ans, temp) {
        if (index === digits.length) {
            ans.push(temp);
            return;
        }

        for (let ch of comb[digits[index]]) {
            this.solve(index + 1, digits, comb, ans, temp + ch);
        }
    }

    letterCombinations(digits) {
        if (digits.length === 0) return [];
        const comb = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        let ans = [];
        this.solve(0, digits, comb, ans, "");
        return ans;
    }
}

const solution = new Solution();
console.log(solution.letterCombinations("23"));
