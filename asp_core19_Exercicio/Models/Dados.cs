using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace MicroForum_NetCore.Models
{ 
    public static class Dados
    {
        private static List<Posts> LISTA_POSTS = new List<Posts>();

        //
        //---------------------------------------------------------
        //        
        public static void IniciarVariaveis()
        {
            /*
            MicroForum_NetCore.Startup.strCnx = "Data Source=DESKTOP-1SO8CFA\\SQLEXPRESS01;Initial Catalog=teste;Integrated Security=True";
            MicroForum_NetCore.Startup.expressaoSQL = string.Empty;
            MicroForum_NetCore.Startup.Ligacao = new SqlConnection(MicroForum_NetCore.Startup.strCnx);
            */
            Program.strCnx = "Data Source=DESKTOP-1SO8CFA\\SQLEXPRESS01;Initial Catalog=teste;Integrated Security=True";
            Program.expressaoSQL = string.Empty;
            Program.Ligacao = new SqlConnection(Program.strCnx);

        }
        //
        //--------------------------------------------------------------------
        //
        public static SqlDataReader RetornarPosts(string _usuario, int _opcao)
        {

            SqlDataReader dr;

            try
            {
                LimparVariaveis();
                /*
                MicroForum_NetCore.Startup.comando = new SqlCommand();
                MicroForum_NetCore.Startup.comando.Connection = new SqlConnection(MicroForum_NetCore.Startup.strCnx);
                string _sSQL = MontarQuery_RetornarPosts(_usuario, _opcao);
                MicroForum_NetCore.Startup.comando.CommandText = string.Empty;
                MicroForum_NetCore.Startup.comando.CommandText = _sSQL;
                MicroForum_NetCore.Startup.comando.Connection.Open();
                dr = MicroForum_NetCore.Startup.comando.ExecuteReader();
                */
                Program.comando = new SqlCommand();
                Program.comando.Connection = new SqlConnection(Program.strCnx);
                string _sSQL = MontarQuery_RetornarPosts(_usuario, _opcao);
                Program.comando.CommandText = string.Empty;
                Program.comando.CommandText = _sSQL;
                Program.comando.Connection.Open();
                dr = Program.comando.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
            }
            return null;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_RetornarPosts(string _Usuario, int Opcao)
        {
            int id_usuario = RetornarIdUsuario(_Usuario);
            string str = string.Empty;
            // a opção Zero  vem da chamda da pagina Index, portanto só os 5 ultimos registros dos usuarios
            if (Opcao == 0)
            {
                str += "SELECT";
                str += " top 5  ";
                str += " id_posts,id_usuario,titulo,mensagem,atualizacao FROM posts ";
                str += " ORDER BY atualizacao DESC";
            }
            else
            {
                str += "SELECT";
                str += " id_posts,id_usuario,titulo,mensagem,atualizacao FROM posts WHERE id_usuario=" + id_usuario;
                str += " ORDER BY atualizacao DESC";
            }

            return str;

        }
        //
        //--------------------------------------------------------------------
        //
        private static void LimparVariaveis()
        {
            //MicroForum_NetCore.Startup.expressaoSQL = null;
            //MicroForum_NetCore.Startup.comando.Connection = null;
            //MicroForum_NetCore.Startup.comando.CommandText = null;
            //MicroForum_NetCore.Startup.comando = null;

            Program.expressaoSQL = null;
            Program.comando.Connection = null;
            Program.comando.CommandText = null;
            Program.comando = null;

        }
        //
        //---------------------------------------------------------
        //
        public static int RetornarIdUsuario(string _usuario)
        {
            int retorno = -1;
            try
            {
                /*
                MicroForum_NetCore.Startup.comando = new SqlCommand();
                MicroForum_NetCore.Startup.comando.Connection = MicroForum_NetCore.Startup.Ligacao;
                MicroForum_NetCore.Startup.comando.CommandText = string.Empty;
                MicroForum_NetCore.Startup.comando.CommandText = MontarQuery_PesquisarUsuario(_usuario);
                MicroForum_NetCore.Startup.comando.Connection.Open();
                SqlDataReader dr = MicroForum_NetCore.Startup.comando.ExecuteReader();
                */
                Program.comando = new SqlCommand();
                Program.comando.Connection = Program.Ligacao;
                Program.comando.CommandText = string.Empty;
                Program.comando.CommandText = MontarQuery_PesquisarUsuario(_usuario);
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                while ((dr.Read()))
                {
                    retorno = (int)dr["id_usuario"];
                }
                //                MicroForum_NetCore.Startup.comando.Connection.Close();
                //MicroForum_NetCore.Startup.comando.CommandText = "";
                Program.comando.Connection.Close();
                Program.comando.CommandText = "";
            }
            catch (Exception)
            {
                retorno = -1;
            }
            return retorno;
        }
        //
        //--------------------------------------------------------------------
        //
        public static bool PesquisarUsuario(string _usuario)
        {
            bool retorno = false;
            try
            {
                /*
                MicroForum_NetCore.Startup.comando = new SqlCommand();
                MicroForum_NetCore.Startup.comando.Connection = MicroForum_NetCore.Startup.Ligacao;
                MicroForum_NetCore.Startup.expressaoSQL = string.Empty;
                MicroForum_NetCore.Startup.expressaoSQL = MontarQuery_PesquisarUsuario(_usuario);
                MicroForum_NetCore.Startup.comando.CommandText = string.Empty;
                MicroForum_NetCore.Startup.comando.CommandText = MicroForum_NetCore.Startup.expressaoSQL;
                MicroForum_NetCore.Startup.comando.Connection.Open();
                SqlDataReader dr = MicroForum_NetCore.Startup.comando.ExecuteReader();
                */
                Program.comando = new SqlCommand();
                Program.comando.Connection = Program.Ligacao;
                Program.expressaoSQL = string.Empty;
                Program.expressaoSQL = MontarQuery_PesquisarUsuario(_usuario);
                Program.comando.CommandText = string.Empty;
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                while ((dr.Read()))
                {
                    retorno = true;
                }
                //MicroForum_NetCore.Startup.comando.Connection.Close();
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_PesquisarUsuario(string _Nome)
        {
            string str = "select id_usuario from usuario where Nome='";
            str += _Nome + "'";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        //
        //--------------------------------------------------------------------
        //
        public static bool VerificarSenha(string _usuario, string _senha)
        {
            encriptar enc = new encriptar();
            string pass = enc.CriarMD5(_senha);
            string senhaBanco = MicroForum_NetCore.Models.Dados.RetornarSenha(_usuario);
            bool Retorno = false;
            if (pass == senhaBanco)
            {
                Retorno = true;
            }
            return Retorno;
        }
        //
        //--------------------------------------------------------------------
        //
        //
        //--------------------------------------------------------------------
        //
        public static string RetornarSenha(string _usuario)
        {
            string retorno = "";
            try
            {
                /*
                MicroForum_NetCore.Startup.comando = new SqlCommand();
                MicroForum_NetCore.Startup.comando.Connection = new SqlConnection(MicroForum_NetCore.Startup.strCnx);
                MicroForum_NetCore.Startup.comando.CommandText = MontarQuery_RetornarSenha(_usuario);
                MicroForum_NetCore.Startup.comando.Connection.Open();
                */
                Program.comando = new SqlCommand();
                Program.comando.Connection = new SqlConnection(Program.strCnx);
                Program.comando.CommandText = MontarQuery_RetornarSenha(_usuario);
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                while ((dr.Read()))
                {
                    retorno = dr["senha"].ToString();
                }
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
                retorno = "";
            }
            return retorno;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_RetornarSenha(string _Nome)
        {
            string str = "select senha from usuario where Nome='";
            str += _Nome + "'";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        //
        //--------------------------------------------------------------------
        //
        public static bool IncluirUsuario(string _Nome, string _senha)
        {
            bool result = true;
            try
            {
                // encriptar a senha
                encriptar enc = new encriptar();
                string senhaEnc = enc.CriarMD5(_senha);
                //preparar e executar a gravação do novo registro;
                Program.expressaoSQL = MontarQuery_IncluirUsuario(RetornarNovoId(), _Nome, senhaEnc);
                Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection = Program.Ligacao;
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            Program.comando.Connection.Close();
            return result;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_IncluirUsuario(int _id, string _Nome, string _senha)
        {
            string str = "insert into usuario (id_usuario,nome,senha) values (";
            str += _id + ",";
            str += "'" + _Nome + "',";
            str += "'" + _senha + "')";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int RetornarNovoId()
        {
            int _id = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                Program.expressaoSQL = "SELECT MAX(Id_usuario) as ID from usuario";
                Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection = Program.Ligacao;
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {
                    _id = 1;
                }
                else
                {
                    _id = (int)UltimoID + 1;
                }
            }
            catch (Exception)
            {

            }
            Program.comando.Connection.Close();
            return _id;
        }
        //
        //--------------------------------------------------------------------
        //
        public static List<Posts>PostsRetornar()
        {
            // todos os clientes da aplicação
            //---------------------------------------------------------
            //        
            LISTA_POSTS.Clear();
            CarregarGridPosts();
            return LISTA_POSTS;
        }
        //
        //--------------------------------------------------------------------
        //
        public static bool IncluirPosts(string _Titulo, string _Mensagem )
        {
            bool result = true;
            try
            {
                //preparar e executar a gravação do novo registro;
                int _id_usuario = (int)MicroForum_NetCore.Models.Dados.RetornarIdUsuario(Program._usuario_Logado);
                int _Id_posts = RetornarNovoIdPosts();
                LimparVariaveis();
                Program.expressaoSQL = MontarQuery_IncluirPosts(_Id_posts,_id_usuario, _Titulo, _Mensagem, DateTime.Now);
                Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection = new SqlConnection(Program.strCnx);
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_IncluirPosts(int _id, int _Id_usuario, string _Titulo, string _Mensagem, DateTime _atualizacao)
        {
            string str = "insert into posts (id_posts,id_usuario,titulo,mensagem,atualizacao) values (";
            str += _id + ",";
            str += _Id_usuario + ",";
            str += "'" + _Titulo + "',";
            str += "'" + _Mensagem + "',";
            str += "'" + _atualizacao.ToString() + "')";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int RetornarNovoIdPosts()
        {
            int _id = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                LimparVariaveis();
                Program.expressaoSQL = string.Empty;
                Program.expressaoSQL = "SELECT MAX(id_posts) as ID from posts";
                Program.comando = new SqlCommand();
                Program.comando.CommandText = string.Empty;
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection = new SqlConnection(Program.strCnx);
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {
                    _id = 1;
                }
                else
                {
                    _id = (int)UltimoID + 1;
                }
            }
            catch (Exception)
            {

            }
            Program.comando.Connection.Close();
            return _id;
        }
        //
        //--------------------------------------------------------------------
        //








        //---------------------------------------------------------------------------------------------------------------------//
        //
        //----------------------------------- ANTIGO NET CORE A PARTIR DAQUI --------------------------------------------------//
        // 
        //---------------------------------------------------------------------------------------------------------------------//

        // dados da aplicação
        //---------------------------------------------------------
        //        
        /*
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static List<Cliente> ClientesRetornar()
        {
            // todos os clientes da aplicação
            //---------------------------------------------------------
            //        
            LISTA_CLIENTES.Clear();
            CarregarGridClientes();
            return LISTA_CLIENTES;
        }
        //
        //--------------------------------------------------------------------
        //
        public static void AdicionarCliente(Cliente clienteTemp)
        {

            //trecho ado
            GravarInclusao(clienteTemp);
            clienteTemp.Id_Cliente = RetornarUltimoID();
            LISTA_CLIENTES.Add(clienteTemp);

        }
        //
        //--------------------------------------------------------------------
        //
        public static Cliente DadosCliente (int id)
        {
            //Devolve os dados de um cliente especifico
            Cliente clienteTemp = LISTA_CLIENTES.Where(i => i.Id_Cliente == id).FirstOrDefault();
            return clienteTemp;

        }
        //
        //--------------------------------------------------------------------
        //
        public static void AlterarCliente(Cliente c)
        {
            LISTA_CLIENTES.First<Cliente>(i => i.Id_Cliente == c.Id_Cliente).Nome = c.Nome;
            LISTA_CLIENTES.First<Cliente>(i => i.Id_Cliente == c.Id_Cliente).Telefone = c.Telefone;
            LISTA_CLIENTES.First<Cliente>(i => i.Id_Cliente == c.Id_Cliente).Morada = c.Morada;
            LISTA_CLIENTES.First<Cliente>(i => i.Id_Cliente == c.Id_Cliente).Cep = c.Cep;
            GravarAlteracao(c.Id_Cliente, c.Nome, c.Telefone,c.Morada,c.Cep);

        }
        //
        //--------------------------------------------------------------------
        //
        public static void ApagarCliente(int id)
        {
            var clienteTemp = LISTA_CLIENTES.First<Cliente>(i => i.Id_Cliente == id);
            LISTA_CLIENTES.Remove(clienteTemp);
            //------------ EXECUTAR A EXCLUSÃO DO REGISTRO ----------------
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = MontarQuery_Exclusao(id);
                Program.Cnx();
                //Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                //Program.comando.Connection  = Program.Ligacao;
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();                
            }
            catch (Exception)
            {
               // MessageBox.Show("Em [ApagarRegistros] Houve um erro de Acesso ao Banco de Dados , Verifique seu acesso ao banco",
               //     "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //----------------------------------------------------------------------
        //
        //          METODOS CUSTOMIZADOS VINDOS DO Exercícios ADO2
        //
        //--------------------------------------------------------------------
        //
        private static void GravarInclusao(Cliente clienteTemp)
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = MontarQuery_Inclusao(clienteTemp);
                //Program.comando = new SqlCommand();
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                //Program.comando.Connection =  Program.Ligacao;
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";  
            }            
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_Inclusao(Cliente clienteTemp)
        {
            string str = "INSERT INTO clientes (Nome,Telefone,Morada,Cep) VALUES(";
            str += "'" + clienteTemp.Nome     + "',";
            str += "'" + clienteTemp.Telefone + "',";
            str += "'" + clienteTemp.Morada   + "',";
            str += "'" + clienteTemp.Cep      + "')";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int RetornaNovoIdClientes()
        {
            int id_cliente = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                Program.LimparVariaveis();
                Program.expressaoSQL = "SELECT MAX(Id_cliente) as UltimoID from clientes";
                //Program.comando = new SqlCommand();
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                //Program.comando.Connection  = Program.Ligacao;
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {

                    id_cliente = 1;
                }
                else
                {
                    id_cliente = (int)UltimoID + 1;
                }
            }
            catch (Exception)
            {
            }
            Program.comando.Connection.Close();
            return id_cliente;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int RetornarUltimoID()
        {
            int id_cliente = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                Program.expressaoSQL = "SELECT MAX(Id_cliente) as UltimoID from clientes";
                Program.Cnx();
//                Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                //Program.comando.Connection = Program.Ligacao;
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {

                    id_cliente = 1;
                }
                else
                {
                    id_cliente = (int)UltimoID;
                }
            }
            catch (Exception)
            {
            }
            Program.comando.Connection.Close();
            return id_cliente;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_Exclusao(int _Id)
        {
            string str = "";
            str += "DELETE FROM CLIENTES where Id_Cliente=" + _Id;
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_Alteracao(int _id_cliente, string _Nome,string _Telefone,string _Morada,string _Cep)
        {
            string str = "UPDATE CLIENTES SET" +
                " Nome = '"     + _Nome + "' " +
                ",Telefone = '" + _Telefone + "' " +
                ",Morada = '" + _Morada + "' " +
                ",Cep  = '" + _Cep + "' " +
                " WHERE Id_Cliente=" + _id_cliente;
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static void GravarAlteracao(int _id_cliente, string _Nome, string _Telefone,string _Morada,string _Cep)
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = MontarQuery_Alteracao( _id_cliente,  _Nome,  _Telefone,_Morada,_Cep);
                Program.Cnx();
                //Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                //Program.comando.Connection  = Program.Ligacao;
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
            }
        }
        //
        //--------------------------------------------------------------------
        //
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_CarregarGrid()
        {
            string str = "";
            str += "select Id_Cliente,Nome,Telefone,Morada,Cep from Clientes order by Id_Cliente";
            
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        public static  void CarregarGridClientes()
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = MontarQuery_CarregarGrid();
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                //------------------ABASTECENDO A CLASSE ----------
                LISTA_CLIENTES.Clear();
                while (dr.Read())
                {
                    Cliente _ClienteTemp = new Cliente();

                    // inicalizando o Objeto Instanciado
                    _ClienteTemp.Id_Cliente = 0;
                    _ClienteTemp.Nome = "";
                    _ClienteTemp.Telefone = "";
                    _ClienteTemp.Morada = "";
                    _ClienteTemp.Cep = "";

                    _ClienteTemp.Id_Cliente =(int)dr["id_cliente"];
                    _ClienteTemp.Nome       =(string)dr["Nome"];
                    _ClienteTemp.Telefone   =(string)dr["Telefone"];
                    _ClienteTemp.Morada   =(string)dr["Morada"]+"";
                    _ClienteTemp.Cep   =(string)dr["Cep"]+"";
                    LISTA_CLIENTES.Add(_ClienteTemp);
                    _ClienteTemp = null;
                }
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";
            }
        }
        //
        //--------------------------------------------------------------------
        //
        */
        //
        //--------------------------------------------------------------------
        //
        public static void CarregarGridPosts()
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = MontarQuery_CarregarGridPosts();
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                //------------------ABASTECENDO A CLASSE ----------
                LISTA_POSTS.Clear();
                while (dr.Read())
                {
                    Posts  _PostsTemp = new Posts();

                    // inicalizando o Objeto Instanciado
                    _PostsTemp.id_posts = 0;
                    _PostsTemp.id_usuario = 0;
                    _PostsTemp.nomeUsuario = "";
                    _PostsTemp.titulo = "";
                    _PostsTemp.mensagem = "";
                    _PostsTemp.atualizacao = "";

                    _PostsTemp.id_posts = (int)dr["id_posts"];
                    _PostsTemp.id_usuario = (int)dr["id_usuario"];
                    _PostsTemp.nomeUsuario = (string)dr["NomeUsuario"];
                    _PostsTemp.titulo = (string)dr["titulo"];
                    _PostsTemp.mensagem = (string)dr["mensagem"] +"";
                    //_PostsTemp.atualizacao = (string)dr["atualizacao"] + "";
                    _PostsTemp.atualizacao = (string)dr[5] + "";
                    LISTA_POSTS.Add(_PostsTemp);
                    _PostsTemp = null;
                }
                Program.comando.Connection.Close();
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";
            }
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_CarregarGridPosts()
        {
            int Id_usuario = RetornarIdUsuario(Program._usuario_Logado);
            string str = "";
            str += "select p.id_posts,p.id_usuario,usu.nome as nomeUsuario,p.titulo,mensagem,CONVERT(varchar, p.atualizacao , 23) as atualizacao from posts as p";
            str += " left outer join usuario as usu On usu.id_usuario = p.id_usuario";
            str += " where p.id_usuario = " + Id_usuario.ToString();
            str += " order by p.atualizacao desc";

            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        //
        //--------------------------------------------------------------------
        //
        public static bool mtdApagarPosts(int Idposts)
        {
            bool result = true;
            try
            {
                LimparVariaveis();
                //preparar e executar a gravação do novo registro;
                Program.expressaoSQL = MontarQuery_ApagarPost(Idposts);
                Program.comando = new SqlCommand();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection = new SqlConnection(Program.strCnx);
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string MontarQuery_ApagarPost(int _idPosts)
        {
            string str = String.Empty;

            str += "DELETE FROM posts ";
            str += " WHERE id_posts=" + _idPosts;
            return str;
        }
        //
        //--------------------------------------------------------------------
        //

    }
}
