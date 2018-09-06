using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Date
    {
        //constructs
        public Date() : this(1, 1, 2011)
        { }
        public Date(uint day, uint month, uint year = 2011)
        {
            this.day = day;
            this.month = month;
            if (this.month == 0) { this.month = 12; this.year--; }
            this.year = year;

            if (this.day == 0) { this.day = 31; this.month--; }
            if (this.month == 0) { this.month = 12; this.year--; }

            if (this.day > 31)
            {
                this.month += this.day / 31;
                this.day %= 31;
                if (this.day == 0) { this.day = 31; this.month--; }
            }
            if (this.month > 12)
            {
                this.month %= 12;
                this.year++;
                if (this.month == 0) { this.month = 12; this.year--; }
            }
        }
        public Date(string sDate)
        {
            char[] simbol = { '.', ',', '/', ' ', '_', '-' };
            string[] date = sDate.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            day = Convert.ToUInt32(date[0]);
            month = Convert.ToUInt32(date[1]);
            year = Convert.ToUInt32(date[2]);
        }

        //methods
        public void Print()
        {
            string day = this.day.ToString();
            string month = this.month.ToString();
            string year = this.year.ToString();

            if (day.Length == 1) day = "0" + day;
            if (month.Length == 1) month = "0" + month;

            string date = String.Concat(day, "/", month, "/", year);
            Console.WriteLine(date);
        }
        public void PrintF()
        {
            string day = this.day.ToString();
            string month = "";
            switch (this.month)
            {
                case 1: month = "Январь"; break;
                case 2: month = "Февраль"; break;
                case 3: month = "Март"; break;
                case 4: month = "Апрель"; break;
                case 5: month = "Май"; break;
                case 6: month = "Июнь"; break;
                case 7: month = "Июль"; break;
                case 8: month = "Август"; break;
                case 9: month = "Сентябрь"; break;
                case 10: month = "Октябрь"; break;
                case 11: month = "Ноябрь"; break;
                case 12: month = "Декабрь"; break;
            }
            string year = this.year.ToString();

            if (day.Length == 1) day = "0" + day;

            string date = String.Concat(month, ",", day, ",", year);
            Console.WriteLine(date);
        }
        public void Printf()
        {
            string day = this.day.ToString();
            string month = "";
            switch (this.month)
            {
                case 1: month = "January"; break;
                case 2: month = "February"; break;
                case 3: month = "March"; break;
                case 4: month = "April"; break;
                case 5: month = "May"; break;
                case 6: month = "June"; break;
                case 7: month = "July"; break;
                case 8: month = "August"; break;
                case 9: month = "September"; break;
                case 10: month = "October"; break;
                case 11: month = "November"; break;
                case 12: month = "December"; break;
            }
            string year = this.year.ToString();

            if (day.Length == 1) day = "0" + day;

            string date = String.Concat(month, ",", day, ",", year);
            Console.WriteLine(date);
        }
        public Boolean IsLast()
        {
            return day == 31;
        }
        public Date NextDay()
        {
            return new Date(day + 1, month, year);
        }
        public Date PrevDay()
        {
            return new Date(day - 1, month, year);
        }
        public Date After(uint day)
        {
            return new Date(this.day + day, month, year);
        }
        public int Between(Date date)
        {
            return (int)(day + month * 31) - (int)(date.day + date.month * 31) + ((int)year - (int)date.year) * 12 * 31;
        }

        //indexer
        public Date this[int i]
        {
            get
            {
                int countDays = (int)(this.day + (this.month - 1) * 31) + i;
                while (countDays < 0)
                {
                    countDays += 372;
                    year--;
                }

                uint day = (uint)(countDays % 31);
                uint month = (uint)(countDays / 31) + 1;

                return new Date(day, month, year);
            }
        }

        //operators
        public static bool operator !(Date obj)
        {
            return obj.day == 31 ? false : true;
        }
        public static bool operator true(Date obj)
        {
            return obj.month == 1;
        }
        ////????????????????????????????????????????
        public static bool operator false(Date obj)
        {
            return obj.month != 1;
        }
        //????????????????????????????????????????
        public static bool operator &(Date obj, Date obj0)
        {
            return (obj.day == obj0.day && obj.month == obj0.month && obj.year == obj0.year);
        }
        public static implicit operator Date(string sDate)
        {
            char[] simbol = { '.', ',', '/', ' ', '_', '-' };
            string[] date = sDate.Split(simbol, StringSplitOptions.RemoveEmptyEntries);

            uint day = Convert.ToUInt32(date[0]);
            uint month = Convert.ToUInt32(date[1]);
            uint year = Convert.ToUInt32(date[2]);

            return new Date(day, month, year);
        }
        public static implicit operator string(Date obj)
        {
            string day = obj.day.ToString();
            string month = obj.month.ToString();
            string year = obj.year.ToString();

            if (day.Length == 1) day = "0" + day;
            if (month.Length == 1) month = "0" + month;

            return String.Concat(day, "/", month, "/", year);
        }
        //public static implicit operator bool(Date obj)//???
        //{
        //    return obj.month == 1;
        //}

        private uint day;
        private uint month;
        private uint year;
    }
}
