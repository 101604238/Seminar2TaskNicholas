using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public class Teacher : Person
    {
        private int StaffID { get; set; }
        protected ITeach TeachBehaviour;
        

        public Teacher(int pStaffID, string pFName, string pLName, string pGender): base(pFName, pLName, pGender)
        {

        }


        public override string GetOccupation()
        {
            return "Teacher";
        }

        public override string Work()
        {
            return "Teach, teach, teach, and stuff";
        }
    }
}
