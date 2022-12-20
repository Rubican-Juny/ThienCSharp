

namespace OppAbstraction
{
    //kế thừa dùng dấu :
    internal abstract class Cat : Animal
    {
        //con kế thừa cha mà cha abstract ,con phải thực thi lại các phương thức abstract , nếu không con phải là abstract
        private bool gender;
        //Phương thức chỉ có 1 dòng lệnh chuyển thành expression body bằng cách ctrl dấu chấm
        public void ShowCat() => Console.WriteLine("This is a cat");

    }
}
