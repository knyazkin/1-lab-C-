using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibLab1;



namespace Lab1Tests
{
    [TestClass]
    public class Lab1ProgramTest
    {
        [TestMethod]
        public void Test_CorrectCompleteProgram_1()
        {
            // Arrange
            string beginningString = "abc";
            string expectedString = "a1b1c1";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }

        [TestMethod]
        public void Test_CorrectCompleteProgram_2()
        {
            // Arrange
            string beginningString = "a1b1c1";
            string expectedString = "a111b111c111";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }

        [TestMethod]
        public void Test_CorrectCompleteProgram_3()
        {
            // Arrange
            string beginningString = "aaabbbbccc";
            string expectedString = "a3b4c3";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }

        [TestMethod]
        public void Test_CorrectCompleteProgram_4()
        {
            // Arrange
            string beginningString = "abbccc";
            string expectedString = "a1b2c3";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }

        [TestMethod]
        public void Test_CorrectCompleteProgram_5()
        {
            // Arrange
            string beginningString = "abbbbbc";
            string expectedString = "a1b5c1";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectCompleteProgram_6()
        {
            // Arrange
            string beginningString = "a,b,c";
            string expectedString = "a1,1b1,1c1";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectCompleteProgram_7()
        {
            // Arrange
            string beginningString = "a-b--c";
            string expectedString = "a1-1b1-2c1";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectCompleteProgram_8()
        {
            // Arrange
            string beginningString = "";
            string expectedString = "Function not compled!";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectCompleteProgram_9()
        {
            // Arrange
            string beginningString = "aaaaaaaaaa";
            string expectedString = "a10";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectCompleteProgram_10()
        {
            // Arrange
            string beginningString = "correct";
            string expectedString = "c1o1r2e1c1t1";

            // Act
            string actualString = Lab1.EditString(beginningString);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectInput_11()
        {
            // Arrange
            string path = @"E:\TestLogs";
            string fileName = "input.txt";
            string beginningString = null;
            string expectedString = "abbccc";

            // Act
            string actualString = Lab1.input(path, fileName);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CorrectOutput_12()
        {
            // Arrange
            string path = @"E:\TestLogs";
            string fileName = "output.txt";
            string beginningString = "a1b2c3";
            string expectedString = "a1b2c3";

            // Act
            Lab1.output(path,fileName, beginningString);
            string actualString = Lab1.input(path,fileName);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_ErrorEmptyFileInput_13()
        {
            // Arrange
            string path = @"E:\TestLog";
            string beginningString = "input.txt";
            string expectedString = null;

            // Act
            string actualString = Lab1.input(path, beginningString);

            // Assert
            Assert.IsNull(actualString);
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_EmptyFileOutput_14()
        {
            // Arrange

            string path = @"E:\TestLogs";
            string fileName = "output.txt";
            string beginningString = null;
            string expectedString = "";

            // Act
            Lab1.output(path, fileName, beginningString);
            string actualString = Lab1.input(path, fileName);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
        [TestMethod]
        public void Test_CreateNewFileOutput_15()
        {
            // Arrange

            string path = @"E:\TestLogs";
            string fileName = "outputnew.txt";
            string beginningString = "new file";
            string expectedString = "new file";

            // Act
            Lab1.output(path, fileName, beginningString);
            string actualString = Lab1.input(path, fileName);

            // Assert
            Assert.AreEqual(expectedString, actualString, "Edit of {0} should have been {1}, it turned out {2}!", beginningString, expectedString, actualString);
        }
    }
}
