using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Person : PhoneBook
    {
        public Person(string surename, string address, string phone) : base(surename, address, phone)
        {
            
        }

        public override void Print()
        {
            Console.WriteLine("Person:");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
        }
    }

    class Organization : PhoneBook        
    {
        public Organization(string organization, string address, string phone, string fax, string surename) : base(surename, address, phone)
        {
            this.organization = organization;
            this.fax = fax;
        }

        public override void Print()
        {
            Console.WriteLine("Organization:");
            Console.WriteLine($"Name of organization: {organization}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Fax: {fax}");
            Console.WriteLine($"Surname of contact face: {surname}");
            
        }

        public string organization;
        public string fax;
    }

    class Friend : PhoneBook
    {
        public Friend(string surename, string address, string phone, string date) : base(surename, address, phone)
        {
            this.date = date;
        }

        public override void Print()
        {
            Console.WriteLine("Friend:");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Date of birth: {(string)date}");
        }

        public Date date;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneBook> list = Initialization();
            
            PrintData(list);

            SearchPhone(list);
        }

        static List<PhoneBook> Initialization()
        {
            List<PhoneBook> list = new List<PhoneBook>();

            list.Add(new Person("Kanatush", "Krutaya 29", "5-10-55"));
            list.Add(new Organization("Microsoft", "USA", "555-10-20-33", "fax", "noName"));
            list.Add(new Friend("Ivanov", "Street 21", "12-34-56", "01/10/2010"));

            return list;
        }

        static void PrintData(List<PhoneBook> list)
        {
            foreach (PhoneBook data in list)
            {
                data.Print();
                Console.WriteLine();
            }
        }

        static void Search(List<PhoneBook> list)
        {
            string surname;

            do
            {
                bool isSearch = false;

                Console.Write("Input surname: ");
                surname = Console.ReadLine();

                foreach (PhoneBook data in list)
                {
                    if (data.Search(surname)) { data.Print(); isSearch = true; }
                    else if (surname == "exit") break;
                }
                if (!isSearch && surname != "exit") Console.WriteLine("This surname is not exists");
                Console.WriteLine();

            } while (surname != "exit");
        }

        static void SearchPhone(List<PhoneBook> list)
        {
            string phone;

            do
            {
                bool isSearch = false;

                Console.Write("Input phone: ");
                phone = Console.ReadLine();

                foreach (PhoneBook data in list)
                {
                    if (data.SearchPhone(phone)) { data.Print(); isSearch = true; }
                    else if (phone == "exit") break;
                }
                if (!isSearch && phone != "exit") Console.WriteLine("This phone is not exists");
                Console.WriteLine();

            } while (phone != "exit");
        }
    }
}
