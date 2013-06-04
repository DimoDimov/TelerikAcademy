namespace _04.Longest_Subsequence_UnitTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Longest_Subsequence_Of_Equal_Numbers;

    [TestClass]
    public class SubsequenceUnitTests
    {
        [TestMethod]
        public void TestBorderCase1()
        {
            List<int> unsortedList = new List<int>() 
            { 
            3, 4, 5, 6,
            7, 7, 7, 8,
            9, 9, 9, 9
            };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 9, 9, 9, 9};
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);    
            }
        }

        public void TestBorderCase2()
        {
            List<int> unsortedList = new List<int>() 
            { 
            9, 9, 9, 9,
            3, 4, 5, 6,
            7, 7, 7, 8
            };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 9, 9, 9, 9 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void TestNormalCase()
        {
            List<int> unsortedList = new List<int>() 
            { 
            3, 4, 5, 6,
            9, 9, 9, 9,
            7, 7, 7, 8
            };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 9, 9, 9, 9 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void TestOneValueMatrix()
        {
            List<int> unsortedList = new List<int>() 
            { 
            3
            };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 3 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void TestNoneValueMatrix()
        {
            List<int> unsortedList = new List<int>() 
            { 
            };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void TestTwoValueMatrix()
        {
            List<int> unsortedList = new List<int>()
            {2, 3};

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 3 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void TestTwoEqualValueMatrix()
        {
            List<int> unsortedList = new List<int>() { 3, 3, };

            var actual = LongestSubsequence.GetLongestEqualSubseq(unsortedList);
            var expected = new List<int>() { 3, 3 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
