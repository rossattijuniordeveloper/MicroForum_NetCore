using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroForum_NetCore.Models
{
    public class Cliente
    {
        public    int Id_Cliente { get; set; }
        public string Nome       { get; set; }
        public string Telefone   { get; set; }
        public string Morada     { get; set; }
        public string Cep        { get; set; }

    }
}
