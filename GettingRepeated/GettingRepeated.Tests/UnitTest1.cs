using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingRepeated.Tests
{
    [TestClass]
    public class RepTests
    {
        [TestMethod]
        public void Conv_string2and3_numarray2and3returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "2 3";
            int[] expected = { 2, 3 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_string0and00and000_numarray0and0and0returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "0 00 000";
            int[] expected = { 0, 0, 0 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_string2and147and483and647_numarray2and147and483and647returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "2 147 483 647";
            int[] expected = { 2, 147, 483, 647 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_string2147483647_numarray2147483647returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "2147483647";
            int[] expected = { 2147483647 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_stringonethousandof1andminus1_numarrayonethousandof1andminus1returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "";
            int[] expected = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                x += (-1 ^ i).ToString() + " ";
                expected[i] = -1 ^ i;
            }
            x = x.Trim();

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_stringminus2147483648_numarray2147483647returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "-2147483648";
            int[] expected = { -2147483648 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_stringminus1and0_numarrayminus1and0returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            string x = "-1 0";
            int[] expected = { -1, 0 };

            // act
            stopWatch.Start();
            int[] actual = Rep.Conv(x);
            stopWatch.Stop();

            // assert
            CollectionAssert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarrayfrom0to21_stringemptyreturned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            string expected = "";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarrayfrom1and0to21_string1returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            string expected = "1";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_emptynumarray_stringemptyreturned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { };
            string expected = "";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarray3and2_stringemptyreturned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 3, 2 };
            string expected = "";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarray1and11and111and111_string111returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 1, 11, 111, 111 };
            string expected = "111";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarray111and111and111and111_string111returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 111, 111, 111, 111 };
            string expected = "111";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarray0and00and000and0000_string0returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 0, 00, 000, 0000 };
            string expected = "0";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarray01and1and0001and00001_string1returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = { 01, 1, 0001, 00001 };
            string expected = "1";

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_numarrayonethousandof1_string1returned()
        {
            Stopwatch stopWatch = new Stopwatch();

            // arrange
            int[] x = new int[1000];
            string expected = "1";
            for (int i = 0; i < 1000; i++)
            {
                x[i] = 1;
            }

            // act
            stopWatch.Start();
            string actual = Rep.Check(x);
            stopWatch.Stop();

            // assert
            Assert.AreEqual(expected, actual);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_WhenStringContainsNotNumbers_ShouldThrowFormatException()
        {
            Stopwatch stopWatch = new Stopwatch();
            // Arrange
            string x = "a";

            // Act and assert
            stopWatch.Start();
            Assert.ThrowsException<FormatException>(() => Rep.Conv(x));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_WhenStringContainsBigNumber_ShouldThrowFormatException()
        {
            Stopwatch stopWatch = new Stopwatch();
            // Arrange
            string x = "2147483648";

            // Act and assert
            stopWatch.Start();
            Assert.ThrowsException<FormatException>(() => Rep.Conv(x));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        [TestMethod]
        public void Conv_WhenStringContainsRealNumbers_ShouldThrowFormatException()
        {
            Stopwatch stopWatch = new Stopwatch();
            // Arrange
            string x = "1.618";

            // Act and assert
            stopWatch.Start();
            Assert.ThrowsException<FormatException>(() => Rep.Conv(x));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
