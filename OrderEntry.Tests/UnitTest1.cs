using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderEntry.Models.Utility;
using System.Diagnostics;

namespace OrderEntry.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var str = "dOuG";
            var result = str.ConvertToTitleCase();
            Debug.WriteLine(result);
        }
    }
}
