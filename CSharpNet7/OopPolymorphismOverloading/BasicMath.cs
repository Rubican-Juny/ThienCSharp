using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverloading
{
    internal class BasicMath
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        //viết ctor rồi tab (1 là constructor , 2 là các method)
        //dùng tên chỉ khác tham số  hay kiểu của tham số
        public BasicMath()
        {

        }
        //ctrl dấu chấm vào BasicMath r bấm contructor
        //public BasicMath(int numberOne, int numberTwo)
        //{
        //    NumberOne = numberOne;
        //    NumberTwo = numberTwo;
        //}
        //cùng tham số cùng kiểu lỗi
        //public BasicMath(int numberOne)
        //{
        //    NumberOne = numberOne;
        //}
        //public BasicMath(int numberTwo)
        //{
     
        //    NumberTwo = numberTwo;
        //}
        //Thay vi overloading phương thức
        //optional argument => đối số lựa chọn truyền cho tham số (parameter)
        public void Sum(int num1 = 0,int num2 = 0)
        {
            NumberOne = num1;
            NumberTwo = num2;
            Console.WriteLine(NumberOne + NumberTwo);
        }
        //public void Sum()
        //{
        //    NumberOne = 0;
        //    NumberTwo = 0;
        //    Console.WriteLine(NumberOne + NumberTwo);
        //}
    }
}
