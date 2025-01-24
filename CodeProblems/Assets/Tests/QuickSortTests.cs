using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class QuickSortTests
{
    [TestCase("[8,875,7,9,764,55]")]
    [TestCase("[18,2,347,6689,4,255,254,256,7,100,13]")]
    [TestCase("[1892,2000,3417,6689,4200,6255,6254,6256,7000,1003,1399]")]
    [Test]
    public void TestQuickSort(string inputString)
    {
        var nums = InputStringParser.ParseIntArray(inputString);

        var sortedNumsList = new List<int>(nums);
        sortedNumsList.Sort();
        var sortedNums = sortedNumsList.ToArray();

        QuickSort.Sort(nums);

        Assert.AreEqual(nums[0], sortedNums[0]);
        Assert.AreEqual(nums, sortedNums);
    }


    [Test]
    public void TestQuickSortRandom()
    {
        // Generate new data
        int size = UnityEngine.Random.Range(5, 10);
        List<int[]> intsList = new List<int[]>();
        for (int i = 0; i < size; i++ )
        {
            var intList = new List<int>();
            int listSize = UnityEngine.Random.Range(10, 20);
            for(int j = 0; j < listSize; j++)
            {
                intList.Add(UnityEngine.Random.Range(0, 10000));
            }
            intsList.Add(intList.ToArray());
        }
        int[][] ints = intsList.ToArray();

        // Create a duplicate array and sort it using Linq
        List<int[]> sortedList = new List<int[]>();
        for (int i = 0; i < ints.Length; i++)
        {
            var list = new List<int>(ints[i]);
            list.Sort();
            sortedList.Add(list.ToArray());
        }
        sortedList.Sort((int[] a, int[] b) => { return a[0].CompareTo(b[0]); });
        int[][] sorted = sortedList.ToArray();

        // Sort each individual array
        for (int i = 0; i < ints.Length; i++)
        {
            QuickSort.Sort(ints[i]);
        }

        // Sort arrays using the first integer in each array
        QuickSort.Sort(ints, (int[] a, int[] b) => { return a[0].CompareTo(b[0]); });

        Assert.AreEqual(ints[0][0], sorted[0][0]);
        Assert.AreEqual(ints[0], sorted[0]);
        Assert.AreEqual(ints, sorted);
    }
}
