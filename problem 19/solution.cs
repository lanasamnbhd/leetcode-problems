using System.Collections.Generic;

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        Dfs(0, 0, "", n, res);
        return res;
    }

    private void Dfs(int openP, int closeP, string s, int n, List<string> res) {
        if (openP == closeP && openP + closeP == n * 2) {
            res.Add(s);
            return;
        }

        if (openP < n) {
            Dfs(openP + 1, closeP, s + "(", n, res);
        }

        if (closeP < openP) {
            Dfs(openP, closeP + 1, s + ")", n, res);
        }
    }
}
