using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_suabai.Helper
{
    internal class Validate<T>
    {
        public  static T Input(string message)
        {   //cho biết loại kiểu tương ứng với class(kiểu int thành class Int32,kiểu bool thành class Boolean
            var typecode = Type.GetTypeCode(typeof(T));
            object obj = new();
            bool flag;
            do
            {
                Console.WriteLine(message);
                flag = true;
                try
                {
                    var str = Console.ReadLine();
                    if (string.IsNullOrEmpty(str))
                    {
                        throw new Exception("!!! Error, null or empty !!!");
                    }

                    switch (typecode)
                    {
                        case TypeCode.String:
                            obj = str;
                            break;
                        case TypeCode.Int32:
                            obj = Convert.ToInt32(str);
                            if((int)obj < 0) 
                            {
                                throw new Exception("Value must be greater than or equal 0");
                            }
                            break;
                        case TypeCode.Double:
                            obj = Convert.ToDouble(str);
                            if ((double)obj < 0)
                            {
                                throw new Exception("Value must be greater than or equal 0");
                            }
                            break;
                        case TypeCode.DateTime:
                            var date = DateTime.TryParseExact(str,new[] { "d/M/yyyy","d-M-yyyy"},new CultureInfo("vi-VN"),
                                DateTimeStyles.None,out var t)?t:throw new Exception("Date time wrong (d-M-yyyy or d/M/yyyy)");
                            obj = date.Add(DateTime.Now.TimeOfDay);
                            break;
                        default:
                            obj = null;
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.GetType()}: {e.Message},Enter again");
                    flag = false;
                }
                
            } while (!flag);
            return (T)obj;
        }
    }
}
