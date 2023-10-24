using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03

{
   public class Employee
    {
        private string lastName;
        private string firstName;
        private string position;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void CalculateSalary(int experience)
        {
            double baseSalary = 0;
            switch (position.ToLower())
            {
                case "manager":
                    baseSalary = 50000;
                    break;
                case "developer":
                    baseSalary = 60000;
                    break;
                case "analyst":
                    baseSalary = 55000;
                    break;
                default:
                    baseSalary = 50000;
                    break;
            }

            double salary = baseSalary + (experience * 2000);
            double tax = salary * 0.1; // 10%
            double netSalary = salary - tax;

            Console.WriteLine("Ім'я: " + firstName);
            Console.WriteLine("Прізвище: " + lastName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + salary);
            Console.WriteLine("Податковий збір: " + tax);
            Console.WriteLine("Чистий оклад: " + netSalary);
        }
    }
}

