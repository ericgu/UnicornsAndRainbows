using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class Pipeline_Tests
    {
        [TestMethod]
        public void when_I_hook_a_string_creator_to_a_consumer__the_value_is_passed_through()
        {
            string consumerValue = null;

            Pipeline.Process(
                () => { return "Fred"; },
                (value) => { consumerValue = value; });

            Assert.AreEqual("Fred", consumerValue);
        }

        [TestMethod]
        public void when_I_hook_a_string_creator_to_a_processor_and_a_consumer__the_value_is_passed_through()
        {
            string consumerValue = null;

            Pipeline.Process(
                () => { return "Fred"; },
                (value) => { return value + " and friends"; },
                (value) => { consumerValue = value; });

            Assert.AreEqual("Fred and friends", consumerValue);
        } 
 
        [TestMethod]
        public void when_I_hook_a_string_to_a_processor_and_a_consumer__the_value_is_passed_through()
        {
            string consumerValue = null;

            Pipeline.Process(
                "Fred",
                (value) => { return value + " and friends"; },
                (value) => { consumerValue = value; });

            Assert.AreEqual("Fred and friends", consumerValue);
        }

        [TestMethod]
        public void when_I_hook_a_string_to_a_processor_and_a_converter_and_a_consumer__the_value_is_passed_through()
        {
            Uri consumerValue = null;

            Pipeline.Process(
                "space",
                (value) => { return "http://www.example.com/" + value; },
                (value) => { return new Uri(value); },
                (value) => { consumerValue = value; });

            Assert.AreEqual("http://www.example.com/space", consumerValue.OriginalString);
        } 

    }
}
