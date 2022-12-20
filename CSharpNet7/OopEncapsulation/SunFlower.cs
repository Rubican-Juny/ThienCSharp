using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation
{
    internal class SunFlower : Plant
    {
        static void Main(string[] args)
        {
            SunFlower flower = new();
            flower.Protected(); //Là con nên được quyền xài
            flower.Internal();  //trong cùng project/assembly
            flower.PrivateProtected(); //hoặc Private hoặc là Protected thì đc dùng
            flower.ProtectedInternal(); // con hooặc cùng project
            flower.Public();
            //flower.Private(); => lỗi vì chỉ class plant mới dùng đc
        }
    }
}
