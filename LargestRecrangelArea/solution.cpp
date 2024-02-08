class Solution {
public:
    int largestRectangleArea(vector<int>& heights) {
        stack<int> stack;
        int count = 0;
        int my_top;
        int i = 0;
        for (; i < heights.size();) {
            if (stack.empty() || heights[i] >= heights[stack.top()]) {
                stack.push(i);
                i++;
            }
            else {
                my_top = stack.top();
                stack.pop();
                int rec = (stack.empty() ? i : i - stack.top() - 1) * heights[my_top];
                // cout <<" doomed " << i << ' ' << (stack.empty() ? i : i - stack.top() - 1) << " " << heights[my_top] <<" " <<rec << ' ' << heights[i] << endl;
                if (count < rec)
                    count = rec;
            }
        }
        
        while(stack.size() > 0) {
            my_top = stack.top();
            stack.pop();
            int rec = (stack.empty() ? i : i - stack.top() - 1) * heights[my_top];
            if (rec > count) {
                count = rec;
            }
        }
        return count;
    }
};