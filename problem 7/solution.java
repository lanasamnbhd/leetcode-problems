class Solution {
    private void reverse(char[] s, int i, int j) {
        while (i < j) {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }

    public int reverse(int x) {
        String val = Integer.toString(x);
        char[] arr = val.toCharArray();
        
        int i = 0, j = arr.length - 1;
        if (arr[0] == '-') i = 1; // Skip '-' sign

        reverse(arr, i, j);
        long y = Long.parseLong(new String(arr)); 
        
        if (y > Integer.MAX_VALUE || y < Integer.MIN_VALUE) return 0;
        return (int) y;
    }

    public static void main(String[] args) {
        Solution sol = new Solution();
        System.out.println(sol.reverse(-123)); // Output: -321
    }
}
