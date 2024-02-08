//to simplify i used one dimensional array to store the matrix so its (Row * RowIndex)* Colomn + ColumnIndex

class Solution {
public:
    int longestCommonSubsequence(string text1, string text2) {
        int R = text1.size();
        int C = text2.size();
        vector<int> matrix((R + 1) * (C+ 1), 0);
        for (int i = R - 1; i >= 0; i--) {
            for (int k = C- 1; k >= 0; k--) {
                int max = std::max(matrix[(i + 1) * (C+ 1) + k],
                                   matrix[i * (C+ 1) + (k + 1)]);
                if (text1[i] == text2[k]) {
                    max = matrix[(i + 1) * (C+ 1) + (k + 1)] + 1;
                }
                matrix[i * (C+ 1) + k] = max;
            }
        }
        return matrix[0];
    }
};