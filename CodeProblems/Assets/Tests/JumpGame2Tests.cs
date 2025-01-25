using NUnit.Framework;


public class JumpGame2Tests
{
    [TestCase("[2,3,1,1,4]", 2)]
    [TestCase("[2,3,0,1,4]", 2)]
    [TestCase("[1]", 0)]
    [TestCase("[0]", 0)]
    [TestCase("[10]", 0)]
    [TestCase("[1,2,3]", 2)]
    [TestCase("[7,0,9,6,9,6,1,7,9,0,1,2,9,0,3]", 2)]
    [TestCase("[2,3,4,5,6,7,8]", 2)]
    [Test]
    public void TestJumpGame2(string inputString, int expectedResult)
    {
        int[] input = InputStringParser.ParseIntArray(inputString);
        int result = JumpGame2Solution.Jump(input);
        Assert.AreEqual(expectedResult, result);
    }
}
