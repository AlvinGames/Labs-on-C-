using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Data
    {
        public static bool LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                    user.Add(reader.ReadLine());

                reader.Close();
                file.Close();

                return true;
            }
            else
            {
                Console.WriteLine("the file \"{0}\" is not found", fileName);
                return false;
            }
        }
        public static bool IsRegisterred(string userLogin)
        {
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].login == userLogin)
                {
                    currentUser = i;
                    return true;
                }
            }
            return false;
        }
        public static void Registration()
        {
            Console.Write("Input a surname: ");
            string surname = Console.ReadLine().Replace(" ", "");

            Console.Write("Input a login: ");
            string login = Logined();

            Console.Write("Input a password: ");
            string password = Console.ReadLine().Replace(" ", "");

            Date currentDate = DateTime.Now.ToString().Split(' ')[0];

            user.Add(new User(surname, login, password, currentDate[90]));

            if (!File.Exists("data.txt")) File.Create("data.txt");

            FileStream file = new FileStream("data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine(user[user.Count - 1]);

            writer.Close();
            file.Close();
        }
        public static bool CheckPassword(string password)
        {
            if (user[currentUser].password == password)
                return true;
            return false;
        }
        public static int Period()
        {
            Date currentDate = DateTime.Now.ToString().Split(' ')[0];

            return user[currentUser].date.Between(currentDate);
        }
        public static void ReplacePassword()
        {
            Console.Write("Input new password: ");
            user[currentUser].SetPassword();
            Date currentDate = DateTime.Now.ToString().Split(' ')[0];
            user[currentUser].date = currentDate[90];

            FileStream file = new FileStream("data.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            foreach (User data in user)
            {
                writer.WriteLine(data);
            }

            writer.Close();
            file.Close();
        }
        
        private static string Logined()
        {
            string login;
            bool coincidence = false;

            do
            {
                if (coincidence) Console.Write("This login exixst, input anouther: ");
                coincidence = false;
                login = Console.ReadLine().Replace(" ", "_");

                foreach (User data in user)
                {
                    if (data.login == login) coincidence = true;
                }

            } while (coincidence);

            return login;
        }

        public static string NickName
        {
            get
            {
                return user[currentUser].login;
            }
        }
        private static int currentUser = -1;
        public static List<User> user = new List<User>();
    }
}
