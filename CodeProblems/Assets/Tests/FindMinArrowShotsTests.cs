using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class FindMinArrowShotsTests
{
    public class TestData
    {
        public int[][] points;
        public int result;

        public TestData(int[][] points, int result)
        {
            this.points = points;
            this.result = result;
        }
    }

    [Test]
    public void TestFindMinArrowShots()
    {
        List<TestData> inputData = new List<TestData>()
        {
            // [[10,16],[2,8],[1,6],[7,12]]
            new TestData(new int[][]{ new int[] {10,16}, new int[] {2,8}, new int[] {1,6}, new int[] {7,12} }, 2),
            // [[1,2],[3,4],[5,6],[7,8]]
            new TestData(new int[][]{ new int[] {1,2}, new int[] {3,4}, new int[] {5,6}, new int[] {7,8} }, 4),
            // [[1,2],[2,3],[3,4],[4,5]]
            new TestData(new int[][]{ new int[] {1,2}, new int[] {2,3}, new int[] {3,4}, new int[] {4,5} }, 2),
        };

        foreach (var test in inputData)
        {
            Assert.AreEqual(FindMinArrowShotsSolution.FindMinArrowShots(test.points), test.result);
        }
    }
}
