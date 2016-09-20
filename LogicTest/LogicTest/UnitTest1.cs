using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTest
{
    [TestClass]
    public class StreamLogicTest
    {
        [TestMethod]
        public void GetMessageTest()
        {
            // Arrange
            StreamLogic messageLogic = new StreamLogic();
            string message;
            string expected = "Hello You!!!";

            // Act
            message = messageLogic.getMessage();

            // Assert
            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void GetMessageTest2()
        {
            // Arrange
            StreamLogic messageLogic = new StreamLogic();
            string message;
            string expected = "Hello You!!!";

            // Act
            message = messageLogic.getMessage();

            // Assert
            Assert.AreEqual(expected, message);
        }
    }
}
