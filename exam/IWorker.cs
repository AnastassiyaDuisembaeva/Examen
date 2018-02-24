using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public interface IWorker
    {
        string NameWorker { get; set; }
        int ID { get; set; }
        string Position { get; set; }
        int Age { get; set; }
        string Fillial { get; set; }
    }
}
