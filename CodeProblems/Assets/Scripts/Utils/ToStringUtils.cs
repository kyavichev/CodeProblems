using System;
using System.Text;


public static class ToStringUtils
{
    public static string ArrayToString(int[] ints)
    {
        StringBuilder result = new StringBuilder();
        result.Append("[");
        for(int i = 0; i < ints.Length; i++)
        {
            result.Append($"{ints[i]}");

            if(i != ints.Length - 1)
            {
                result.Append(",");
            }
        }
        result.Append("]");
        return result.ToString();
    }
}
