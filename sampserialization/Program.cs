using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace sampserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SHUKKALI\source\repos\sampserialization\sampserialization\sampserialization.txt";
            Employee emp = new Employee(1, "shree", 25000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("File created ");
            Console.ReadKey();



            //string path = @"C:\Users\SHUKKALI\source\repos\sampserialization\sampserialization\sampserialization.txt";
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //Employee emp = (Employee)bf.Deserialize(stream);
            //Console.WriteLine(emp.empSalary);
            //stream.Close();
        }
    }
    }

