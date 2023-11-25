using System.Net.Cache;

namespace CSLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person grandpa1 = new Person()
            {
                Name = "Иванов Иван Иванович",
                Age = 101,
                Gender = Gender.man,
            };
            Person grandma1 = new Person()
            {
                Name = "Иванова Людмила Фёдоровна",
                Age = 96,
                Gender = Gender.woman,
            };
            Person.Marriage(grandpa1, grandma1);

            Person grandpa2 = new Person()
            {
                Name = "Петров Петр Петрович",
                Age = 86,
                Gender = Gender.man,
            };
            Person grandma2 = new Person()
            {
                Name = "Петрова Мария Игоревна",
                Age = 82,
                Gender = Gender.woman,
            };
            Person.Marriage(grandpa2, grandma2);

            Person uncle = new Person()
            {
                Name = "Иванов Игорь Иванович",
                Age = 49,
                Gender = Gender.man,
                Mother = grandma2,
                Father = grandpa2,
            };

            Person mother = new Person()
            {
                Name = "Иванова Елена Ивановна",
                Age = 50,
                Gender = Gender.woman,
                Mother = grandma2,
                Father = grandpa2,
            };
            mother.Siblings = new Person[] { uncle };

            Person father = new Person()
            {
                Name = "Иванов Василий Иванович",
                Age = 56,
                Gender = Gender.man,
                Mother = grandma1,
                Father = grandpa1,
            };
            Person.Marriage(mother, father);

            Person person = new Person()
            {
                Name = "Иванов Петр Васильевич",
                Age = 30,
                Gender = Gender.man,
                Mother = mother,
                Father = father,
            };
            Person wife = new Person()
            {
                Name = "Иванова Екатерина Семеновна",
                Age = 25,
                Gender = Gender.woman,
            };
            Person.Marriage(person, wife);            

            Person daughter = new Person()
            {
                Name = "Иванова Анна Петровна",
                Age = 7,
                Gender = Gender.woman,
                Mother = person,
                Father = wife,
            };

            Person[] husbandParents = wife.Spouse.getParents();
            Console.WriteLine("Родители: ");
            for (int i = 0; i < husbandParents.Length; i++)
            {
                if (husbandParents[i] != null)
                {
                    Console.WriteLine(husbandParents[i].ToString());
                }
            }
            Person[] husandgrandmas = wife.Spouse.getGrandmas();
            Console.WriteLine("Бабушки: ");
            for (int i = 0; i < husandgrandmas.Length; i++)
            {
                if (husandgrandmas[i] != null)
                {
                    Console.WriteLine(husandgrandmas[i].ToString());
                }
            }
            Person[] husandgrandpas = wife.Spouse.getGrandpas();
            Console.WriteLine("Дедушки: ");
            for (int i = 0; i < husandgrandpas.Length; i++)
            {
                if (husandgrandpas[i] != null)
                {
                    Console.WriteLine(husandgrandpas[i].ToString());
                }
            }
        }
    }
}
