using NUnit.Framework;
using UnityEngine;


public class BestTimeToBuyAndSellStockTests
{
    [TestCase("[7,1,5,3,6,4]", 5)]
    [TestCase("[7,6,4,3,1]", 0)]
    [TestCase("[1,2]", 1)]
    [Test]
    public void TestBestTimeToBuyAndSellStock(string inputString, int expectedResult)
    {
        int[] prices = InputStringParser.ParseIntArray(inputString);
        int result = BestTimeToBuyAndSellStockSolution.MaxProfit(prices);
        Assert.AreEqual(expectedResult, result);
    }
}
