using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Bankaccount<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public double Summa { get; set; }

        //public Bankaccount <T> (T num, string name, double summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Summa = summa;
        //}

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(Num, typeof(T));

            Console.WriteLine("Введите имя владельца");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Summa = Convert.ToDouble(Console.ReadLine());
        }
    }
}
    
