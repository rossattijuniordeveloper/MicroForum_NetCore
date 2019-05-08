using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroForum_NetCore.Models
{
    public class Posts
    {
        public int id_posts { get; set; }
        public int id_usuario { get; set; }
        public string nomeUsuario { get; set; }
        public string titulo { get; set; }
        public string mensagem { get; set; }
        public string atualizacao { get; set; }        

    }
}
