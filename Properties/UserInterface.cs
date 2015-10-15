using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicornsAndRainbows
{
    internal interface IUserInterface
    {
        event UserInterface.EventHandlerString OnRainbowsClick;
        event UserInterface.EventHandlerString OnUnicornsClick;

        void SetCount(int count);
    }

    class UserInterface : IUserInterface
    {
        private Label m_countLabel;

        UI(Button unicornsButton, Button rainbowsButton, Label countLabel)
        {
            unicornsButton.Click += UnicornsClick;
            rainbowsButton.Click += RainbowsClick;

            m_countLabel = countLabel;
        }

        public delegate void EventHandlerString(string s);

        public event EventHandlerString OnRainbowsClick;
        public event EventHandlerString OnUnicornsClick;

        void RainbowsClick(object sender, EventArgs e)
        {
            if (OnRainbowsClick != null)
            {
                OnRainbowsClick("Rainbows");
            }
        }

        void UnicornsClick(object sender, EventArgs e)
        {
            if (OnUnicornsClick != null)
            {
                OnUnicornsClick("Rainbows");
            }
        }

        public void SetCount(int count)
        {
            m_countLabel.Text = count.ToString();
        }
    }
}
