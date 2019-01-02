using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Student : Person
    {
        private string school_Place_Student;
        public string School_Place_Student
        {
            get { return school_Place_Student; }
            set { school_Place_Student = value; }
        }

        private string profession_Student;
        public string Profession_Student
        {
            get { return profession_Student; }
            set { profession_Student = value; }
        }

        public Student(string school_Place_Student, string profession_Student, string full_Name_Person, int age_Person, string id_Person, bool male_Person) : base(full_Name_Person, age_Person, id_Person, male_Person)
        {
            School_Place_Student = school_Place_Student;
            Profession_Student = profession_Student;
        }

        public string Print_Studets()
        {
            return $"School_Place_Student: {School_Place_Student}.\nProfession_Student: {Profession_Student}.\n{base.Print_Person()}";
        }

    }
}
