using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public class SecondaryTeacher : Teacher
    {

        public SecondaryTeacher(int pStaffID, string pFName, string pLName, string pGender) : base(pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachHighSchool();
        }

        public override string GetOccupation()
        {
            return "Secondary Teacher";
        }

    }
}
