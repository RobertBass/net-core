using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    internal class Antihero : Superhero
    {
        public string antiHeroAction(string action)
        {
            return $"El antiheroe {name_secret} ha realizado la accion: {action}";
        }
    }
}
