using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 // has access to the main namespace 

namespace Lesson1TestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            // Arrange 
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = " Enter UserName: ";

            // Act 
            actualResult = COMP123_S2016_Lesson1B.Program.OutputStringToConsole(outputString, hasNewLine); 

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
