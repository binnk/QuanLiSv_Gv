using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GV
{
    public class Student: Person
    {
        private string idNumber;
        private float pointMath;
        private float pointLit;
        private float pointEng;

        //Get/Set method
        public override string IdNumber { get => idNumber; set => idNumber = value; }
        public float PointMath { get => pointMath; set => pointMath = value; }
        public float PointLit { get => pointLit; set => pointLit = value; }
        public float PointEng { get => pointEng; set => pointEng = value; }

        //Constructor
        public Student()
        {
            idNumber = "SVx";
            pointMath = pointLit = PointEng = 0;
        }

        public Student(string newID, string newName,float newPMath, float newPLit,float newPEng)
        {
            idNumber = newID;
            fullName = newName;
            pointMath = newPMath;
            pointLit = newPLit;
            pointEng = newPEng;               
        }

        //Method

        public override void showInfo()
        {
            Console.Write($"{idNumber}\t");
            base.showInfo();
            Console.WriteLine($"{pointMath}\t{PointLit}\t{PointEng}");
        }
    }
}
