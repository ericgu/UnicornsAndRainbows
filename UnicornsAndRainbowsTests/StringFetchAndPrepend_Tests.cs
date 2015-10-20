using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class StringFetchAndPrepend_Tests
    {
        [TestMethod]
        public void when_I_set_up_an_instance_and_process__the_fetched_value_is_prepended()
        {
            StringFetchAndPrepend stringFetchAndPrepend = new StringFetchAndPrepend(() => { return "Fetched"; });

            string result = stringFetchAndPrepend.Process(" my value");

            Assert.AreEqual("Fetched my value", result);
        }
    }
}
