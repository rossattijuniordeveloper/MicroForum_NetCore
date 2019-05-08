using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroForum_NetCore.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha_1 { get; set; }
        public string Senha_2 { get; set; }
    }
}
