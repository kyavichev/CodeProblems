
using NUnit.Framework;


public class MergeTwoSortedListsTests
{
    [TestCase("[1,2,4]", "[1,3,4]", "[1,1,2,3,4,4]")]
    [TestCase("[]", "[]", "[]")]
    [TestCase("[]", "[0]", "[0]")]
    [Test]
    public void TestMergeTwoSortedLists(string inputList1String, string inputList2String, string expectedResult)
    {
        int[] list1Array = InputStringParser.ParseIntArray(inputList1String);
        ListNode list1 = LinkedListUtils.ToIntListNode(list1Array);

        int[] list2Array = InputStringParser.ParseIntArray(inputList2String);
        ListNode list2 = LinkedListUtils.ToIntListNode(list2Array);

        ListNode result = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

        int[] expectedResultArray = InputStringParser.ParseIntArray(expectedResult);
        for(int i = 0; i < expectedResultArray.Length; i++)
        {
            Assert.AreEqual(result.val, expectedResultArray[i]);
            result = result.next;
        }
    }
}
