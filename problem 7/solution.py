class Solution:
    def reverse_string(self, s, i, j):
        while i < j:
            s[i], s[j] = s[j], s[i]
            i += 1
            j -= 1

    def reverse(self, x: int) -> int:
        val = list(str(x))
        i, j = (1 if val[0] == '-' else 0), len(val) - 1

        self.reverse_string(val, i, j)
        y = int("".join(val))
        
        if y > (2**31 - 1) or y < -2**31:
            return 0
        return y

# Testing
sol = Solution()
print(sol.reverse(-123)) # Output: -321
