using POO_dotnet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    internal class Superhero : Hero, ISuperHero
    {
        private string _name = "";
        public int id { get; set;} = 1;
        // Encapuslamiento
        public override String name 
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }
        public string name_secret
        {
            get { return $"{name} ({secretId})";}
        }
        public string secretId { get; set; } = "";
        public string city = "";
        public List<Habilities> habilities;
        public bool fly;

        public Superhero()
        {
            id = 1;
            habilities = new List<Habilities>();
            fly =  false;

        }

        public void useHabilities()
        {
            foreach (var hability in habilities)
            {
                Console.WriteLine($"{name_secret} esta usando el super poder {hability.name}!!");
            }
        }

        public string useHabilities2()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hability in habilities)
            {
                sb.AppendLine($"{name_secret} esta usando el super poder {hability.name}!!");
            }
            return sb.ToString();
        }

        public override string saveWorld()
        {
            return $"{name_secret} ha salvado el mundo";
        }

        public override string saveMars()
        {
            //return base.saveMars();
            return $"{name_secret} ha salvado marte";
        }
    }
}
