#include <stack>
#include <unordered_map>
using namespace std;

class Solution {
public:
    bool isValid(string s) {
        stack<char> st; // stack for opening brackets
        unordered_map<char, char> hash = {{')', '('}, {']', '['}, {'}', '{'}};
        
        for (char c : s) {
            if (hash.count(c)) { // if c is a closing bracket
                if (!st.empty() && st.top() == hash[c]) {
                    st.pop(); // pop the matching opening bracket
                } else {
                    return false; // invalid if no match
                }
            } else {
                st.push(c); // push opening brackets
            }
        }
        return st.empty(); // valid if stack is empty
    }
};
