using NUnit.Framework;


public class RotateArrayTests
{
    [TestCase("[1,2,3,4,5,6,7]", 3, "[5,6,7,1,2,3,4]")]
    [TestCase("[-1,-100,3,99]", 2, "[3,99,-1,-100]")]
    [Test]
    public void TestRotateArray(string numsString, int k, string expectedResultString)
    {
        int[] nums = InputStringParser.ParseIntArray(numsString);
        RotateArraySolution.Rotate(nums, k);
        int[] expectedResult = InputStringParser.ParseIntArray(expectedResultString);
        Assert.AreEqual(nums, expectedResult);
    }
}
