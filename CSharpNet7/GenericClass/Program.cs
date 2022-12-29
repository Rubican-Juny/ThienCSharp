// See https://aka.ms/new-console-template for more information
using GenericClass;

Console.WriteLine("Hello, World!");
ClassT<int> cl = new();
cl.Field = 10;
cl.Show();
ClassT<string> cl1 = new();
cl1.Field = "Hố hố";
cl1.Show();
ClassT<bool> cl2 = new();
cl2.Field = false;
cl2.Show();

ClassUV<bool, string> cl3 = new();
cl3.Field1 = true;
cl3.Field2 = "abc";
cl3.Show();

ClassUV<int, double> cl4 = new();
cl4.Field1 = 50;
cl4.Field2 = 100.21;
cl4.Show();