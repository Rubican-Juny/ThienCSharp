
using ListAndLinq;
using System.Collections.Generic;
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
//Console.WriteLine("style 1:");
//foreach (var i in from stu in students where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}

//style 2 của linq : method syntax
//style 2 chạy nhanh hơn
Console.WriteLine("style2 :");
//var t = students.Where(stu => stu.Id > 2);
//foreach (var i in t){
//    Console.WriteLine(i);
//}
//style 2 nhưng gọn hơn
foreach (var i2 in students.Where(stu => stu.Id > 2))
{
    Console.WriteLine(i2);
}
Console.WriteLine("cho mấy thằng giỏi xài");
students.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);

var t = from stu in students
select stu;

IEnumerable<Student> i = from stu in students
                          select stu;
//với linq to object
//khi sử dụng query syntax hay method syntax thi trả về không phải là list , hay array => IEnumerable (con của ienumerator duyệt qua collection: list ,array,dictionary,hashmap...) dùng để duyệt qua linq to object

students.ForEach(Console.WriteLine);
t.ToList().ForEach(Console.WriteLine);

//==========================
//Confeser sẽ viết như này
//Phương thức của cái list không phải linq(áp dụng lambda)
//nhanh hơn
students.ForEach(
    stu =>
    {
        if (stu.Id > 2)
        {
            Console.WriteLine(stu);
        }
    }
);
//linq method syntax
students.Where(stu => stu.Id > 2)
    .ToList()
    .ForEach(Console.WriteLine);
//
var t2 = from stu in students
        where stu.Id > 2
        select stu;
t2.ToList().ForEach(Console.WriteLine);

//lấy thuộc tín từ sinh viên như câu select lấy các cột
Console.WriteLine("lấy thuộc tín từ sinh viên như câu select lấy các cột");
//Query syntax 
Console.WriteLine("Query syntax");
var t3 = from stu in students
         where stu.Id > 2
         select new
         {
             Info = $"{stu.Id} : {stu.Name}",
             Birthday = stu.Dob
         };
t3.ToList().ForEach(Console.WriteLine);
t3.ToList().ForEach(i => Console.WriteLine(i.Birthday));
//Method syntax
Console.WriteLine("Method syntax");
students.Where(stu=>stu.Id>2)
    .Select(stu => new
    {
        Info = $"{stu.Id} : {stu.Name}",
        stu.Gender
    }
    )
    .ToList()
    .ForEach(Console.WriteLine);
//sắp xếp trật tự:
Console.WriteLine("Sắp xếp theo trật tự");
Console.WriteLine( "Kiểu1:");
students.Where(stu => stu.Id > 2)
    .OrderBy(stu => stu.Id)
    .ThenBy(stu => stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);
Console.WriteLine("Kiểu2:");

students.Where(stu => stu.Id > 2)
    .OrderByDescending(stu => stu.Id)
    .ThenByDescending(stu => stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);
