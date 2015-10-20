using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class ClickCount_Tests
    {
        [TestMethod]
        public void when_I_create_an_instance__the_count_is_zero()
        {
            ClickCount clickCount = new ClickCount();

            Assert.AreEqual(0, clickCount.Value);
        }

        [TestMethod]
        public void when_I_create_an_instance_and_click_it_twice__the_count_is_two()
        {
            ClickCount clickCount = new ClickCount();
            clickCount.Click();
            clickCount.Click();

            Assert.AreEqual(2, clickCount.Value);
        }

        [TestMethod]
        public void when_I_create_an_instance_and_click_it__the_ValueChanged_event_is_fired()
        {
            ClickCount clickCount = new ClickCount();
            int value = 0;

            clickCount.ValueChanged += (s, newValue) => { value = newValue; };

            clickCount.Click();

            Assert.AreEqual(1, value);
        }  
    }
}
