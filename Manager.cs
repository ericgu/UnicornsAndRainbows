using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class Manager
    {
#if ManagerUsed
        private Configuration m_configuration;
        private IBrowserNavigator m_browserNavigator;

        public Manager(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator)
        {
            m_browserNavigator = browserNavigator;
            m_configuration = configuration;

            userInterface.OnButtonClick += ButtonClick;
        }

        void ButtonClick(string searchTerm)
        {
            m_browserNavigator.NavigateToUrl(new Uri(m_configuration.SearchRoot + searchTerm));

        }
#endif
    }
}
