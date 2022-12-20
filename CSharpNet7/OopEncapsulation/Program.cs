// See https://aka.ms/new-console-template for more information
using OopEncapsulation;

Console.WriteLine("Start Program");


SunFlower flower = new();
//flower.Protected(); //ko Là con nên ko được quyền xài
flower.Internal();  //trong cùng project/assembly
//flower.PrivateProtected(); //ko là  Private hoặc là Protected thì ko đc dùng
flower.ProtectedInternal(); // con hooặc cùng project
flower.Public();
//flower.Private(); => lỗi vì chỉ class plant mới dùng đc
