// See https://aka.ms/new-console-template for more information
using OopPolymorphismOverriding;

Console.WriteLine("Start Program!");

Parent pa = new();
pa.Show();
pa.Display();

ChildOne co = new ChildOne();
co.Show();
co.Display();

Parent p = new ChildOne();
p.Show(); //show của cha chứ không phải của con
p.Display();

