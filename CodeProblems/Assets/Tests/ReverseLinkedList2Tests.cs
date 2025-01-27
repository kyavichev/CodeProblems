using NUnit.Framework;
using UnityEngine;


public class ReverseLinkedList2Tests
{
    [TestCase("[1,2,3,4,5]", 2, 4, "[1,4,3,2,5]")]
    [TestCase("[5]", 1, 1, "[5]")]
    [TestCase("[3,5]", 1, 2, "[5,3]")]
    [TestCase("[3,5,7,9]", 1, 4, "[9,7,5,3]")]

    [Test]
    public void TestReverseBetween(string inputListString, int left, int right, string expectedResult)
    {
        int[] listArray = InputStringParser.ParseIntArray(inputListString);
        ListNode head = LinkedListUtils.ToIntListNode(listArray);

        ListNode result = ReverseLinkedList2Solution.ReverseBetween(head, left, right);

        int[] expectedResultArray = InputStringParser.ParseIntArray(expectedResult);
        for (int i = 0; i < expectedResultArray.Length; i++)
        {
            Assert.AreEqual(result.val, expectedResultArray[i]);
            result = result.next;
        }
    }
}
