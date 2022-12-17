// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Text;

Console.WriteLine("Start Program!");
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number1 = Random.Shared.Next(0,9);
int number2 = Random.Shared.Next(0, 9);

Console.WriteLine("Vui long nhap dau cua phep toan: ");
string dau = Console.ReadLine();
Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");
switch (dau)
{
    case "+" when number1>0 && number2>0: 
        Console.WriteLine( number1 + number2);
        break;
    case "-" when number1 >= number2:
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/" when number2 != 0:
        Console.WriteLine(number1 / number2);
        break;
    default:
        Console.WriteLine("Nhap doang hoang vao ba");
        break;
}

//switch expression ( bieu thuc switch :bac cao hon cau lenh)
Console.WriteLine(
    dau switch
    {
        "+" when number1 > 0 && number2 > 0 => number1 + number2,
        "-" when number1 >= number2 => number1 - number2,
        "*" => number1 * number2,
        "/" when number2 != 0 => number1 / number2,
        _=> "hi, i can;t"
    }
);


string[] arrs = { "Khải", "Huyền", "Thất", "Bảy" };
//viet cai nay nguoi ta tang vo mom
foreach (var item in arrs)
{
    Console.WriteLine(item);
}
//viet nhu vay moi dung
IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = e.Current.ToString();
    Console.WriteLine(s);
}
