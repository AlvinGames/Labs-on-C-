using System;
using System.Linq;

namespace Task_1
{
    class Array
    {
        //constructs
        public Array() : this(1)
        { }
        public Array(int size)
        {
            this.size = size;
            IntArray = new int[this.size];
            for (int i = 0; i < this.size; i++) { IntArray[i] = 0; }
        }
        public Array(int size, int a, int b)
        {
            Random obj = new Random();
            this.size = size;

            for (int i = 0; i < this.size; i++) { IntArray[i] = obj.Next(a, b + 1); }
        }

        //methods
        public void Input()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("mas[{0}]=", i);
                input(out IntArray[i]);
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", IntArray[i]);
            }
        }
        public void Sort()
        {
            for (int i = 0; i < size; i++)
            {
                int min = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (IntArray[j] < IntArray[min]) min = j;
                }
                swap(ref IntArray[i], ref IntArray[min]);
            }
        }

        //indexer
        public int this[int n]
        {
            get
            {
                if (n < 0) n = 0;
                else if (n >= size) n = size - 1;
                return IntArray[n];
            }
            private set
            {
                if (n < 0) n = 0;
                else if (n >= size) n = size - 1;
                IntArray[n] = value;
            }
        }

        //operators
        public static Array operator ++(Array obj)
        {
            for (int i = 0; i < obj.Size; i++)
            {
                obj[i]++;
            }

            return obj;
        }
        public static Array operator --(Array obj)
        {
            for (int i = 0; i < obj.Size; i++)
            {
                obj[i]--;
            }

            return obj;
        }
        public static Boolean operator !(Array obj)
        {
            bool sort = false;
            for (int i = 1; i < obj.Size; i++)
            {
                if(obj[i] < obj[i-1]) { sort = true; break; }
            }
            return sort;
        }
        public static Array operator *(Array obj, int num)
        {
            for (int i = 0; i < obj.Size; i++)
            {
                obj[i] *= num;
            }
            return obj;
        }
        public static Array operator *(int num, Array obj)
        {
            for (int i = 0; i < obj.Size; i++)
            {
                obj[i] *= num;
            }
            return obj;
        }
        public static implicit operator Array(int[] mas)
        {
            Array obj = new Array(mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                obj[i] = mas[i];
            }
            return obj;
        }
        public static implicit operator int[](Array obj)
        {
            int[] mas = new int[obj.Size];
            for (int i = 0; i < obj.Size; i++)
            {
                mas[i] = obj[i];
            }
            return mas;
        }

        //property
        public int Size
        {
            get { return size; }
        }
        public int Multiply
        {
            set
            {
                for (int i = 0; i < size; i++)
                {
                    IntArray[i] *= value;
                }
            }
        }
        public int Max
        {
            get { return IntArray.Max(); }
        }
        public int Min
        {
            get { return IntArray.Min(); }
        }
        public int Sum
        {
            get { return IntArray.Sum(); }
        }

        private void input(out int number)
        {
            bool Number = true;

            do
            {
                if (!Number) { Console.Write("It's not a number, try again: "); }
                Number = int.TryParse(Console.ReadLine(), out number);
            } while (!Number);

        }
        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private int[] IntArray;
        private int size;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 3, 2 };
            Array obj = mas;

            Console.WriteLine(obj.Max);

        }
    }
}
