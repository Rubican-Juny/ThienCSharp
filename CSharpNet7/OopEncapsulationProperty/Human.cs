using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty
{
    internal class Human
    {
        //field(phải là private)
        private string fullname;

        //các thuốc tính phải có bổ từ truy cập là public 
        public string Fullname { get => fullname; set => fullname = value; }
        
        //auto - property => dập các field thành thuộc tính
        public string Address { get; set; }
        
        public void Hello()
        {
            Address = "123";
            Console.WriteLine(Address);
        }
    }
}
