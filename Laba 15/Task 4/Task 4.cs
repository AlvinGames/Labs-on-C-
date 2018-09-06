using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Music { }

    class File
    {
        public void Print()
        {
            if (catalog.Count == 0) Console.WriteLine("| >Empty");
            else
            {
                foreach (DictionaryEntry data in catalog)
                {
                    Console.WriteLine($"|-> {data.Key}");
                }
            }
        }

        public void AddMusic(string name)
        {
            catalog.Add(name, new Music());
        }

        public void AddFile(string name)
        {
            catalog.Add(name, new File());
        }

        public void RemoveFile(string name)
        {
            catalog.Remove(name);
        }

        public Hashtable catalog = new Hashtable();
    }

    class Disk
    {
        public void Print()
        {
            if (file.Count == 0) Console.WriteLine("| >Empty");
            else
            {
                foreach (KeyValuePair<string, File> data in file)
                {
                    Console.WriteLine($"|-> {data.Key}");
                }
            }
        }

        public void AddFile(string name)
        {
            file.Add(name, new File());
        }

        public void RemoveFile(string name)
        {
            file.Remove(name);
        }

        public Dictionary<string, File> file = new Dictionary<string, File>();
    }

    static class Comp
    {
        public static void Print()
        {
            Console.WriteLine("My Comp\n| disks:");
            if(disk.Count == 0) Console.WriteLine("| >Empty");
            else
            {
                foreach (KeyValuePair<string, Disk> data in disk)
                {
                    Console.WriteLine($"|-> {data.Key}");
                }
            }
        }

        public static void AddDisc(string name)
        {
            disk.Add(name, new Disk());
        }

        public static void RemoveDisc(string name)
        {
            disk.Remove(name);
        }

        public static Dictionary<string, Disk> disk = new Dictionary<string, Disk>();
    }

    class Program
    {
        public DictionaryEntry obj = new DictionaryEntry();

        static void Main(string[] args)
        {
            LoadOfData();
            Interface();
        }

        static void LoadOfData()
        {
            Comp.AddDisc("D");
                Comp.disk["D"].AddFile("Music");
                    Comp.disk["D"].file["Music"].AddMusic("AlanWalker.mp3");
                    Comp.disk["D"].file["Music"].AddMusic("WhereIsMyMind.mp3");
                    Comp.disk["D"].file["Music"].AddMusic("HelloNeighbour.mp3");
                    Comp.disk["D"].file["Music"].AddFile("File");
                Comp.disk["D"].AddFile("MyFiles");
                Comp.disk["D"].AddFile("Games");

            Comp.disk.Add("C", new Disk());

            Comp.disk.Add("E", new Disk());
        }

        static void Interface()
        {
            while (true)
            {
                Comp.Print();

                Console.WriteLine();
                Console.WriteLine("(ad) Add disck");
                Console.WriteLine("(dd) Delete Disk");
                Console.WriteLine("(ed) Enter to the Disk");

                string command = Console.ReadLine();

                if (command == "ad")
                {
                    Console.Clear();
                    Comp.Print();
                    Console.Write("\nInput name of the added disk: ");

                    string name = NameOfDisk(true);

                    if (name == "exit") { Console.Clear(); continue; }

                    Comp.AddDisc(name);
                }
                else if (command == "dd")
                {
                    Console.Clear();
                    Comp.Print();
                    Console.Write("\nInput name of the deleted disk: ");

                    string name = NameOfDisk(false);

                    if (name == "exit") { Console.Clear(); continue; }

                    Comp.RemoveDisc(name);
                }
                else if (command == "ed")
                {
                    Console.Clear();
                    Comp.Print();
                    Console.Write("\nInput name of the disk: ");

                    string name = NameOfDisk(false);

                    if (name == "exit") { Console.Clear(); continue; }

                    EnterToDisc(name);
                }
                else if (command == "exit") break;
                else
                {
                    Console.WriteLine("Unknown command (press any key to continue)");
                    Console.ReadKey();
                }

                Console.Clear();
            }
        }

        static void EnterToDisc(string nameDisk)
        {
            while (true)
            {
                Console.Clear();
                Disk disk = Comp.disk[nameDisk];

                Console.WriteLine($"| Disk {nameDisk}");
                disk.Print();

                Console.WriteLine();
                Console.WriteLine("(af) Add file");
                Console.WriteLine("(df) Delete file");
                Console.WriteLine("(ef) Enter to the file");

                string command = Console.ReadLine();

                if (command == "af")
                {
                    Console.Clear();
                    Console.WriteLine($"| Disk {nameDisk}");
                    disk.Print();
                    Console.Write("\nInput name of the added file: ");

                    string name = NameOfFile(nameDisk, true);

                    if (name == "exit") { Console.Clear(); continue; }

                    disk.AddFile(name);
                }
                else if (command == "df")
                {
                    Console.Clear();
                    Console.WriteLine($"| Disk {nameDisk}");
                    disk.Print();
                    Console.Write("\nInput name of the deleted file: ");

                    string name = NameOfFile(nameDisk, false);

                    if (name == "exit") { Console.Clear(); continue; }

                    disk.RemoveFile(name);
                }
                else if (command == "ef")
                {
                    Console.Clear();
                    Console.WriteLine($"| Disk {nameDisk}");
                    disk.Print();

                    Console.Write("\nInput name of the file: ");

                    string fileName = NameOfFile(nameDisk, false);

                    if (fileName == "exit") { Console.Clear(); continue; }

                    EnterToFile(
                        Comp.disk[nameDisk].file[fileName],
                        fileName
                        );
                }
                else if (command == "exit") break;
                else
                {
                    Console.WriteLine("Unknown command (press any key to continue)");
                    Console.ReadKey();
                }
            }
        }

        static void EnterToFile(File file, string nameFile)
        {
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine($"| File {nameFile}");
                file.Print();

                Console.WriteLine();
                Console.WriteLine("(af) Add file");
                Console.WriteLine("(df) Delete file");
                Console.WriteLine("(ef) Enter to the file");
                Console.WriteLine("(am) Add Music");
                Console.WriteLine("(dm) Delete Music");

                string command = Console.ReadLine();

                if(command == "af")
                {
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();

                    Console.Write("\nInput name of the added file: ");

                    string name = NameOfFile(file, nameFile, true);

                    if (name == "exit") { Console.Clear(); continue; }

                    file.AddFile(name);
                }
                else if(command == "df")
                {
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();

                    Console.Write("\nInput name of the deleted file: ");

                    string name = NameOfFile(file, nameFile, false);

                    if (name == "exit") { Console.Clear(); continue; }

                    file.RemoveFile(name);
                }
                else if (command == "ef")
                {
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();

                    Console.Write("\nInput name of the file: ");

                    string tempName = NameOfFile(file, nameFile, false);

                    if (tempName == "exit") { Console.Clear(); continue; }

                    EnterToFile((File)(file.catalog[tempName]), tempName);
                }
                else if (command == "am")
                {
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();

                    Console.Write("\nInput name of the added music: ");

                    string name = NameOfMusic(file, nameFile, true);

                    if (name == "exit") { Console.Clear(); continue; }

                    file.AddMusic(name);
                }
                else if (command == "dm")
                {
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();

                    Console.Write("\nInput name of the deleted music: ");

                    string name = NameOfFile(file, nameFile, false);

                    if (name == "exit") { Console.Clear(); continue; }

                    file.RemoveFile(name);
                }
                else if (command == "exit") break;
                else
                {
                    Console.WriteLine("Unknown command (press any key to continue)");
                    Console.ReadKey();
                }
            }
        }

        static string NameOfDisk(bool flag)
        {
            string not = flag ? "" : " not";

            bool isCorrect;
            string name;

            do
            {
                isCorrect = true;

                name = Console.ReadLine();
                if (Comp.disk.ContainsKey(name) == flag)
                {
                    isCorrect = false;
                    Console.Clear();
                    Comp.Print();
                    Console.WriteLine($"\nThis disc is{not} exists, try again");
                }
                if (name.Length == 0)
                {
                    isCorrect = false;
                    Console.Clear();
                    Comp.Print();
                    Console.WriteLine("\nYou must input correct name of disc, try again");
                }
                if (name == "exit") break;

            } while (!isCorrect);

            return name;
        }

        static string NameOfFile(string nameDisk, bool flag)
        {
            string not = flag ? "" : " not";

            bool isCorrect;
            string name;

            do
            {
                isCorrect = true;

                name = Console.ReadLine();
                if (Comp.disk[nameDisk].file.ContainsKey(name) == flag)
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| Disk {nameDisk}");
                    Comp.disk[nameDisk].Print();
                    Console.WriteLine($"\nThis file is{not} exists, try again");
                }
                if (name.Length == 0)
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| Disk {nameDisk}");
                    Comp.disk[nameDisk].Print();
                    Console.WriteLine("\nYou must input correct name of file, try again");
                }
                if (name == "exit") break;

            } while (!isCorrect);

            return name;
        }

        static string NameOfFile(File file, string nameFile, bool flag)
        {
            string not = flag ? "" : " not";

            bool isCorrect;
            string name;

            do
            {
                isCorrect = true;

                name = Console.ReadLine();
                if (file.catalog.ContainsKey(name) == flag)
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();
                    Console.WriteLine($"\nThis file is{not} exists, try again");
                }
                if (name.Length == 0)
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();
                    Console.WriteLine("\nYou must input correct name of file, try again");
                }
                if (name == "exit") break;

            } while (!isCorrect);

            return name;
        }

        static string NameOfMusic(File file, string nameFile, bool flag)
        {
            string not = flag ? "" : " not";

            bool isCorrect;
            string name;

            do
            {
                isCorrect = true;

                name = Console.ReadLine();
                if (file.catalog.ContainsKey(name) == flag)
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();
                    Console.WriteLine($"\nThis music is{not} exists, try again");
                }
                if (name.Length == 0 || !name.EndsWith(".mp3"))
                {
                    isCorrect = false;
                    Console.Clear();
                    Console.WriteLine($"| File {nameFile}");
                    file.Print();
                    Console.WriteLine("\nYou must input correct name of music, try again");
                }
                if (name == "exit") break;

            } while (!isCorrect);

            return name;
        }
    }
}
