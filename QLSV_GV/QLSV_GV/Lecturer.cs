using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GV
{
    public class Lecturer : Person
    {
        private string idNumber;
        private string faculty;

        //  get/set method
        public override string IdNumber { get => idNumber; set => idNumber = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        //  Constructor

        public Lecturer()
        {
            idNumber = "GVx";
            faculty = "none";
        }
        public Lecturer(string newId, string newName, string newFaculty)
        {
            this.idNumber = newId;
            this.fullName = newName;
            this.faculty = newFaculty;
        }

        public override void showInfo()
        {
            Console.WriteLine($"{idNumber}\t");
            base.showInfo();
            Console.WriteLine(faculty);
        }

    }
}
