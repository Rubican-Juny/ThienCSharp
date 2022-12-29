// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Start Program!");
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int number = 10;
double sole = 10.5;
string srt = "Rubican";
bool check = true;
string str = "Thiện";

//Kieu so ko duoc null kieu chuoi thi duoc

String name = null;
//int so = null;

//code cu
Nullable<bool> so2 = null;

//code moi xin xo => nullable value type
int? so3 = null;
bool? check2 = null;

// ?: => ternary operator
Console.WriteLine(name !=null? true : false);
// is not null(!=)
//is (==)
Console.WriteLine(name is not null? true : false);

//? => null conditional operator
//dung sau dit ten bien , hay doi tuong
//tuong tu (!=), neu cai gi do khac null thi lay cai ve sau
int? length = name?.Length;

//viet dai ra se nhu vay

//if (name != null)
//{
//    length = name.Length;
//}
//else
//{
//    length = null;
//}

//?? =>null coalescing operator
// ?? tương tự dấu == , nếu cái gì đó bằng null thì lấy cái vế sau

int? chieudai = name?.Length ?? 10;

bool ok = false;
while (ok)
{
    ok = true;
    Console.WriteLine("ok");
}