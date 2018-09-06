using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Student : IComparable<Student>
    {
        public Student()
        {
            mas = new int[3];
        }

        public int CompareTo(Student obj)
        {
            if (year < obj.year) return -1;
            else if (year > obj.year) return 1;
            else return 0;
        }

        public override string ToString()
        {
            string[] data =
            {
                surname, " ",
                name, " ",
                middleName, " ",
                year.ToString(), " ",
                street, " ",
                address.ToString(), " ",
                group.ToString(), " ",
                mas[0].ToString(), " ",
                mas[1].ToString(), " ",
                mas[2].ToString()
            };

            return string.Concat(data);
        }

        public void Print()
        {
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Middle name: {0}", middleName);

            Console.WriteLine("Year of birth: {0}", year);

            Console.WriteLine("Street: {0}", street);
            Console.WriteLine("Address: {0}", address);

            Console.WriteLine("Group: {0}", group);
            Console.WriteLine("Marks for a session: {0} {1} {2}", mas[0], mas[1], mas[2]);
        }

        public static explicit operator Student(string sData)
        {
            Student obj = new Student();

            char[] simbol = { ' ' };
            string[] data = sData.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            if (data.Length == 10)
            {
                obj.surname = data[0];
                obj.name = data[1];
                obj.middleName = data[2];

                obj.year = Convert.ToInt32(data[3]);

                obj.street = data[4];
                obj.address = Convert.ToInt32(data[5]);

                obj.group = Convert.ToInt32(data[6]);

                obj.mas[0] = Convert.ToInt32(data[7]);
                obj.mas[1] = Convert.ToInt32(data[8]);
                obj.mas[2] = Convert.ToInt32(data[9]);

            }

            return obj;
        }

        public float Arithmetic
        {
            get
            {
                return (mas[0] + mas[1] + mas[2]) / 3.0f;
            }
        }

        public string surname;
        public string name;
        public string middleName;

        public int year;

        public string street;
        public int address;

        public int group;
        public int[] mas;
    }
}
