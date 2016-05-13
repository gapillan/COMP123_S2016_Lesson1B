using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 // has access to the main namespace 

namespace Lesson1TestProject
{
    /**
     * 
     * This Class is used to test the Lesson 1 Project
     * Used for development only. 
     * 
     * @class Lesson1UnitTest
     */

    [TestClass]
    public class Lesson1UnitTest
    {
        /**
         * Unit Test for OutputStringToConsole Method of the Program Class 
         * 
         * @method OutputStringToConsoleTestMethod 
         * 
         */

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
