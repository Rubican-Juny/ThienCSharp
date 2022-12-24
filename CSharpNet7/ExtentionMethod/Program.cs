// See https://aka.ms/new-console-template for more information
using ExtentionMethod;
using System.Text;

Console.WriteLine("Start Program!");
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Nhập i :");
int i = int.TryParse(Console.ReadLine(),out int result)?result:0;
CheckNumber.CheckIsGreaterThan(i, 100);

i.CheckIsGreaterThan(100);

Program pro = new();
pro.Hello();

