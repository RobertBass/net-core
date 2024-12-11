using System.Text;

var poderVolar = new SuperPoderes();
poderVolar.nombre = "Volar";
poderVolar.descripcion = "Capacidad para volar y planear en el aire";
poderVolar.nivel = NivelPoder.NivelDos;


var superFuerza =  new SuperPoderes();
superFuerza.nombre = "Super Fuerza";
superFuerza.descripcion = "Fuerza increible";
superFuerza.nivel = NivelPoder.NivelTres;



var superman =  new Superhero();
superman.id = 1;
superman.name = "Superman";
superman.identidadSecreta = "Clark Kent";
superman.ciudad = "Metropolis";
superman.vuela = true;
List<SuperPoderes> poderesSuperman = new List<SuperPoderes>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.superPoderes = poderesSuperman;
superman.usarSuperPoderes();
string result = superman.useSuperPoderes();
Console.WriteLine(result);

class Superhero
{
    public int id;
    public String name = "";
    public string identidadSecreta = "";
    public string ciudad = "";
    public List<SuperPoderes> superPoderes;
    public bool vuela;

    public Superhero()
    {
        id = 1;
        superPoderes = new List<SuperPoderes>();
        vuela =  false;

    }

    public void usarSuperPoderes()
    {
        foreach (var item in superPoderes)
        {
            Console.WriteLine($"{name} esta usando el super poder {item.nombre}!!");
        }
    }

    public string useSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in superPoderes)
        {
            sb.AppendLine($"{name} esta usando el super poder {item.nombre}!!");
        }
        return sb.ToString();
    }

}


class SuperPoderes
{
    public string nombre;
    public string descripcion;
    public NivelPoder nivel;

    public SuperPoderes()
    {
        nombre = "";
        descripcion = "";
        nivel = new NivelPoder();
    }

}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}



