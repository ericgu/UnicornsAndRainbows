using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    class UserInterfaceSimulator: IUserInterface
    {
        public event EventHandlerString OnButtonClick;

        public void SimulateButtonClick(string searchTerm)
        {
            if (OnButtonClick != null)
            {
                OnButtonClick(searchTerm);
            }
        }

        public int Count { get; set; }

        public void SetCount(int count)
        {
            Count = count;
        }
    }
}
