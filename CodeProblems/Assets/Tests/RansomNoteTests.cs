using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class RansomNoteTests
{
    public class TestData
    {
        public string ransomNote;
        public string magazine;
        public bool isPossible;

        public TestData(string aRansomNote, string aMagazine, bool aIsPossible)
        {
            ransomNote = aRansomNote;
            magazine = aMagazine;
            isPossible = aIsPossible;
        }
    }


    [Test]
    public void TestRandomNote()
    {
        List<TestData> inputData = new List<TestData>()
        {
            new TestData("a", "b", false),
            new TestData("aa", "ab", false),
            new TestData("aa", "aab", true),
            new TestData("aace", "aabcdeee", true),
        };

        foreach(var test in inputData)
        {
            Assert.AreEqual(RansomNoteSolution.CanConstruct(test.ransomNote, test.magazine), test.isPossible);
        }
    }
}
