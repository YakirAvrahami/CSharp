using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Worker : Person
    {
        private int salary_Worker;
        public int Salary_Worker
        {
            get { return salary_Worker; }
            set { salary_Worker = value; }
        }

        public Worker(int salary_Worker, string full_Name_Person, int age_Person, string id_Person, bool male_Person):base (full_Name_Person, age_Person, id_Person, male_Person)
        {
            Salary_Worker = salary_Worker;
        }

        public string Print_Worker()
        {
            return $"Salary_Worker: {Salary_Worker}\n {base.Print_Person()}";
        }

    }
}
