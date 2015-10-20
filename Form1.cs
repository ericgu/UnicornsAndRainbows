using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicornsAndRainbows
{
    public partial class Form1 : Form
    {
        private Configuration m_configuration;
        private BrowserNavigator m_browserNavigator;
        private StringFetchAndPrepend m_searchUrlConstructor;

        public Form1()
        {
            InitializeComponent();

            UserInterface userInterface = new UserInterface(c_buttonUnicorns, c_buttonRainbows, c_labelCount);
            m_configuration = new Configuration();
            m_configuration.SearchRoot = "http://www.bing.com/images/search?q=";
            m_browserNavigator = new BrowserNavigator();
            m_searchUrlConstructor = new StringFetchAndPrepend(() => { return m_configuration.SearchRoot; });

            ClickCount clickCount = new ClickCount();
            userInterface.OnButtonClick += (s) => { clickCount.Click(); };
            clickCount.ValueChanged += (s, count) => { userInterface.SetCount(count); };

            userInterface.OnButtonClick += userInterface_OnButtonClick;

            //Manager manager = new Manager(userInterface, m_configuration, m_browserNavigator);
        }

        void userInterface_OnButtonClick(string s)
        {
            Pipeline.Process(
                s, 
                m_searchUrlConstructor.Process, 
                value => {return new Uri(value); },
                m_browserNavigator.NavigateToUrl);
        }
    }
}
