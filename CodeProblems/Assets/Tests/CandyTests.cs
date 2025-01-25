using NUnit.Framework;
using UnityEngine;


public class CandyTests
{
    [TestCase("[1,0,2]", 5)]
    [TestCase("[1,2,2]", 4)]
    [TestCase("[1,2,87,87,87,2,1]", 13)]
    [TestCase("[29,51,87,87,72,12]", 12)]
    [Test]
    public void TestCandy(string inputString, int expectedResult)
    {
        int[] ratings = InputStringParser.ParseIntArray(inputString);
        int result = CandySolution.Candy(ratings);
        Assert.AreEqual(expectedResult, result);
    }
}
