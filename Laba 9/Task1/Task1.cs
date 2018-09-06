using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//╔══╗─╔╗─╔══╦══╗╔══╗
//║╔╗║─║║─║╔╗║╔╗║║╔╗║
//║╚╝║─║║─║╚╝║╚╝╚╣╚╝║
//╚═╗║─║║─║╔╗║╔═╗║╔╗║
//╔═╝║─║╚═╣║║║╚═╝║║║║
//╚══╝─╚══╩╝╚╩═══╩╝╚╝
//╔════╦══╦══╦╗╔══╗─╔╗
//╚═╗╔═╣╔╗║╔═╣║║╔═╝╔╝║
//──║║─║╚╝║╚═╣╚╝║──╚╗║
//──║║─║╔╗╠═╗║╔╗║───║║
//──║║─║║║╠═╝║║║╚═╗─║║
//──╚╝─╚╝╚╩══╩╝╚══╝─╚╝

namespace Task1
{
    class Program
    {
        enum Operator { MTS, Velcom, None };

        static void Main(string[] args)
        {
            //─╔╗─╔══╦════╦═══╦═══╗
            //╔╝║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╚╗║─║╚═╗─║║─║╚══╣╚═╝║
            //─║║─╚═╗║─║║─║╔══╣╔══╝
            //─║║─╔═╝║─║║─║╚══╣║
            //─╚╝─╚══╝─╚╝─╚═══╩╝
            #region Step1

            FileStream file = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            String text = reader.ReadToEnd();

            reader.Close();
            file.Close();

            #endregion

            //╔══╗─╔══╦════╦═══╦═══╗
            //╚═╗║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╔═╝║─║╚═╗─║║─║╚══╣╚═╝║
            //║╔═╝─╚═╗║─║║─║╔══╣╔══╝
            //║╚═╗─╔═╝║─║║─║╚══╣║
            //╚══╝─╚══╝─╚╝─╚═══╩╝
            #region Step2

            char[] simbol = { ' ', ',', '.', '\n' };

            String[] str = text.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            List<string> number = new List<string>();



            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].StartsWith("+"))
                {
                    number.Add(str[i].Trim().Remove(0, 1));
                }
                for (char j = '0'; j <= '9'; j++)
                {
                    if (str[i].StartsWith(j.ToString()))
                    {
                        number.Add(str[i].Trim());
                    }
                }
            }

            #endregion

            //╔══╗─╔══╦════╦═══╦═══╗
            //╚═╗║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╔═╝║─║╚═╗─║║─║╚══╣╚═╝║
            //╚═╗║─╚═╗║─║║─║╔══╣╔══╝
            //╔═╝║─╔═╝║─║║─║╚══╣║
            //╚══╝─╚══╝─╚╝─╚═══╩╝
            #region Step3

            //XXXX-XX-XX-XXX    lengt = 14 4 7 10
            //XXX-XX-XX-XX-XXX  lengt = 16 3 6 9 12
            //XXX-XXX           lengt = 7 3
            //XX-XX-XX          lengt = 8 2 5
            //XXX-XX-XX         lengt = 9 3 6
            
            for (int i = 0; i < number.Count; i++)
            {
                char[] num = number[i].ToCharArray();

                Operator mobile = Operator.None;

                switch (num.Length)
                {
                    case 7:
                        if (num[3] == '-')
                        {
                            bool isNumber = true;
                            for (int j = 0; j < num.Length; j++)
                            {
                                if (j == 3) continue;
                                if (!(num[j] >= '0' && num[j] <= '9')) isNumber = false;
                            }
                            if (isNumber) Console.WriteLine(num);
                        }
                        break;

                    case 8:
                        if (num[2] == '-' && num[5] == '-')
                        {
                            bool isNumber = true;
                            for (int j = 0; j < num.Length; j++)
                            {
                                if (j == 2 || j == 5) continue;
                                if (!(num[j] >= '0' && num[j] <= '9')) isNumber = false;
                            }
                            if (isNumber) Console.WriteLine(num);
                        }
                        break;

                    case 9:
                        if (num[3] == '-' && num[6] == '-')
                        {
                            bool isNumber = true;
                            for (int j = 0; j < num.Length; j++)
                            {
                                if (j == 3 || j == 6) continue;
                                if (!(num[j] >= '0' && num[j] <= '9')) isNumber = false;
                            }
                            if (isNumber) Console.WriteLine(num);
                        }
                        break;

                    case 14:
                        if (num[4] == '-' && num[7] == '-' && num[10] == '-')
                        {
                            
                            bool isNumber = true;
                            for (int j = 0; j < num.Length; j++)
                            {
                                if (j == 4 || j == 7 || j == 10) continue;
                                if (!(num[j] >= '0' && num[j] <= '9')) isNumber = false;
                            }
                            if (isNumber)
                            {
                                Console.Write(num);

                                if (num[2] == '4' && num[3] == '4')
                                {
                                    mobile = Operator.Velcom;
                                }
                                else if(num[2] == '3' && num[3] == '3')
                                {
                                    mobile = Operator.MTS;
                                }
                                else if(num[2] == '2' && num[3] == '9')
                                {
                                    if (num[5] == '1' || num[5] == '3' || num[5] == '6' || num[5] == '9')
                                        mobile = Operator.Velcom;
                                    else mobile = Operator.MTS;
                                }
                                
                                Console.WriteLine(" {0}", mobile);
                            }
                        }
                        break;

                    case 16:
                        if (num[3] == '-' && num[6] == '-' && num[9] == '-' && num[12] == '-')
                        {
                            bool isNumber = true;
                            for (int j = 0; j < num.Length; j++)
                            {
                                if (j == 3 || j == 6 || j == 9 || j == 12) continue;
                                if (!(num[j] >= '0' && num[j] <= '9')) isNumber = false;
                            }
                            if (isNumber)
                            {
                                Console.Write(num);

                                if (num[4] == '4' && num[5] == '4')
                                {
                                    mobile = Operator.Velcom;
                                }
                                else if (num[4] == '3' && num[5] == '3')
                                {
                                    mobile = Operator.MTS;
                                }
                                else if (num[4] == '2' && num[5] == '9')
                                {
                                    if (num[7] == '1' || num[7] == '3' || num[7] == '6' || num[7] == '9')
                                        mobile = Operator.Velcom;
                                    else mobile = Operator.MTS;
                                }

                                Console.WriteLine(" {0}", mobile);
                            }
                        }
                        break;

                    default:    /*Nothing*/
                        break;
                }
            }

            #endregion

        }
    }
}
