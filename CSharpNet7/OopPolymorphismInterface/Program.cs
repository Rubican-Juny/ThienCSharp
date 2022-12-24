// See https://aka.ms/new-console-template for more information
using OopPolymorphismInterface;

Console.WriteLine("Start Program!");

SomeFile some = new SomeFile();
some.ReadFile();
some.WriteTextFille();
some.WriteBinaryFile();

((IBinary)some).ShowInfo();

//Cách dưới ok hơn
(some as IBinary).ShowInfo();

ManyFile many= new ManyFile();
many.WriteBinaryFile();
(many as IBinary).ReadFile();
(many as IBinary).ShowInfo();

many.WriteBinaryFile();
((ITextFile)many).ReadFile();

//==============
IBinary bf = new SomeFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();

bf = new ManyFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();



