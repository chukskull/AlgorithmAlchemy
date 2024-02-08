public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> mydic = new Dictionary<int, int>();

        foreach (var value in nums)
        {
            if (mydic.ContainsKey(value))
            {

                mydic[value]++;
            }
            else
            {
                mydic[value] = 1;
            }
        }
        var sortedDic = mydic.OrderByDescending(pair => pair.Value);
        var top = sortedDic.Take(k);
        int[] result = top.Select(pair => pair.Key).ToArray();
        return result;
    }
}