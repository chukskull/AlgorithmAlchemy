class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_map<char, int> table;
        int length = 0;
        int l = 0;
        for(int r = 0; r < s.size(); r++) {
            if (table.find(s[r]) != table.end()&& l <= table[s[r]]) {
                l = table[s[r]] + 1;
            }
            else
            {
                int count = (r - l) + 1;
                if (count > length)
                    length = count; 
            }
            table[s[r]] = r;
        }
        return length;
    }
};