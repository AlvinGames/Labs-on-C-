using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Data
    {
        public static bool LoadFromFile(string fileName)
        {
            if(File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while(!reader.EndOfStream)
                {
                    Book item = reader.ReadLine();
                    if(item != null)
                    {
                        AddBook(item);
                    }
                }

                reader.Close();
                file.Close();

                return true;
            }
            return false;
        }
        public static bool RecordToFile(string fileName)
        {
            if(File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                foreach (Book item in Lib)
                {
                    writer.WriteLine(item);
                }

                writer.Close();
                file.Close();

                return true;
            }
            return false;
        }

        public static void AddBook(Book obj)
        {
            if (Search) SearchLib.Add(obj);
            else Lib.Add(obj);
        }
        public static bool RemoveBook(Book obj)
        {
            if (Search) return SearchLib.Remove(obj);
            return Lib.Remove(obj);
        }
        public static void RemoveBook(int index)
        {
            if (Search) SearchLib.RemoveAt(index);
            else Lib.RemoveAt(index);
        }
        public static bool ContainsBook(Book obj)
        {
            if (Search) return SearchLib.Contains(obj);
            return Lib.Contains(obj);
        }
        
        public static Book Book(int index)
        {
            if (Search) return SearchLib[index];
            return Lib[index];
        }

        public static void Reset()
        {
            if (Search) SearchLib.Clear();
            else Lib.Clear();
        }

        public static bool Search { get; set; } = false;

        public static string FileName { get; } = "data.txt";
        public static List<Book> Lib { get; private set; } = new List<Book>();
        public static List<Book> SearchLib { get; } = new List<Book>();
    }
}
