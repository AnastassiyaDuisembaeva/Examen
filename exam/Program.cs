using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Aaron Adams", 1, 35, "Driving instructor", "Drivers", "AdamsA", 123));
            workers.Add(new Worker("Alexander Bernards", 2, 20, "Barman", "Staff", "BernardsA", 124));
            workers.Add(new Worker("Billy Jhones", 3, 26, "IT", "Programmer", "", 125));
            workers.Add(new Worker("Tanya Smith", 4, 31, "Model", "Foto Model Agency", "SmithT", 126));
            workers.Add(new Worker("Bruce Li", 5, 44, "Botanist", "Biology", "LiB", 127));
            Worker tempW = new Worker();
            Access a = new Access();
            workers.Sort(delegate (Worker w1, Worker w2)
            {
                return w1.ID.CompareTo(w2.ID);
            });

            EmployeeProcessing processing = new EmployeeProcessing();

              Console.WriteLine("List of Workers");
               foreach (var item in workers)
               {
                   item.PrintS();
               }
               Console.WriteLine("Add Worker");
               workers.Add(processing.AddWorkers());

               Console.WriteLine("List of Workers");
               foreach (var item in workers)
               {
                   item.PrintS();
               }

               Console.WriteLine("Remove Worker");
               workers.Remove(processing.removeWorker(workers));

               Console.WriteLine("List of Workers");
               foreach (var item in workers)
               {
                   item.PrintS();
               }
               Console.WriteLine("Find Worker");
               processing.FindS(workers).PrintS();
            
          Console.WriteLine("Would you like to see information about employees?");
         Console.WriteLine("1 - Yes, 2 - No");
         int choise = Int32.Parse(Console.ReadLine());
         switch (choise)
         {
             case 1:
                 Console.WriteLine("Please log in!");
                    tempW = processing.FindS(workers);
                a.TryCheck(tempW);

                 Console.WriteLine(workers);
                 break;
             case 2:
                 Console.WriteLine("See you later!");
                 break;
             default:
                 Console.WriteLine("Not the right choice!");
                 break;

         }   
            Console.ReadLine();
        }
    }
    }

