using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TearDownWithMSTest
{
    [TestClass]
    public class WhateverMSTest
    {
        [TestMethod]
        public void WhateverMS()
        {
            
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            Assert.Fail();
        }
    }
}
