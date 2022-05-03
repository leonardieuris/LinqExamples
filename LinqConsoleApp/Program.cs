using Human;
using LinqConsoleApp;
using Human.Model;

//var mat = new Materializzazione();
//var mat2 = new Materializzazione();

//List<int> materializzato = mat.CountUntil10Materializzato();

//IEnumerable<int> nonmaterializzato = mat.CountUntil10();

//List<int> materializzatodopo = mat2.CountUntil10().ToList();


//bool first = materializzato.Any();
//int countmaterializzato = materializzato.Count();

//bool second = nonmaterializzato.Any();
//int countnonmaterializzato = nonmaterializzato.Count();

//bool third = materializzatodopo.Any();
//int countmaterializzatodopo = materializzatodopo.Count();

//foreach (var a in nonmaterializzato)
//{

//    string b = a.ToString();
//    b.DeleteCharA();
//}


//string p = "";


//var data = new Data();

//IEnumerable<string> esempio = data.GetAllCompleteNameEnumerable();

var handler = new HandlerPerson();


//handler.InserisciUnaPersona();
//handler.UpdatePersona();


var persone = handler.GetPersone();


IEnumerable<Person> personemenodiquaranta = persone.Where(x => DateTime.Now.Year - x.Birthday.Year < 40);

foreach (var item in personemenodiquaranta)
{
    Console.WriteLine($"{item.Name} {item.Surname} {item.Birthday.Year} => {DateTime.Now.Year - item.Birthday.Year}");
}



//foreach (var item in persone)
//{
//    Console.WriteLine($"{item.Name} {item.Surname}");
//}


//var personeEnumerable = handler.GetPersone("Rossi");

//foreach (var item in personeEnumerable)
//{
//    Console.WriteLine($"{item.Name} {item.Surname}");
//}


Console.ReadLine();
