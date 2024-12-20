using POO_dotnet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_dotnet
{
    internal class PrintInfo
    {
        public void Print(ISuperHero superHero)
        {
            Console.WriteLine(superHero.getSuperHero());
        }
    }
}