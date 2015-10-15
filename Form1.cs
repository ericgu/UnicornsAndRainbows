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


        public Form1()
        {
            InitializeComponent();

            UserInterface userInterface = new UserInterface(c_buttonUnicorns, c_buttonRainbows, c_labelCount);
            m_configuration = new Configuration();
            m_configuration.SearchRoot = "http://www.bing.com/images/search?q=";
            m_browserNavigator = new BrowserNavigator();


            Manager manager = new Manager(userInterface, m_configuration, m_browserNavigator);
        }
    }
}
