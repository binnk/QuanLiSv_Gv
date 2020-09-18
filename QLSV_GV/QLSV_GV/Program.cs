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
        static void Main(string[] args)
        {
            string filePath = @"D:\HK3\LTTQ\BT2\data.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<Student> listStudents = new List<Student>();

            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');

                float[] points = new float[3];
                for (int i=0;i < 3; i++)
                {
                    points[i] = Convert.ToSingle(tokens[i + 2]);
                }

                Student student = new Student(tokens[0], tokens[1], points[0], points[1], points[2]);
                listStudents.Add(student);
          
            }

            foreach(var student in listStudents)
            {
                student.showInfo();
            }
           
            Console.ReadLine();
        }
    }
}
