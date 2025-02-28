
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";

        string pref = strs[0];
        int prefLen = pref.Length;

        for (int i = 1; i < strs.Length; i++) {
            string s = strs[i];
            while (prefLen > s.Length || pref != s.Substring(0, prefLen)) {
                prefLen--;
                if (prefLen == 0) {
                    return "";
                }
                pref = pref.Substring(0, prefLen);
            }
        }

        return pref;
    }
}
