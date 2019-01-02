using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private date dateBirth;
        public date DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }

        private person mother;
        public person Mother
        {
            get { return mother; }
            set { mother = value; }
        }

        private person father;
        public person Father
        {
            get { return father; }
            set { father = value; }
        }

        public person(string name, date dateBirth, person mother, person father)
        {
            Name = name;
            DateBirth = dateBirth;
            Mother = mother;
            Father = father;
        }

        public person()
        {

        }

        public string toString_Person()
        {
            string res = $"p.name:\t{Name}.\np.datebirth:\t{DateBirth.toString_Date()}.";
            if(Mother!=null && Father!=null)
                 res += $"\np.mother:\t{Mother.Name}.\np.father:\t{Father.Name}.";
            return res;
        }





    }
}
