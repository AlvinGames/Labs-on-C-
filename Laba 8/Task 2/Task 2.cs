using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//╔══╗─╔╗─╔══╦══╗╔══╗
//╚═╗║─║║─║╔╗║╔╗║║╔╗║
//──║║─║║─║╚╝║╚╝╚╣╚╝║
//──║║─║║─║╔╗║╔═╗║╔╗║
//──║║─║╚═╣║║║╚═╝║║║║
//──╚╝─╚══╩╝╚╩═══╩╝╚╝
//╔════╦══╦══╦╗╔══╗─╔══╗
//╚═╗╔═╣╔╗║╔═╣║║╔═╝─╚═╗║
//──║║─║╚╝║╚═╣╚╝║───╔═╝║
//──║║─║╔╗╠═╗║╔╗║───║╔═╝
//──║║─║║║╠═╝║║║╚═╗─║╚═╗
//──╚╝─╚╝╚╩══╩╝╚══╝─╚══╝

namespace Task_2
{
    struct Student
    {
        public static int number = 1;
        public string sureName;
        public int n, m;
        public int[,] mas;
    }

    struct Template
    {
        public int n;
        public int m;
        public int[,] mas;
    }

    class Program
    {
        static void Main(string[] args)
        {
            String standardFile = "output.txt";
            String dirSolution = "solutions";
            String finalFile = "result.txt";

            if (StandartCheck(standardFile) && CatalogCheck(dirSolution))
            {
                //read of template
                Template template;
                readTemplate(out template, standardFile);

                //read of students works
                String[] files = Directory.GetFiles(dirSolution);
                int length = files.Length;

                if (length > 0)
                {
                    //massiv of students
                    Student[] obj = new Student[files.Length];

                    //read of students works
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i] = new Student();
                        readData(out obj[i], files[i]);
                        
                        printInf(obj[i]);
                    }

                    FileStream file = new FileStream(finalFile, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);

                    //comparing of students works with template
                    for (int i = 0; i < obj.Length; i++)
                    {
                        if (comparing(template.mas, obj[i].mas))
                        {
                            writer.WriteLine(obj[i].sureName);
                        }
                    }

                    writer.Close();
                    file.Close();
                }
                else
                {
                    Console.WriteLine("Works of students are absent");
                }
            }
        }
        
        static bool comparing(int[,] mas1, int[,] mas2)
        {
            bool size1 = mas1.GetLength(0) == mas2.GetLength(0);
            bool size2 = mas1.GetLength(1) == mas2.GetLength(1);

            if(size1 || size2)
            {
                for (int i = 0; i < mas1.GetLength(0); i++)
                {
                    for (int j = 0; j < mas1.GetLength(1); j++)
                    {
                        if(mas1[i,j] != mas2[i,j])                        
                            return false;
                        
                    }
                }

                return true;
            }
            return false;
        }

        static void print(int[,] mas)
        {
            for (int i = 0; i <= mas.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mas.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", mas[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void printInf(Student obj)
        {
            Console.WriteLine("Student number {0}", Student.number);
            Student.number++;
            Console.WriteLine("Surename: {0}", obj.sureName);
            Console.WriteLine("Size of matrix: {0}x{1}", obj.n, obj.m);
            Console.WriteLine("The matrix:");
            print(obj.mas);
            Console.WriteLine();
        }

        static void readTemplate(out Template obj, String name)
        {
            char[] simbol = { ' ' };

            FileStream file = new FileStream(name, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //read of size
            String temp = reader.ReadLine();
            String[] size = temp.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            //size of matrix
            obj.n = Convert.ToInt32(size[0]);
            obj.m = Convert.ToInt32(size[1]);

            obj.mas = new int[obj.n, obj.m];

            //read of marix
            for (int i = 0; i < obj.n; i++)
            {
                String line = reader.ReadLine();
                String[] nums = line.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < obj.m; j++)
                {
                    obj.mas[i, j] = Convert.ToInt32(nums[j]);
                }
            }

            reader.Close();
            file.Close();
        }

        static void readData(out Student obj, String fileName)
        {
            char[] simbol = { ' ' };

            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //read of name
            obj.sureName = reader.ReadLine();

            //read of size
            String temp = reader.ReadLine();
            String[] size = temp.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            //size of matrix
            obj.n = Convert.ToInt32(size[0]);
            obj.m = Convert.ToInt32(size[1]);

            obj.mas = new int[obj.n, obj.m];

            //read of marix
            for (int i = 0; i < obj.n; i++)
            {
                String line = reader.ReadLine();
                String[] nums = line.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < obj.m; j++)
                {
                    obj.mas[i, j] = Convert.ToInt32(nums[j]);
                }
            }

            reader.Close();
            file.Close();
        }

        static bool StandartCheck(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File \"{0}\" is not exists", fileName);
                File.Create(fileName);
                return false;
            }

        }
        
        static bool CatalogCheck(string fieName)
        {
            if (Directory.Exists(fieName))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ditrectory \"{0}\" is not exists", fieName);
                Directory.CreateDirectory(fieName);
                return false;
            }

        }
    }
}
