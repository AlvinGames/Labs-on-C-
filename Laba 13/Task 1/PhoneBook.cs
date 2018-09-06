using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class PhoneBook
    {
        public PhoneBook(string surename, string address, string phone)
        {
            this.surname = surename;
            this.address = address;
            this.phone = phone;
        }

        public abstract void Print();
        public bool Search(string surname)
        {
            if (this.surname == surname) return true;
            return false;
        }
        public bool SearchPhone(string phone)
        {
            if (this.phone == phone) return true;
            return false;
        }

        public string surname;
        public string address;
        public string phone;        
    }
}
