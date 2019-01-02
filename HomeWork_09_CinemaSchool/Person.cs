using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Person
    {
        private string full_Name_Person;
        public string Full_Name_Person
        {
            get { return full_Name_Person; }
            set { full_Name_Person = value; }
        }

        private int age_Person;
        public int Age_Person
        {
            get { return age_Person; }
            set
            {
                if (value >=0 && value <=120)
                    age_Person = value;
            }
        }

        private string id_Person;
        public string Id_Person
        {
            get { return id_Person; }
            set
            {
                int num = Convert.ToInt32(value.Length);
                if (num==9)
                    id_Person = value;
            }
        }

        private bool male_Person;
        public bool Male_Person
        {
            get { return male_Person; }
            set { male_Person = value; }
        }

        public Person(string full_Name_Person, int age_Person, string id_Person, bool male_Person)
        {
            Full_Name_Person = full_Name_Person;
            Age_Person = age_Person;
            Id_Person = id_Person;
            Male_Person = male_Person;
        }

        public string Print_Person()
        {
            return $"Full_Name_Person: {Full_Name_Person}.\nAge_Person: {Age_Person}.\nId_Person: {Id_Person}.\n";
        }
    }
}
