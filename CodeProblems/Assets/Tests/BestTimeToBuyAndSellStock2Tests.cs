using NUnit.Framework;
using UnityEngine;


public class BestTimeToBuyAndSellStock2Tests
{
    [TestCase("[7,1,5,3,6,4]", 7)]
    [TestCase("[1,2,3,4,5]", 4)]
    [TestCase("[7,6,4,3,1]", 0)]
    [Test]
    public void TestBestTimeToBuyAndSellStock2(string inputString, int expectedResult)
    {
        int[] prices = InputStringParser.ParseIntArray(inputString);
        int result = BestTimeToBuyAndSellStock2Solution.MaxProfit(prices);
        Assert.AreEqual(expectedResult, result);
    }
}
