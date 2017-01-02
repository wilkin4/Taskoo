using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskoo.Controllers;

namespace Taskoo.Tests.Controllers
{
    [TestClass]
    public class MainControllerTest
    {
        [TestMethod]
        public void FindPriorityIconName_MustReturnPriorityIconName()
        {
            // Arrange
            MainController controller1 = new MainController();
            MainController controller2 = new MainController();
            MainController controller3 = new MainController();

            // Act
            string result1 = controller1.findPriorityIconName('r');
            string result2 = controller2.findPriorityIconName('g');
            string result3 = controller3.findPriorityIconName('y');

            // Assert
            Assert.AreEqual("red-triangle", result1);
            Assert.AreEqual("green-triangle", result2);
            Assert.AreEqual("yellow-triangle", result3);
        }

        [TestMethod]
        public void FindIsFinishedIconName_MustReturnIsFinishedIconName()
        {
            // Arrange
            MainController controller1 = new MainController();
            MainController controller2 = new MainController();

            // Act
            string result1 = controller1.findIsFinishedIconName(true);
            string result2 = controller2.findIsFinishedIconName(false);

            // Assert
            Assert.AreEqual("task-highlighted-icon", result1);
            Assert.AreEqual("", result2); 
        }
    }
}
