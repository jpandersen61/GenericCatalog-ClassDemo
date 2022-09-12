using System;

namespace GenericCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog<Car> cars = new Catalog<Car>();
            Car c1 = new Car("AB 12 345", 80000);
            Car c2 = new Car("CD 34 456", 65000);
            Car c3 = new Car("EF 56 567", 28000);
            cars.Insert(c1.LicensePlate, c1);
            cars.Insert(c2.LicensePlate, c2);
            cars.Insert(c3.LicensePlate, c3);
            cars.PrintAll();


            

            Catalog<Employee> employees = new Catalog<Employee>();
            Employee e1 = new Employee("Allan", 1962);
            Employee e2 = new Employee("Bente", 1975);
            Employee e3 = new Employee("Carlo", 1973);
            employees.Insert(c1.LicensePlate, e1);
            employees.Insert(c2.LicensePlate, e2);
            employees.Insert(c3.LicensePlate, e3);
            employees.PrintAll();


            Catalog<Computer> computers = new Catalog<Computer>();
            Computer com1 = new Computer("123", "net1");
            Computer com2 = new Computer("456", "net12");
            Computer com3 = new Computer("789", "net3");
            computers.Insert(com1.SerialNo, com1);
            computers.Insert(com2.SerialNo, com2);
            computers.Insert(com3.SerialNo, com3);
            computers.PrintAll();

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
