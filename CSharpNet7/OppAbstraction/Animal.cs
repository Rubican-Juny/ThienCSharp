

namespace OppAbstraction
{
    internal abstract class Animal
    {
        //các field (thật chất là các biến toàn cục của riêng class này Animal)
        private string fullname;
        private int age;
        //1 Phuong thức không có body {} => nó là abstract
        //1 Phương thức là abstract thì cả class phải là abstract
        public abstract void ShowInfo();
    }
}
