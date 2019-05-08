using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq; 

namespace MicroForum_NetCore.Models
{
    public static class ProdutoDados
    {

        // dados da aplicação
        //---------------------------------------------------------
        //        
        private static List<Produto> LISTA_PRODUTOS = new List<Produto>();

        public static List<Produto> ProdutosRetornar()
        {
            // todos os Produtos da aplicação
            //---------------------------------------------------------
            //        
            LISTA_PRODUTOS.Clear();
            ProdutoCarregarGrid();
            return LISTA_PRODUTOS;
        }
        //
        //--------------------------------------------------------------------
        //
        public static void ProdutoAdicionar(Produto ProdutoTemp)
        {

            //trecho ado
            ProdutoGravarInclusao(ProdutoTemp);
            ProdutoTemp.Id_Produto = ProdutoRetornarUltimoID();
            LISTA_PRODUTOS.Add(ProdutoTemp);

        }
        //
        //--------------------------------------------------------------------
        //
        public static Produto ProdutoRetornarDados(int id)
        {
            //Devolve os dados de um Produto especifico
            Produto ProdutoTemp = LISTA_PRODUTOS.Where(i => i.Id_Produto == id).FirstOrDefault();
            return ProdutoTemp;
        }
        //
        //--------------------------------------------------------------------
        //
        public static void ProdutoAlterar(Produto c)
        {
            LISTA_PRODUTOS.First<Produto>(i => i.Id_Produto == c.Id_Produto).Nome = c.Nome;
            LISTA_PRODUTOS.First<Produto>(i => i.Id_Produto == c.Id_Produto).Price = c.Price;
            ProdutoGravarAlteracao(c.Id_Produto, c.Nome, c.Price);

        }
        //
        //--------------------------------------------------------------------
        //
        public static void ProdutoApagar(int id)
        {
            var produtoTemp = LISTA_PRODUTOS.First<Produto>(i => i.Id_Produto == id);
            LISTA_PRODUTOS.Remove(produtoTemp);
            //------------ EXECUTAR A EXCLUSÃO DO REGISTRO ----------------
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = ProdutoMontarQuery_Exclusao(id);
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                Program.comando.ExecuteNonQuery();
                Program.comando.Connection.Close();                
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";
            }

        }
        //----------------------------------------------------------------------
        //
        //          METODOS CUSTOMIZADOS VINDOS DO Exercícios ADO2
        //
        //--------------------------------------------------------------------
        //
        private static void ProdutoGravarInclusao(Produto produtoTemp)
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = ProdutoMontarQuery_Inclusao(produtoTemp);
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
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
        private static string ProdutoMontarQuery_Inclusao(Produto produtoTemp)
        {
            string str = "INSERT INTO Produtos (Nome,Price) VALUES(";
            str += "'" + produtoTemp.Nome     + "',";
            str += + produtoTemp.Price + ")";
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int ProdutoRetornarNovoId()
        {
            int id_Produto = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                Program.LimparVariaveis();
                Program.expressaoSQL = "SELECT MAX(Id_Produto) as UltimoID from Produtos";
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {

                    id_Produto = 1;
                }
                else
                {
                    id_Produto = (int)UltimoID + 1;
                }
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";
            }
            Program.comando.Connection.Close();
            return id_Produto;
        }
        //
        //--------------------------------------------------------------------
        //
        private static int ProdutoRetornarUltimoID()
        {
            int id_Produto = -1;
            try
            {
                //----------  PREPARANDO O ID DO NOVO REGISTRO -------------
                Program.expressaoSQL = "SELECT MAX(Id_Produto ) as UltimoID from Produtos";
                Program.Cnx();                
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                object UltimoID = Program.comando.ExecuteScalar();
                if (UltimoID == DBNull.Value)
                {

                    id_Produto = 1;
                }
                else
                {
                    id_Produto = (int)UltimoID;
                }
            }
            catch (Exception)
            {
                Program.expressaoSQL = "Deu Erro";
            }
            Program.comando.Connection.Close();
            return id_Produto;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string ProdutoMontarQuery_Exclusao(int _Id)
        {
            string str = "";
            str += "DELETE FROM PRODUTOS where Id_Produto=" + _Id;
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static string ProdutoMontarQuery_Alteracao(int _id_Produto, string _sNome, int _iPrice)
        {
            string str = "UPDATE PRODUTOS SET" +
                " Nome = '"  +_sNome + "' " +
                ",Price = " +_iPrice+ " " +
                " WHERE Id_Produto=" + _id_Produto;
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        private static void ProdutoGravarAlteracao(int _id_Produto, string _Nome, int _Price)
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = ProdutoMontarQuery_Alteracao( _id_Produto,  _Nome,  _Price);
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
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

        //
        //--------------------------------------------------------------------
        //
        private static string ProdutoMontarQuery_CarregarGrid()
        {
            string str = "";
            str += "select Id_Produto,Nome,Price from Produtos order by Id_Produto";            
            return str;
        }
        //
        //--------------------------------------------------------------------
        //
        public static  void ProdutoCarregarGrid()
        {
            try
            {
                Program.LimparVariaveis();
                Program.expressaoSQL = ProdutoMontarQuery_CarregarGrid();
                Program.Cnx();
                Program.comando.CommandText = Program.expressaoSQL;
                Program.comando.Connection.Open();
                SqlDataReader dr = Program.comando.ExecuteReader();
                //------------------ABASTECENDO A CLASSE ----------
                LISTA_PRODUTOS.Clear();
                while (dr.Read())
                {
                    Produto _ProdutoTemp = new Produto();

                    // inicalizando o Objeto Instanciado
                    _ProdutoTemp.Id_Produto = 0;
                    _ProdutoTemp.Nome = "";
                    _ProdutoTemp.Price = 0;

                    _ProdutoTemp.Id_Produto = (int)dr["id_Produto"];
                    _ProdutoTemp.Nome       = (string)dr["Nome"];
                    _ProdutoTemp.Price =      (int)dr["Price"];
                    LISTA_PRODUTOS.Add(_ProdutoTemp);
                    _ProdutoTemp = null;
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

    }
}
