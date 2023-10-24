using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть прізвище співробітника: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть ім'я співробітника: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть посаду співробітника (manager/developer/analyst): ");
            string position = Console.ReadLine();

            Console.Write("Введіть стаж співробітника (роки): ");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(lastName, firstName);
            employee.SetPosition(position);
            employee.CalculateSalary(experience);

            Console.ReadLine();
        }
    }
}
