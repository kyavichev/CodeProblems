using NUnit.Framework;


public class JumpGameTests
{
    [TestCase("[1,2,3]", true)]
    [TestCase("[2,3,1,1,4]", true)]
    [TestCase("[3,2,1,0,4]", false)]
    [Test]
    public void TestJumpGame(string inputString, bool expectedResult)
    {
        int[] input = InputStringParser.ParseIntArray(inputString);
        bool result = JumpGameSolution.CanJump(input);
        Assert.AreEqual(expectedResult, result);
    }
}
