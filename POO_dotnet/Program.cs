using System.Text;
using POO_dotnet.Models;
using POO_dotnet;
//using POO_dotnet.Interfaces;

var printInfo = new PrintInfo();

// HABILITIES
var canFly = new Habilities();
canFly.name = "Volar";
canFly.description = "Capacidad para volar y planear en el aire";
canFly.level = LevelPower.LevelTwo;


var strenght =  new Habilities();
strenght.name = "Super Fuerza";
strenght.description = "Fuerza increible";
strenght.level = LevelPower.LevelThree;

var regeneration =  new Habilities();
regeneration.name = "Regeneracion";
regeneration.description = "Capacidad para regenerarse o curarse rapidamente";
regeneration.level = LevelPower.LevelTwo;


// SUPERHEROS
var superman =  new Superhero();
superman.id = 1;
superman.name = "   Superman   ";
superman.secretId = "Clark Kent";
superman.city = "Metropolis";
superman.fly = true;

printInfo.Print(superman);


List<Habilities> poderesSuperman = new List<Habilities>();
poderesSuperman.Add(canFly);
poderesSuperman.Add(strenght);
superman.habilities = poderesSuperman;
superman.useHabilities();
//string result = superman.useHabilities2();
//Console.WriteLine(result);
string result = superman.saveWorld();
Console.WriteLine(result);
string result2 = superman.saveMars();
Console.WriteLine(result2);

// ANTIHEROS
var wolverine = new Antihero();
wolverine.id = 5;
wolverine.name = "Wolverine";
wolverine.secretId = "Logan";
wolverine.fly = false;

List<Habilities> poderesWolverine = new List<Habilities>();
poderesWolverine.Add(strenght);
poderesWolverine.Add(regeneration);
wolverine.habilities = poderesWolverine;
wolverine.useHabilities();
//string result2 = wolverine.useHabilities2();
//Console.WriteLine(result2);

printInfo.Print(wolverine);

string antiHeroAction = wolverine.antiHeroAction("Ataca a la policia");
Console.WriteLine(antiHeroAction);