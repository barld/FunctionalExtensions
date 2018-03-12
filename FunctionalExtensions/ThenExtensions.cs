using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalExtensions
{
    public static class ThenExtensions
    {
        public static b Then<a, b>(this a v, Func<a, b> f) => f(v);
        public static void Then<a>(this a v, Action<a> f) => f(v);
    }
}
