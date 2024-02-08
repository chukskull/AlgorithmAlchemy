public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int res = 1;
        int[] arr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            res *= nums[i];
            arr[i] = res;
        }
        res = 1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1] * res;
            res *= nums[i];
        }
        arr[0] = res;
        return arr;
    }
}