using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.DAL;
using web.Models;
using web.Controllers;
using System.Web.Mvc;

namespace web.Tests
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void TVSeriesIndex()
        {
            TVSeriesController c = new TVSeriesController();
            var rs = (ViewResult)c.Index();
            Assert.IsNotNull(rs);
        }
    }
}
