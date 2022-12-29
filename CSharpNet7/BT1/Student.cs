
using System.Globalization;
using System.Text.RegularExpressions;

namespace BT1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }

        public void InsertStudent()
        {
            //get ID
            Console.WriteLine("ID student:");
            string? str = null;
            while(str== null)
            {
                str = Console.ReadLine();

                if (new Regex("^[0-9]+$").IsMatch(str))
                {
                    int result = int.Parse(str);
                    Id = result;
                }
                else
                {
                    str = null;
                    Console.WriteLine("ID must be Interger");
                }
            }
            //Get Name
            Console.WriteLine("Name student:");
            Name = Console.ReadLine();
            //Get Gender
            Console.WriteLine("Gender(|1-Male|2-Female|):");
            str = null;
            while (str == null)
            {
                str = Console.ReadLine();

                if (new Regex("^[1-2]+$").IsMatch(str))
                {
                    int result = int.Parse(str);
                    Gender = result == 1? true : false;

                }
                else
                {
                    str = null;
                    Console.WriteLine("Please just 1 or 2");
                }
            }
            //Get Dob
            Console.WriteLine("Day of birth(dd-mm-yyyy):");
            str = null;
            while (str == null)
            {
                str = Console.ReadLine();
                if (DateTime.TryParseExact(str, "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var g))
                {
                    Dob = g;
                }
                else
                {
                    str = null;
                    Console.WriteLine("Please enter format dd-mm-yyyy");
                }
            }
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
        }

    }
}
