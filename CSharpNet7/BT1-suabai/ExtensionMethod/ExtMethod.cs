using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_suabai.ExtensionMethod
{
    static class ExtMethod
    {
        public static void ChaneColor<T>(this T item, params ConsoleColor[] colors)
        {
            Console.BackgroundColor = colors[0];
            Console.ForegroundColor = colors[1];
        }
    }
}
