public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        SortedSet<int> my = new(nums);
        int count = 1;
        int temp = 1;
        int[] arr = my.ToArray();
        int der = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == der + 1)
            {
                temp++;
            }
            else
            {
                if (temp > count)
                {
                    count = temp;
                }
                temp = 1;
            }
            der = arr[i];
        }
        if (temp > count)
        {
            count = temp;
        }
        return count;
    }
}
