using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Workers = new List<Employee>();
            for (int i = 0; i < 6; i++)
            {
                Workers.Add(new Employee() { FirstName = RandomString(7),
                    LastName = RandomString(5),
                    Position = RandomString(5),
                    Age = random.Next(18, 55),
                    Cabinet = random.Next(1, 255),
                    HiringDate = Convert.ToDateTime(random.Next(1, 12) + "/" + random.Next(1, 12) + "/" + random.Next(1988, 2017)),
                    Salary = random.Next(100, 1100) });
            }
            foreach(var worker in Workers)
            {
                worker.PrintInfo();
            }
            Workers.Sort();
            Console.WriteLine("\n SORTED BY SALARY (default): \n");
            foreach (var worker in Workers)
            {
                worker.PrintInfo();
            }
            Console.WriteLine("\n SORTED BY FIRST NAME: \n");
            Workers.Sort(delegate (Employee x, Employee y)
            {
                return x.FirstName.CompareTo(y.FirstName);
            });
            foreach (var worker in Workers)
            {
                worker.PrintInfo();
            }

            Console.WriteLine("\n SORTED BY CABINET NUMBER: \n");
            Workers.Sort(delegate (Employee x, Employee y)
            {
                return x.Cabinet.CompareTo(y.Cabinet);
            });
            foreach (var worker in Workers)
            {
                worker.PrintInfo();
            }
            Console.Read();
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwyxz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
