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

    public static int[][] ParseArrayOfIntArray(string input)
    {
        List<int[]> result = new List<int[]>();

        if (input[0] == '[' && input[^1] == ']')
        {
            string dataString = input.Substring(2, input.Length - 4);
            string[] arrayStrings = dataString.Split("],[");

            foreach(var arrayString in arrayStrings)
            {
                string[] stringNumbers = arrayString.Split(',');
                List<int> list = new List<int>();
                foreach (string number in stringNumbers)
                {
                    list.Add(int.Parse(number));
                }
                result.Add(list.ToArray());
            }
        }

        return result.ToArray();
    }
}
