using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class QuickSortTests
{
    [Test]
    public void TestQuickSort()
    {
        // Quick Sort test
        int[][] ints =
        {
            new int[] { 8, 875, 7, 9, 764, 55 },
            new int[] { 18, 2, 347, 6689, 4, 255, 254, 256, 7, 100, 13 },
            new int[] { 1892, 2000, 3417, 6689, 4200, 6255, 6254, 6256, 7000, 1003, 1399 },
        };

        // Create a duplicate array and sort it using Linq
        List<int[]> sortedList = new List<int[]>();
        for(int i = 0; i < ints.Length; i++)
        {
            var list = new List<int>(ints[i]);
            list.Sort();
            sortedList.Add(list.ToArray());
        }
        sortedList.Sort((int[] a, int[] b) => { return a[0].CompareTo(b[0]); } );
        int[][] sorted = sortedList.ToArray();

        // Sort each individual array
        for (int i = 0; i < ints.Length; i++)
        {
            Debug.Log($"Before: {ToStringUtils.ArrayToString(ints[i])}");
            QuickSort.Sort(ints[i]);
            Debug.Log($"After: {ToStringUtils.ArrayToString(ints[i])}");
        }

        // Sort arrays using the first integer in each array
        QuickSort.Sort(ints, (int[] a, int[] b) => { return a[0].CompareTo(b[0]); });
        for (int i = 0; i < ints.Length; i++)
        {
            Debug.Log($"{i}: {ToStringUtils.ArrayToString(ints[i])}");
        }

        Assert.AreEqual(ints[0][0], 2);
        Assert.AreEqual(ints[0][^1], 6689);

        Assert.AreEqual(ints[1][0], 7);
        Assert.AreEqual(ints[1][^1], 875);

        Assert.AreEqual(ints[2][0], 1003);
        Assert.AreEqual(ints[2][^1], 7000);

        Assert.AreEqual(ints[0][0], sorted[0][0]);
        Assert.AreEqual(ints[0], sorted[0]);
        Assert.AreEqual(ints, sorted);
    }
}
