using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.Models;

namespace web.Tests
{
    [TestClass]
    public class CodeFirstModelTest
    {
        [TestMethod]
        public void CheckTVChannelProperties()
        {
            TVChannel t = new TVChannel();
            Assert.IsTrue(t.Title == null);
        }

        [TestMethod]
        public void CheckTVSeriesProperties()
        {
            TVSeries t = new TVSeries();
            Assert.IsTrue(t.Name == null);
        }
    }
}
