
using OopEncapsulationProperty;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Human human = new();
human.Fullname = "Thiện";
Console.WriteLine(human.Fullname);