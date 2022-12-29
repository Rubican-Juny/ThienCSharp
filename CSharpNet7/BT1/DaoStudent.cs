using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class DaoStudent
    {
        List<Student> List;
        public void ListStudent()
        {
            List = new List<Student>();
        }
        public List<Student> GetList()
        {
            return List;
        }
        public void SetList(List<Student> List)
        {
            this.List = List;
        }
        public void SelectAllStudent()
        {
            List.ForEach(Console.WriteLine);
        }
        public void AddStudent()
        {
            Student stu = new ();
            stu.InsertStudent();
            List.Add(stu);
        }
    }
}
