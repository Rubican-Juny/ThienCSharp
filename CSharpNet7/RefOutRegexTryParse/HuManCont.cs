
namespace RefOutRegexTryParse
{
    internal partial class Human
    {
        //1 Phương thức chỉ có 1 câu lệnh
        //csharp sẽ không sử dụng pương thức mà dùng
        //expression body => biểu thức dưỡi dạng phương thức
        public void Show() =>
            Console.WriteLine($"{nameof(fullname)}:{fullname}");
        public void Check() => Console.WriteLine(10 > 5 ? true : false);
    }
}
