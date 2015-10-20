using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class Manager_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            UserInterfaceSimulator userInterface = new UserInterfaceSimulator();

            Configuration configuration = new Configuration();
            configuration.SearchRoot = "http://www.example.com/search/term=";

            BrowserNavigatorSimulator browserNavigator = new BrowserNavigatorSimulator();

            Manager manager = new Manager(userInterface, configuration, browserNavigator);

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
            Assert.AreEqual(1, userInterface.Count);
        }

        [TestMethod]
        public void when_I_change_the_searchRoot_and_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            UserInterfaceSimulator userInterface = new UserInterfaceSimulator();

            Configuration configuration = new Configuration();
            configuration.SearchRoot = "http://www.example.com/search/term=";

            BrowserNavigatorSimulator browserNavigator = new BrowserNavigatorSimulator();

            Manager manager = new Manager(userInterface, configuration, browserNavigator);

            configuration.SearchRoot = "http://www.example.com/makethesearch/term=";
            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
            Assert.AreEqual(1, userInterface.Count);
        }
    }
}
