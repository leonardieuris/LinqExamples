using Human.Model;
using Human.Persister;

namespace LinqConsoleApp
{
    public class HandlerPerson
    {
        private readonly string connectionString = "Server=.;Database=Gestionale;Trusted_Connection=True;";
        //Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;
        public bool InserisciUnaPersona()
        {
            var person = new Person
            {
                Birthday = new DateTime(1950, 4, 5),
                Gender ="Male",
                Name="Nicola",
                Surname="Verdi"
            };

            var persister = new PersonPersister(connectionString);
           return persister.Add(person);
        }


        public void CancellaUnaPersona(int Id)
        {
            var persister = new PersonPersister(connectionString);
            persister.Delete(Id);
        }

        public bool UpdatePersona()
        {
            var person = new Person
            {

                Birthday = new DateTime(1950, 4, 5),
                Gender = "Female",
                Name = "Maria",
                Surname = "Rossi",
                Id =2

            };

            var persister = new PersonPersister(connectionString);
            return persister.Update(person);

        }

        public List<Person> GetPersone()
        {
            var persister = new PersonPersister(connectionString);
            var listPerson = persister.GetPeople();
            return listPerson;
        }


        public IEnumerable<Person> GetPersone(string cognome)
        {
            var persister = new PersonPersister(connectionString);
            var listPerson = persister.GetPeople(cognome);
            return listPerson;
        }
    }
}
