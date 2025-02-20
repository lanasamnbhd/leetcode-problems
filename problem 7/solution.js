class Solution {
    reverseString(s, i, j) {
        while (i < j) {
            [s[i], s[j]] = [s[j], s[i]];
            i++;
            j--;
        }
    }

    reverse(x) {
        let val = x.toString();
        let arr = val.split('');

        let i = 0, j = arr.length - 1;
        if (arr[0] === '-') i = 1; // Skip '-'

        this.reverseString(arr, i, j);
        let y = parseInt(arr.join(''), 10);
        
        if (y > 2**31 - 1 || y < -(2**31)) return 0;
        return y;
    }
}

let sol = new Solution();
console.log(sol.reverse(-123)); // Output: -321
