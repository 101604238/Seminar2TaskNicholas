using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public class SpecialNeedsTeacher : Teacher
    {

        public SpecialNeedsTeacher(int pStaffID, string pFName, string pLName, string pGender) : base(pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }

    }
}
