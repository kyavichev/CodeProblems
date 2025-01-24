using NUnit.Framework;


public class RansomNoteTests
{
    [TestCase("a", "b", false)]
    [TestCase("aa", "ab", false)]
    [TestCase("aa", "aab", true)]
    [TestCase("aace", "aabcdeee", true)]
    [Test]
    public void TestRandomNote(string ransomNote, string magazine, bool expectedResult)
    {
        Assert.AreEqual(RansomNoteSolution.CanConstruct(ransomNote, magazine), expectedResult);
    }
}
