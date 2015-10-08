using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using HelloWorldWebAPI;
using HelloWorldWebAPI.Controllers;


namespace HelloWorldWebAPI.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Index()
        {
                    //Arrange
                    HelloWorldController controller = new HelloWorldController();

                    // Act
                    string result = controller.Get();

                    //Assert
                    Assert.IsNotNull(result);
                    Assert.AreEqual("Hello World",result);

         }

        
    }
}

