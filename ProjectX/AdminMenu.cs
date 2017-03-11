using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class AdminMenu
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
            Console.WriteLine("\t======МЕНЮ АДМИНИСТРАТОРА=======");
            Console.WriteLine("\t Система тестирования знаний");
            Console.WriteLine("\t Введите ваш логин и пароль");
            Console.WriteLine("\t Login: ");
            Console.WriteLine("\t Password: ");
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
