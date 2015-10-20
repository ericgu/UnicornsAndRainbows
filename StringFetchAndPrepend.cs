using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class StringFetchAndPrepend
    {
        private Func<string> m_func;

        public StringFetchAndPrepend(Func<string> func)
        {
            m_func = func;
        }

        public string Process(string myValue)
        {
            return m_func() + myValue;
        }
    }
}
