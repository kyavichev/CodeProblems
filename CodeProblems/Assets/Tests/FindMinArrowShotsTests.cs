using NUnit.Framework;


public class FindMinArrowShotsTests
{
    [TestCase("[[10,16],[2,8],[1,6],[7,12]]", 2)]
    [TestCase("[[1,2],[3,4],[5,6],[7,8]]", 4)]
    [TestCase("[[1,2],[2,3],[3,4],[4,5]]", 2)]
    [TestCase("[[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]", 2)]
    [TestCase("[[9,12],[1,10],[4,11],[8,12],[3,9],[6,9],[6,7]]", 2)]
    [Test]
    public void TestFindMinArrowShots(string inputString, int expectedResult)
    {
        int[][] points = InputStringParser.ParseArrayOfIntArray(inputString);
        Assert.AreEqual(FindMinArrowShotsSolution.FindMinArrowShots(points), expectedResult);
    }
}
