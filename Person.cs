using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLessons
{
    public enum Gender { man, woman}
    internal class Person
    {
        public string Name { get; set; } = "John Dow";
        public Gender Gender { get; set; }
        public int Age { get; set; } = 18;
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Person Spouse {  get; set; }
        public Person[] Siblings { get; set; } = new Person[0];

       
        public Person[] getParents()
        {
            return new Person[] { Mother, Father };
        }

        public Person[] getGrandmas() {
            return new Person[] { Mother?.Mother, Father?.Mother };
        }

        public Person[] getGrandpas()
        {
            return new Person[] { Mother?.Father, Father?.Father };
        }

        public override string ToString()
        {
            string gender = string.Empty;
            if (Gender.Equals(Gender.man))
            {
                gender = " мужчина,";
            }
            else gender = " женщина,";
            return Name + gender + " " + Age + " лет, " ;
        }

        public static void Marriage(Person husband, Person wife)
        {
            husband.Spouse = wife;
            wife.Spouse = husband;
        }
    }
}
