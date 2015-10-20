using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class ClickCount
    {
        private int m_value;

        public int Value {
            get { return m_value; }
        }

        public void Click()
        {
            m_value++;

            if (ValueChanged != null)
            {
                ValueChanged(null, m_value);
            }
        }

        public event EventHandler<int> ValueChanged;
    }
}
