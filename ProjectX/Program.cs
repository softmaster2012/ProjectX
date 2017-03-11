using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMenu bm = new BaseMenu();
            AdminMenu am = new AdminMenu();
            do
            {
                bm.Display();
                switch (bm.Choice)
                {
                    case 1:
                        am.Display();
                        break;
                    default:
                        break;
                }
            }
            while (bm.AllowContinue());

            bm.Finish();
        }
    }
}
