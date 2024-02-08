class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> MyMap;

        for(int i =0; i < nums.size(); i++) {
            if(MyMap.find(target - nums[i]) != MyMap.end())
                return {MyMap[target - nums[i]], i};

            MyMap[nums[i]] = i;
        }
        return {};
    }
};