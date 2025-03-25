public class Solution 
{

    public Dictionary<char, List<char>> map = new Dictionary<char, List<char>>()
    {
        {'2', new List<char>(){ 'a', 'b', 'c'}},
        {'3', new List<char>(){ 'd', 'e', 'f'}},
        {'4', new List<char>(){ 'g', 'h', 'i'}},
        {'5', new List<char>(){ 'j', 'k', 'l'}},
        {'6', new List<char>(){ 'm', 'n', 'o'}},
        {'7', new List<char>(){ 'p', 'q', 'r', 's'}},
        {'8', new List<char>(){ 't', 'u', 'v'}},
        {'9', new List<char>(){ 'w', 'x', 'y', 'z'}}       
    };

    public List<string> output = new List<string>(){};


    public IList<string> LetterCombinations(string digits) 
    {

        if(String.IsNullOrEmpty(digits)){ return output; }

        dfs(digits, 0, "");

        return output;
    }

    public void dfs(string digits, int index, string word)
    {

        if(index == digits.Length)
        {
            output.Add(word);
            return;
        }


        foreach(char c in map[digits[index]])
        {
            dfs(digits, index + 1, word + c);
        }
    }
}
