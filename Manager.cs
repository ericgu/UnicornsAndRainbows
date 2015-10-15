using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class Manager
    {
        private IUserInterface m_userInterface;
        private Configuration m_configuration;
        private IBrowserNavigator m_browserNavigator;
        private int m_count; 

        public Manager(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator)
        {
            m_browserNavigator = browserNavigator;
            m_configuration = configuration;
            m_userInterface = userInterface;

            userInterface.OnButtonClick += ButtonClick;
        }

        void ButtonClick(string searchTerm)
        {
            m_count++;

            m_userInterface.SetCount(m_count);

            m_browserNavigator.NavigateToUrl(new Uri(m_configuration.SearchRoot + searchTerm));

        }
    }
}
