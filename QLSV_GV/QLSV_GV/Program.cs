using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QLSV_GV
{
    class Program
    {
        enum Command
        {
            find,
            add,
            top,
            export
        }

        static void findByIdNumber(List<Person> people, string idToFind)
        {
            
            var idNumbers = from person in people
                            where person.IdNumber == idToFind
                            select person;

            foreach (var person in idNumbers)
                person.showInfo();
        }

        static void findByName(List<Person> people, string nameToFind)
        {
            var names = from person in people
                            where person.FullName == nameToFind
                            select person;

            foreach (var person in names)
                person.showInfo();
        }

        static void Main(string[] args)
        {
            string filePath = @"D:\HK3\LTTQ\BT2\data.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<Person> people = new List<Person>();
            

            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');

                float[] points = new float[3];
                for (int i=0;i < 3; i++)
                {
                    points[i] = Convert.ToSingle(tokens[i + 2]);
                }

                Student student = new Student(tokens[0], tokens[1], points[0], points[1], points[2]);
                people.Add(student);
          
            }

            findByIdNumber(people, "1237");
            findByName(people, "Nguyen Van A");

            Console.ReadLine();
        }
    }
}
