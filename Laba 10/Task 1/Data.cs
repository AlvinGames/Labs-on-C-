using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Date
    {
        public Date(int day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return string.Concat(day.ToString(), " ", month, " ", year.ToString());
        }

        public int day;
        public string month;
        public int year;
    }

    class Data
    {
        public void LoadToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                writer.WriteLine($"Фамилия: {surname}");
                writer.WriteLine($"Имя: {name}");
                writer.WriteLine($"Отчество: {middleName}");
                writer.WriteLine($"Пол: {gender}");
                writer.WriteLine($"Дата рождения: {date.ToString()}");
                writer.WriteLine($"Адрес проживания: {address}");
                writer.WriteLine($"Адрес электронной почты: {email}");
                writer.WriteLine("Мобильный телефон: {0} {1}", mobileOperator, mobilePhone);

                string exp = "";
                switch (experience)
                {
                    case 1:
                        exp = "Прежде не работал";
                        break;
                    case 2:
                        exp = "Меньше 1 года";
                        break;
                    case 3:
                        exp = "От 1 года до 5";
                        break;
                    case 4:
                        exp = "От 5 до 9 лет";
                        break;
                    case 5:
                        exp = "10 лет и больше";
                        break;
                    default:
                        exp = "Error";
                        break;
                }
                writer.WriteLine($"Опыт работы: {exp}");

                string graph = "";
                switch (graphic)
                {
                    case 1:
                        graph = "Полная занятость";
                        break;
                    case 2:
                        graph = "Частичная занятость";
                        break;
                    case 3:
                        graph = "Работа на дому";
                        break;
                    case 4:
                        graph = "Посменная работа";
                        break;
                    default:
                        graph = "Error";
                        break;
                }
                writer.WriteLine($"Предпочитаемый график работы: {graph}");

                if (transport) writer.WriteLine("Личный транспорт имеется");
                else writer.WriteLine("Личный транспорт не имеется");

                if (certificate) writer.WriteLine($"Водительское удостоверение имеется категории{category}");
                else writer.WriteLine("Водительское удостоверение не имеется");
                writer.WriteLine("Объём заработной платы от {0} до {1}", minSalary, maxSalary);
                writer.Write("Краткое резюме: ");

                if (resume == "") writer.WriteLine("отсутствует");
                else writer.WriteLine($"\n{resume}");

                writer.WriteLine();

                writer.Close();
                file.Close();
            }
            else File.Create(fileName);
        }

        public string surname;
        public string name;        
        public string middleName;

        public char gender;
        public Date date;
        public string address;

        public string email;
        public string mobileOperator;
        public string mobilePhone;

        public int experience;
        public int graphic;

        public bool transport;
        public bool certificate;
        public string category;

        public int minSalary;
        public int maxSalary;

        public string resume;
    }
}
