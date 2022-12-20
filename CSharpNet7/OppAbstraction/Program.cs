// See https://aka.ms/new-console-template for more information
using OppAbstraction;

Console.WriteLine("Start Program");

//1 class là abstract thì ko đc phép khởi tạo đối tượng 
//Animal animal = new Animal();
//Cat cat = new Cat();


//pure oop = oop nguyên thử , oop thuần
//thường dùng khi có interface
Dog dog1 = new Dog();

//c# new  , thường dùng nhanh
var dog2 = new Dog();

//c# ver 10
//target = type new 
//thường dùng cho mobile hoặc code olatform
Dog dog3 = new Dog();
