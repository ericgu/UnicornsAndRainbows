using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class Pipeline
    {
        static public void Process<T1>(Func<T1> func1, Action<T1> action)
        {
            action(func1());
        }

        static public void Process<T1, T2>(Func<T1> func1, Func<T1, T2> func2, Action<T2> action)
        {
            action(func2(func1()));
        }

        static public void Process<T1, T2>(T1 input, Func<T1, T2> func2, Action<T2> action)
        {
            action(func2(input));
        }
        static public void Process<T1, T2, T3>(T1 input, Func<T1, T2> func2, Func<T2, T3> func3, Action<T3> action)
        {
            action(func3(func2(input)));
        }
    }
}
