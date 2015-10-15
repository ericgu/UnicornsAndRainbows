using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbowsTests
{
    class BrowserNavigatorSimulator: IBrowserNavigator
    {
        public Uri Uri { get; set; }

        public void NavigateToUrl(Uri uri)
        {
            Uri = uri;
        }
    }
}
