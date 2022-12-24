
using ListAndLinq;
using System.Text;

Console.WriteLine("Start Program!");
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> students = new()
{
    new Student(){Id =1,Name="Thiện",Gender = true , Dob = new DateTime(1999,04,18)},
    new Student(){Id =2,Name="Phúc",Gender = true , Dob = new DateTime(1998,05,19)},
    new Student(){Id =3,Name="Sơn",Gender = true , Dob = new DateTime(1997,06,20)},
    new Student(){Id =4,Name="Lợi",Gender = true , Dob = new DateTime(1996,07,30)},
    new Student(){Id =5,Name="Oanh",Gender = false , Dob = new DateTime(1959,08,11)},
};
foreach(var stu in students)
{
    Console.WriteLine(stu);
}
//vòng lặp vip hơn
//IEnumberator<Student> enu = students.GetEnumerator();
//while (enu.MoveNext())
//{

//    Console.WriteLine(enu.Current.ToString());
//}
//code ngắn nhất chạy chậm nhất
students.ForEach(Console.WriteLine);

//linq = language integrated query
//linq to sql => thay thể cú pháp sql trobg c#
//linq to object => console 
//sql => select from where group by having order by
//c# => FROM WHERE GROUP BY HAVING ORDER BY ... SELECT
//linq có 2 dạng
//style 1 => query syntax => dựa theo cú pháp cúa sql , dễ học , dễ dùng
//style 2 => method syntax => dựa theo lambda => khó học , khó dùng , nhưng cực nhanh

//hiển thị toàn bộ thông tin sinh viên trong list , với điều kiện id phải lớn hơn 2


foreach (var stu in students)
{
    if (stu.Id > 2)
    {
        Console.WriteLine(stu);
    }
}

//đây là style 1 của linq

//var t = from stu in students 
//        where stu.Id > 2 
//        select stu;
//foreach(var i in t)
//{
//    Console.WriteLine(i);
//}

//style 1 của linq nhưng thu gọn hơn
Console.WriteLine("style 1:");
foreach (var i in from stu in students where stu.Id > 2 select stu)
{
    Console.WriteLine(i);
}

//style 2 của linq : method syntax
//style 2 chạy nhanh hơn
Console.WriteLine("style2 :");
//var t = students.Where(stu => stu.Id > 2);
//foreach (var i in t){
//    Console.WriteLine(i);
//}
//style 2 nhưng gọn hơn
foreach (var i in students.Where(stu => stu.Id > 2))
{
    Console.WriteLine(i);
}
Console.WriteLine("cho mấy thằng giỏi xài");
students.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);

