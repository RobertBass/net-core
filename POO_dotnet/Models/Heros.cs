using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    internal abstract class Hero
    {
        public abstract string name { get; set; }
        public abstract string saveWorld();
        public virtual string saveMars()
        {
            return $"{name} salvo a Marte";
        }
    }
}
