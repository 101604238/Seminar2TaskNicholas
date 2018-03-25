using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public class Hobo : Person
    {

        public Hobo(string pFName, string pLName, string pGender): base(pFName, pLName, pGender)
        {
            
        }

        public Hobo(string pGender): base(pGender)
        {

        }



        public override string Work()
        {
            return "Find A Place To Sleep";
        }
    }
}
