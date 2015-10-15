using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicornsAndRainbows
{
    public interface IUserInterface
    {
        event EventHandlerString OnButtonClick;

        void SetCount(int count);
    }

    public delegate void EventHandlerString(string s);

    public class UserInterface : IUserInterface
    {
        private Label m_countLabel;

        public UserInterface(Button unicornsButton, Button rainbowsButton, Label countLabel)
        {
            unicornsButton.Click += ButtonClick;
            rainbowsButton.Click += ButtonClick;

            m_countLabel = countLabel;
        }

        public event EventHandlerString OnButtonClick;

        void ButtonClick(object sender, EventArgs e)
        {
            if (OnButtonClick != null)
            {
                OnButtonClick(((Button)sender).Text);
            }
        }

        public void SetCount(int count)
        {
            m_countLabel.Text = count.ToString();
        }
    }
}
