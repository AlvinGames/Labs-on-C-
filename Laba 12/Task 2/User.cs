using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class User
    {
        //constructs
        public User(string surname, string login, string password, Date date)
        {
            this.surname = surname;
            this.login = login;
            this.password = password;
            this.date = date;
        }

        //methods
        public void Print()
        {
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Login: {0}", login);
            Console.WriteLine("Password: {0}", password);
            Console.WriteLine("Date: {0}", (string)date);
        }
        public void SetPassword()
        {
            string newPassword;
            bool coincidence = false;

            do
            {
                if (coincidence) Console.Write("This password exists, try again: ");
                newPassword = Console.ReadLine().Replace(" ", "");

                coincidence = newPassword == password;

            } while (coincidence);

            password = newPassword;
        }
        
        //operators
        public static implicit operator User(string sData)
        {
            string[] data = sData.Split(' ');

            string surname = data[0];
            string login = data[1];
            string password = data[2];
            Date date = data[3];

            return new User(surname, login, password, date);
        }
        public static implicit operator string(User user)
        {
            return user.surname + " " + user.login + " " + user.password + " " + user.date;
        }

        public string surname { get; private set; }
        public string login { get; private set; }
        public string password { get; private set; }
        public Date date { get; set; }
    }
}
