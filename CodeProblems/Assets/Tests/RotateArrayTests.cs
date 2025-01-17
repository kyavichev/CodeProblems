using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class RotateArrayTests
{
    public class TestData
    {
        public int[] nums;
        public int k;
        public int[] result;

        public TestData(int[] newNums, int newK, int[] newResult)
        {
            nums = newNums;
            k = newK;
            result = newResult;
        }
    }

    [Test]
    public void TestRotateArray()
    {
        List<TestData> inputData = new List<TestData>()
        {
            new TestData(new int[]{1,2,3,4,5,6,7}, 3, new int[]{5,6,7,1,2,3,4}),
            new TestData(new int[]{-1,-100,3,99}, 2, new int[]{3,99,-1,-100}),
        };

        foreach (var test in inputData)
        {
            RotateArraySolution.Rotate(test.nums, test.k);
            Assert.AreEqual(test.nums, test.result);
        }
    }
}
