using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class BaseMenu
    {
        int choice;
        string ans;

        public int Choice
        {
            get { return choice; }
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t======БАЗОВОЕ МЕНЮ=======");
            Console.WriteLine("\t Система тестирования знаний");
            Console.WriteLine("\t Ваш выбор:");
            Console.WriteLine("\t 1-Меню Admin");
            Console.WriteLine("\t 2-Меню Teacher");
            Console.WriteLine("\t 3-Меню Student");
            Console.WriteLine("\t=============================");
            Console.WriteLine("\t Выберите нужное действие: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        public void Finish()
        {
            Console.WriteLine("\n Программа завершена\n");
        }
        public bool AllowContinue()
        {
            Console.WriteLine("\n > Продолжать (y/n)? - ");
            ans = Console.ReadLine();
            return (ans == "y");
        }
    }
}
