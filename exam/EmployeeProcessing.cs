using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace exam
{
    public class EmployeeProcessing: Worker
    {
        public void FromID(int id)
        {
            if (id == ID)
            {
                PrintS();
            }
        }

        public void SerializeS(Worker worker)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Worker));


                using (FileStream fs = new FileStream($"Worker{ID}.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, worker);

                    Console.WriteLine("Object Serialization");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error  Serialization");
            }
        }

        public void DeserializeS(Worker worker)
        {

            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Worker));
                using (FileStream fs = new FileStream($"worker{ID}.xml", FileMode.OpenOrCreate))
                {
                    Worker ChangeWorker = (Worker)formatter.Deserialize(fs);

                    Console.WriteLine("Success Deserialization");
                    ChangeWorker.PrintS();
                    ChangeSotr(ChangeWorker);

                }

            }
            catch (Exception)
            {

                Console.WriteLine("Error  Deserialization");
            }

        }


        void ChangeSotr(Worker change)
        {
            Console.WriteLine("Enter the FIO");
            change.NameWorker = Console.ReadLine();
            Console.WriteLine("Enter the age");
            change.Age = Console.Read();
            Console.WriteLine("Enter the Department");
            change.Fillial = Console.ReadLine();
            Console.WriteLine("Enter the Position");
            change.Position = Console.ReadLine();
            SerializeS(change);
        }

        public void SerializeAll(List<Worker> workers)
        {
            try
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<Worker>));
                StringWriter stringWriter = new StringWriter();
                serialiser.Serialize(stringWriter, workers);
                string xml = stringWriter.ToString();
                Console.WriteLine(xml);
                stringWriter.Close();

            }
            catch (Exception)
            {

                Console.WriteLine("Error  Serialization");
            }
        }

        public Worker AddWorkers()
        {
            Worker newworker = new Worker();
            Console.WriteLine("Enter the FIO");
            newworker.NameWorker = Console.ReadLine();
            Console.WriteLine("Enter the ID");
            newworker.ID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age");
            newworker.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Department");
            newworker.Fillial = Console.ReadLine();
            Console.WriteLine("Enter the Position");
            newworker.Position = Console.ReadLine();
            return newworker;
        }

        public Worker removeWorker(List<Worker> list)
        {
            Console.WriteLine("Enter ID of worker who was dismissed");
            int id = Int32.Parse(Console.ReadLine());
            foreach (var item in list)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }

        public Worker FindS(List<Worker> list)
        {
            Console.WriteLine("Enter ID of worker who want to know");
            string name = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.NameWorker.Contains(name))
                    return item;
            }
            return null;
        }

       
    }
}
