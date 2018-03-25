using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercises_Class_LIbrary
{
    public abstract class Person
    {
        private string Fname { get; set; }
        private string Gender { get; set; }
        private string Lname { get; set; }


        public Person(string pFName, string pLName, string pGender)
        {

            if (pGender == "M" || pGender == "F")
            {
                Fname = pFName;
                Lname = pLName;
                Gender = pGender;
            }
            else
            {
                throw new Exception("Invalid Gender Passed to Person Constructor");
            }
        }

        public Person(string pGender)
        {
            if (pGender == "M" || pGender == "F")
            {
                Gender = pGender;
            }
            else
            {
                throw new Exception("Invalid Gender Passed to Person Constructor");
            }

            if(pGender == "M")
            {
                Fname = "John";
                Lname = "Doe";
            }
            else
            {
                Fname = "Jane";
                Lname = "Doe";
            }
        }

        public string GetGender()
        {
            return Gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public abstract string Work();     
    }
}
