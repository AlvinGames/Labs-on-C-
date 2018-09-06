using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = LoadFromFile("input.txt");

            list = list.OrderBy(student => student.year).ToList();

            PrintToFile(list, "output.txt");

            list = list.OrderBy(student => student.group).ToList();

            printToFile(list, "session.txt");
        }

        static List<Student> LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                List<Student> list = new List<Student>();

                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    list.Add((Student)reader.ReadLine());
                }

                reader.Close();
                file.Close();

                return list;
            }
            return new List<Student>();
        }

        static void PrintToFile(List<Student> list, string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            foreach (Student data in list)
            {
                writer.WriteLine(data.ToString());
            }

            writer.Close();
            file.Close();
        }

        static void printToFile(List<Student> list, string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            foreach (Student data in list)
            {
                if (data.Arithmetic >= 4)
                    writer.WriteLine(data.ToString());
            }

            writer.Close();
            file.Close();
        }
    }
}
