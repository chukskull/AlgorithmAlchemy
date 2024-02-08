public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mydisc = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (mydisc.ContainsKey(target - nums[i]))
            {
                int[] retu = [mydisc[target - nums[i]], i];
                return retu;
            }
            else
            {
                mydisc[nums[i]] = i;
            }
        }
        return [];

    }
}