using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    internal class Habilities
    {
        public string name;
        public string description;
        public LevelPower level;

        public Habilities()
        {
            name = "";
            description = "";
            level = new LevelPower();
        }

    }

    enum LevelPower
    {
        LevelOne,
        LevelTwo,
        LevelThree
    }

}


