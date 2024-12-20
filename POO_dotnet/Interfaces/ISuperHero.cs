using POO_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO_dotnet.Interfaces
{
    internal interface ISuperHero
    {
        int id { get; set;}
        string name { get; set; }
        string secretId { get; set; }

        string getSuperHero()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {id}");
            sb.AppendLine($"NAME: {name}");
            sb.AppendLine($"SECRET_ID: {secretId}");
            return sb.ToString();
        }
    }
}