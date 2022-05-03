using Human;

var mat = new Materializzazione();
var mat2 = new Materializzazione();

List<int> materializzato = mat.CountUntil10Materializzato();

IEnumerable<int> nonmaterializzato = mat.CountUntil10();

List<int> materializzatodopo = mat2.CountUntil10().ToList();


bool first = materializzato.Any();
int countmaterializzato = materializzato.Count();

bool second = nonmaterializzato.Any();
int countnonmaterializzato = nonmaterializzato.Count();

bool third = materializzatodopo.Any();
int countmaterializzatodopo = materializzatodopo.Count();

foreach (var a in nonmaterializzato)
{

    string b = a.ToString();
}


string p = "";
