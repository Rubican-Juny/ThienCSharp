using BT1_suabai.Dal;
using BT1_suabai.ExtensionMethod;
using BT1_suabai.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BT1_suabai.Menu
{
    internal class MainMenu
    {
        public static void Show()
        {
            DalProduct dal = new();

            while (true )
            {
                Console.WriteLine("Please choose: ");
                Console.WriteLine("1 - add product: ");
                Console.WriteLine("2 - show list: ");
                Console.WriteLine("Not in  (1,2) - exit: ");
                var n = Validate<int>.Input("Please enter number");
                switch(n)
                {
                    case 1 :
                        dal.ChangeColor(ConsoleColor.White, ConsoleColor.Red);
                        dal.Add();
                        break;
                    case 2:
                        dal.Show();
                        break;
                    default:
                        dal.ChangeColor(ConsoleColor.Red, ConsoleColor.White);
                        dal.Add();
                        Console.WriteLine("END");
                        return;
                }
            }
        }
    }
}
