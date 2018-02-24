using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class Access
    {
        public void TryCheck(Worker w)
        {
            int num = 0;
            string login="";
            do {
                Console.WriteLine("Enter Login");
                login = Console.ReadLine();
            } while (login != w.Login);
            

            do
            {
                Console.WriteLine("Enter Password");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != w.Password);

            Console.Clear();
            Console.WriteLine("Login and Password entered successfully");

        }
    }
}
