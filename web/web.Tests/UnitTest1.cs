using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using web;
using web.Controllers;
using System.Web.Mvc;

namespace web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            HelloWorldController c = new HelloWorldController();
            var rs = (ViewResult)c.Index();
            Assert.IsTrue(rs != null);
        }
    }
}
