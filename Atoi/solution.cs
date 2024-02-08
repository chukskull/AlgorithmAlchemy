
public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (String.IsNullOrEmpty(s))
        {
            return 0;
        }
        int index = 0;
        bool isNegative;
        if (s[0].CompareTo('-') == 0)
        {
            if (s.Length == 1)
                return 0;
            index = 1;
            isNegative = true;
        }
        else if (s[0].CompareTo('+') == 0)
        {
            if (s.Length == 1)
                return 0;
            index = 1;
            isNegative = false;
        }
        else
        {
            isNegative = false;
        }
        long result = 0;
        if (!Char.IsDigit(s[index]))
            return 0;
        for (; index < s.Length; index++)
        {
            if (Char.IsDigit(s[index]))
            {
                result = result * 10 + Convert.ToInt32(s[index].ToString());
                if (result > int.MaxValue)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }
            }
            else
            {
                break;
            }
        }
        return isNegative ? (int)-result : (int)result;

    }
}