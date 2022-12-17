// See https://aka.ms/new-console-template for more information
using RefOutRegexTryParse;


Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Start Program");
int a = 10;
int b = 20;
Console.WriteLine("Not Change value : ");

Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");
RefOut.ChangeVar(a, b);
RefOut.ChangeVar2(ref a, ref b);
RefOut.ChangeVar3(out int c, out int d);
//Pure oop => oop nguyên thủy , thần oop => c# cũ
RegexTryParse parse = new RegexTryParse();

//dùng từ var
var par = new RegexTryParse();

//targer-type c# new
RegexTryParse p = new();

p.CheckNumberByRegex();
p.CheckStringByTryParse();
p.TryCatchBug();
Human hu = new();
hu.Show();
hu.Check();