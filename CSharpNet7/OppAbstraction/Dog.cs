
namespace OppAbstraction
{

    internal class Dog : Animal
    {
        // dự thi lại cái phương thức abstract của animal 
        //buộc phải dùng từ khóa override vào
        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
