using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QLSV_GV
{
    public class Person
    {
        protected string fullName;
        public string FullName { get => fullName; set => fullName = value; }

        public virtual void showInfo()
        {
            Console.Write(fullName+"\t");
        }

        //constructor
        public Person(string newFullName)
        {
            this.fullName = newFullName;
        }
        public Person()
        {
            this.fullName = "Unknown";
        }
    }
}
