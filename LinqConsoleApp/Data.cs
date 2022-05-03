using System.Linq;
using Human;

namespace LinqConsoleApp
{
    public class Data
    {
        private readonly List<Person> BaseData;

        public Data()
        {
            BaseData = new List<Person>();
        }

        public void Add(Person person)
        {
            BaseData.Add(person);
        }

        public List<Person> Search(string surname, string name)
        {
            var listOutput = new List<Person>();

            foreach (var person in BaseData)
            {
                if (person.Name.Equals(name) && person.Surname.Equals(surname))
                {
                    listOutput.Add(person);
                }
            }

            return listOutput;
        }


        public List<Person> SearchByLinq(string surname, string name)
        {
            return BaseData.
                Where(x => 
                x.Name.Equals(name) 
                && x.Surname.Equals(surname))
                .ToList();
        }

        public Person? SearchFirst(string surname, string name)
        {
            return BaseData.
                FirstOrDefault(x =>
                x.Name.Equals(name)
                && x.Surname.Equals(surname));
        }

        public List<Person> OrderByBDay()
        {
            return BaseData.OrderBy(x => x.Birthday).ToList();
        }

        public List<string> GetAllSurname()
        {
            return BaseData.Select(x => x.Surname).ToList();
        }

        public string GetAllCompleteNameFirst(string surname, string name)
        {

            var person= BaseData.
               FirstOrDefault(x =>
               x.Name.Equals(name)
               && x.Surname.Equals(surname));

            if (person == null)
                return string.Empty;

            return person.CompleteName();


        }


        public List<string> GetAllCompleteName()
        {
            return BaseData.Select(x => x.CompleteName()).ToList();
        }


        public IEnumerable<string> GetAllCompleteNameEnumerable()
        {
            return BaseData.Select(x => x.CompleteName());
        }



        public int SumUnDatoQualsiasi()
        {
            return BaseData.Sum(x => x.UnDatoQualasiasi);
        }


        public int SumUnDatoQualsiasi(string surname)
        {
            return BaseData
                .Where(x=>x.Surname==surname)
                .Sum(x => x.UnDatoQualasiasi);
        }

        public int GetAllFemale()
        {
            return BaseData.Count(x => x.Gender.Equals("Female"));
        }


        public int GetAllFemaleLegacy()
        {
            var count = 0;
            foreach (var item in BaseData)
            {
                if (item.Gender.Equals("Female")) ;
                count++;
            }
            return count;
        }

        public bool CheckIfEmpty() => BaseData.Any();
        

    }
}
