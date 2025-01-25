using NUnit.Framework;
using UnityEngine;


public class RemoveExtraDuplicatesTests
{
    [TestCase("[1,1,1,2,2,3]", "[1,1,2,2,3]")]
    [TestCase("[0,0,1,1,1,1,2,3,3]", "[0,0,1,1,2,3,3]")]
    [TestCase("[1,1,1]", "[1,1]")]
    [TestCase("[1,1,1,1]", "[1,1]")]
    [Test]
    public void TestRemoveExtraDuplicates(string numsString, string expectedResultString)
    {
        int[] nums = InputStringParser.ParseIntArray(numsString);
        int newLength = RemoveExtraDuplicatesSolution.RemoveDuplicates(nums);
        int[] expectedResult = InputStringParser.ParseIntArray(expectedResultString);

        for (int i = 0; i < newLength; i++)
        {
            Assert.AreEqual(nums[i], expectedResult[i]);
        }
    }
}
