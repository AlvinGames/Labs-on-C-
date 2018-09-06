using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//╔╗─╔══╦══╗╔══╗──╔╦══╗
//║║─║╔╗║╔╗║║╔╗║─╔╝╠═╗║
//║║─║╚╝║╚╝╚╣╚╝║─╚╗╠═╝║
//║║─║╔╗║╔═╗║╔╗║──║║╔═╝
//║╚═╣║║║╚═╝║║║║──║║╚═╗
//╚══╩╝╚╩═══╩╝╚╝──╚╩══╝
//╔════╦══╦══╦╗╔══╗╔══╗
//╚═╗╔═╣╔╗║╔═╣║║╔═╝╚═╗║
//──║║─║╚╝║╚═╣╚╝║──╔═╝║
//──║║─║╔╗╠═╗║╔╗║──║╔═╝
//──║║─║║║╠═╝║║║╚═╗║╚═╗
//──╚╝─╚╝╚╩══╩╝╚══╝╚══╝
//╔╗╔╦══╦╗╔╗─╔╗─╔══╦╗─╔╦═══╦══╗───╔═╗
//║║║║╔═╣║║║─║║─╚╗╔╣╚═╝║╔══╣╔═╝─╔╗╚╗║
//║╚╝║╚═╣╚╝║─║║──║║║╔╗─║╚══╣╚═╗─╚╝─║║
//╚═╗║╔╗╠═╗║─║║──║║║║╚╗║╔══╩═╗║─╔╗─║║
//──║║╚╝║─║║─║╚═╦╝╚╣║─║║╚══╦═╝║─╚╝╔╝║
//──╚╩══╝─╚╝─╚══╩══╩╝─╚╩═══╩══╝───╚═╝

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Data.LoadFromFile("data.txt"))
            {
                Console.Write("Login: ");
                string login = Console.ReadLine().Replace(" ", "");

                if (Data.IsRegisterred(login))
                {
                    Console.Write("Password: ");

                    string password;
                    bool coincidence = false;
                    do
                    {
                        if (coincidence) Console.Write("Wrong password, try again: ");
                        password = Console.ReadLine().Replace(" ", "");

                        coincidence = !Data.CheckPassword(password);

                    } while (coincidence);

                    int countDays = Data.Period();

                    if (countDays <= 0)
                    {
                        Console.WriteLine("\nPeriod of validity of the password has expired!");
                        Data.ReplacePassword();
                        Console.WriteLine("The password is successfully changed");
                    }
                    else if (countDays < 14)
                    {
                        Console.WriteLine("\nPeriod of validity of the password expires in {0} days", countDays);
                    }
                    else
                    {
                        Console.WriteLine("Welcom {0} :)", Data.NickName);
                    }
                }
                else
                {
                    Console.WriteLine("\nThis user is absent. You must registered!");
                    Data.Registration();
                    Console.WriteLine("\nRegistration forgave successfully. Have a nice day :)");
                }
            }
        }

    }
}
