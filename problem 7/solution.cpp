class Solution {
    void reverse(string& s, int i, int j){
        while(i<j){
            swap(s[i], s[j]);
            i++;
            j--;
        }
    }
public:
    int reverse(int x) {
        string val = to_string(x);
        int i=0, j=val.length()-1;
        if(val.length()==0) return x;
        if(val[0]=='-') i=1;
        reverse(val, i, j);
        long long int y = stoll(val);
        if(y>INT_MAX || y<INT_MIN) return 0;
        return y;
    }
};
