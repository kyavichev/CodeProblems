/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false

Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false

Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true

 

Constraints:

    1 <= ransomNote.length, magazine.length <= 105
    ransomNote and magazine consist of lowercase English letters.

*/

using System.Collections.Generic;


public static class RansomNoteSolution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> symbols = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            char key = magazine[i];
            if (symbols.ContainsKey(key))
            {
                symbols[key] = symbols[key] + 1;
            }
            else
            {
                symbols[key] = 1;
            }
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            char c = ransomNote[i];
            if (symbols.ContainsKey(c) && symbols[c] > 0)
            {
                symbols[c] = symbols[c] - 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}