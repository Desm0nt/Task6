using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Cabinet { get; set; }
        public DateTime HiringDate { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee obj)
        {
            return Salary.CompareTo(obj.Salary);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName 
                + ", Position: " + Position 
                + ", Cabinet: " + Cabinet 
                + ", Hiring Date: " + HiringDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) 
                + ", " + string.Format("Salary: {0:C2}", Salary, CultureInfo.InvariantCulture));
        }

    }
}
