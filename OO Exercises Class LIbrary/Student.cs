using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public class Student : Person
    {
        private string StudentID { get; set; }

        

        public Student(string pFName, string pLName, string pGender, string pStudentID) : base(pFName, pLName, pGender)
        {
            StudentID = pStudentID;
        }


        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }

    }
}
