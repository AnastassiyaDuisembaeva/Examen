using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    [Serializable]
    public class Worker: IWorker
    {
        public string NameWorker { get; set; }
        public int ID { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Fillial { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public Worker() { }
        public Worker(string name, int id, int age, string position, string fillial, string LoginW, int PasswordW)
        {
            NameWorker = name;
            ID = id;
            Position = position;
            Age = age;
            Fillial = fillial;
            Login = LoginW;
            Password = PasswordW;
        }
        public void PrintS()
        {
            Console.WriteLine($"Workers name: {NameWorker}, ID: {ID}  Position:  {Position }, Age: {Age}, Fillial Name {Fillial} ");
        }
    }
}
