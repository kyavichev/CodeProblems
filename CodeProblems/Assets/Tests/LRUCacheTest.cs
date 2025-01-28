using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class LRUCacheTest
{
    [TestCase("[LRUCache,put,put,get,put,get,put,get,get,get]", "[[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]", "[null,null,null,1,null,-1,null,-1,3,4]")]
    [TestCase("[LRUCache,put,put,put,get,get,put,get,put,put,get,get,get]", "[[3],[1,1],[2,2],[3,3],[1],[3],[3,3],[2],[4,4],[5,5],[1],[3],[4]]", "[null,null,null,null,1,3,null,2,null,null,-1,-1,4]")]
    [Test]
    public void TestLRUCache(string inputInstructionString, string inputDataString, string expectedResultString)
    {
        string[] instructions = InputStringParser.ParseStringArray(inputInstructionString);

        int[][] dataArray = InputStringParser.ParseArrayOfIntArray(inputDataString);

        int?[] expectedResultArray = InputStringParser.ParseNullableIntArray(expectedResultString);

        LRUCache cache = new LRUCache(dataArray[0][0]);
        for(int i = 1; i < instructions.Length; i++)
        {
            var instruction = instructions[i];
            var inputData = dataArray[i];
            if (instruction == "get")
            {
                var result = cache.Get(inputData[0]);
                var expectedResult = expectedResultArray[i];
                Assert.AreEqual(result, expectedResult);
            }
            else if (instruction == "put")
            {
                cache.Put(inputData[0], inputData[1]);
            }
        }
    }
}
