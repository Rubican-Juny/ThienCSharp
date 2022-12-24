using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding
{
    internal class ChildOne : Parent
    {
        //sửa lại phương thức của cha
        public override void Display() => Console.WriteLine("Childone display");
        //public override void Show() => Console.WriteLine("Childone display");
        //show của con không liên quan gì đến cha,có thể trùng tên nên đặt thêm chữ new,đây là phương thức hoàn toàn mới của con
        public new void Show() => Console.WriteLine("Childone show");

    }
}
