using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroForum_NetCore.Models
{
    public class Encomenda
    {
        public    int Id_Encomenda { get; set; }
        public    int Id_Cliente   { get; set; }
        public string ClienteNome  { get; set; }
        public    int Id_Produto   { get; set; }
        public string ProdutoNome  { get; set; }
        public    int Qtdd         { get; set; }
        public  float Valor        { get; set; }
    }
}
