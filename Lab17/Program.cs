using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер счета");
            //string num = Console.ReadLine();
            //Console.WriteLine("Введите имя владельца");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите баланс");
            //double summa = Convert.ToDouble(Console.ReadLine());
            //Bankaccount<int> bankaccount1 = new Bankaccount<int>(num, name, summa);
            //Console.WriteLine(bankaccount1.GetInfo());

            //Console.WriteLine("Введите номер счета");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите имя владельца");
            //name = Console.ReadLine();
            //Console.WriteLine("Введите баланс");
            //summa = Convert.ToDouble(Console.ReadLine());
            //Bankaccount<string> bankaccount2 = new Bankaccount<string>(num, name, summa);
            //Console.WriteLine(bankaccount1.GetInfo());

            Bankaccount<int> bankaccount1 = new Bankaccount<int>();
            bankaccount1.Input();
            Console.WriteLine(bankaccount1.GetInfo());

            Bankaccount<string> bankaccount2 = new Bankaccount<string>();
            bankaccount2.Input();
            Console.WriteLine(bankaccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
    
