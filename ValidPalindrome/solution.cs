public class Solution
{
    public bool IsPalindrome(string s)
    {


        char[] arr = s.Where(c => char.IsLetterOrDigit(c)).ToArray();
        s = new string(arr).ToLower();
        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if (s[left] != s[right])
            {
                Console.WriteLine($"{s[left]} {s[right]}");
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}