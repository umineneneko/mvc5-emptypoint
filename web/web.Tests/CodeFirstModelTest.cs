using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.DAL;
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

        [TestMethod]
        public void Seeding()
        {
            TVDbContext m = new TVDbContext();
            m.TVSeries.First();
            Assert.IsTrue(m != null);
        }

    }
}
