using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GuitarBIM_Code;

namespace GuitarBIM_CodeTests
{
    [TestClass]
    public class GuitarTest
    {
        
        [TestMethod]
        public void testProperties()
        {
            Guitar testGuitar = new Guitar("testGuitar");
            Assert.AreEqual("testGuitar", testGuitar.ModelName);
        }
    }
}
