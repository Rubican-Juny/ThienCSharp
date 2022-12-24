using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    internal static class ExtentionMethod
    {
        public static void CheckIsGreaterThan(this int i, int value)
        {
            if (i > value)
            {
                Console.WriteLine($"{i} đúng là lớn hơn hơn {value}");
            }
        }
        public static void Hello(this Program pro)
        {
            Console.WriteLine("Ahihi");
        }
    }
}
