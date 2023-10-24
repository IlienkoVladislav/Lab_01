using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
        internal class Program
        {
            static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;

                Address address = new Address();

                address.Index = "228228";
                address.Country = "Україна";
                address.City = "Київ";
                address.Street = "Вулиця Донецька";
                address.House = "7";
                address.Apartment = "5";

                Console.WriteLine("Індекс: " + address.Index);
                Console.WriteLine("Країна: " + address.Country);
                Console.WriteLine("Місто: " + address.City);
                Console.WriteLine("Вулиця: " + address.Street);
                Console.WriteLine("Будинок: " + address.House);
                Console.WriteLine("Квартира: " + address.Apartment);


                Console.ReadKey();
            }
        }
    }

