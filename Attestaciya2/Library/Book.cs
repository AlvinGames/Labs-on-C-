using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : IEquatable<Book>
    {
        public Book()
        {
            Annotation = "";
        }

        public override string ToString()
        {
            return string.Concat(
                Author, " ",
                Name, " ",
                Year, " ",
                Publishing, " ",
                ImageName, " ",
                Category, " ",
                Subcategory, " ",
                Annotation);
        }
        public bool Equals(Book other)
        {
            if(other != null)
            {
                if (Author == other.Author &&
                    Name == other.Name &&
                    Year == other.Year &&
                    Publishing == other.Publishing &&
                    Category == other.Category &&
                    Subcategory == other.Subcategory &&
                    ImageName == other.ImageName)
                {
                    return true;
                }
                return false;

            }
            return false;
        }

        public static implicit operator Book(string str)
        {
            Book obj = new Book();
            string[] data = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (data.Length == 8)
            {
                obj.Author = data[0];
                obj.Name = data[1];
                obj.Year = Convert.ToInt32(data[2]);
                obj.Publishing = data[3];
                obj.ImageName = data[4];
                obj.Category = data[5];
                obj.Subcategory = data[6];
                obj.Annotation = data[7];

                return obj;
            }
            else if (data.Length == 7)
            {
                obj.Author = data[0];
                obj.Name = data[1];
                obj.Year = Convert.ToInt32(data[2]);
                obj.Publishing = data[3];
                obj.ImageName = data[4];
                obj.Category = data[5];
                obj.Subcategory = data[6];
                obj.Annotation = "";

                return obj;
            }

            return null;
        }
        public static implicit operator string(Book obj)
        {
            return string.Concat(
                obj.Author,         " ",
                obj.Name,           " ",
                obj.Year,           " ",
                obj.Publishing,     " ",
                obj.ImageName,      " ",
                obj.Category,       " ",
                obj.Subcategory,    " ",
                obj.Annotation);
        }

        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Publishing { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string ImageName { get; set; }
        public string Annotation { get; set; }
    }
}
