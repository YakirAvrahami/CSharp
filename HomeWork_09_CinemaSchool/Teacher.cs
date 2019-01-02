using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Teacher:Person
    {
        private string profession_Teacher;
        public string Profession_Teacher
        {
            get { return profession_Teacher; }
            set { profession_Teacher = value; }
        }

        private int seniority_Teacher;
        public int Seniority_Teacher
        {
            get { return seniority_Teacher; }
            set { seniority_Teacher = value; }
        }

        public Teacher(string profession_Teacher, int seniority_Teacher, string full_Name_Person, int age_Person, string id_Person, bool male_Person) : base(full_Name_Person, age_Person, id_Person, male_Person)
        {
            Profession_Teacher = profession_Teacher;
            Seniority_Teacher = seniority_Teacher;
        }

        public string Print_Teacher()
        {
            return $"Profession_Teacher: {Profession_Teacher}.\nSeniority_Teacher: {Seniority_Teacher}.\n{base.Print_Person()}";
        }
    }
}
