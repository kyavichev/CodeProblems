using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputStringParser
{
    public static int[] ParseIntArray(string input)
    {
        List<int> array = new List<int>();

        if(input[0] == '[' && input[^1] == ']')
        {
            string data = input.Substring(1, input.Length - 2);
            string[] stringNumbers = data.Split(',');

            foreach(string number in stringNumbers)
            {
                array.Add(int.Parse(number));
            }
        }

        return array.ToArray();
    }
}
