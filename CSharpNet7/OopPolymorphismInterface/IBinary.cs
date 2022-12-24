using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface
{
    internal interface IBinary
    {
        //không dùng bổ từ truy câp (public,private,....)
        void WriteBinaryFile();
        void ReadFile();
        //có phương thức mặc định tồn tại trong interface
        void ShowInfo() => Console.WriteLine("This is binary");

    }
}
