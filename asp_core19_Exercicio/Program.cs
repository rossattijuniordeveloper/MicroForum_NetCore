using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MicroForum_NetCore
{
    public class Program
    {
        // variaveis globais
        //---------------------------------------------------------
        // 
        public static string _usuario_Logado = "";
        public static string pastaBD;
        public static string nomeBD;
        public static string strCnx;
        public static SqlConnection Ligacao;
        public static SqlCommand comando;
        public static string expressaoSQL;

        public static void Main(string[] args)
        {
            IniciarVariaveis();            
            CreateWebHostBuilder(args).Build().Run();
        }
        //
        //---------------------------------------------------------
        //
        public static void IniciarVariaveis()
        {
            strCnx = "Data Source=DESKTOP-1SO8CFA\\SQLEXPRESS01;Initial Catalog=teste;Integrated Security=True";
            expressaoSQL = "";
            Ligacao = new SqlConnection(strCnx);
        }
        //
        //---------------------------------------------------------
        //
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        //
        //---------------------------------------------------------
        //
        public static void LimparVariaveis()
        {
            expressaoSQL = null;
            comando = null;
        }
        //
        //---------------------------------------------------------
        //
        public static void Cnx()
        {
            comando = new SqlCommand();
            comando.Connection = new SqlConnection(strCnx);            
        }
        //
        //---------------------------------------------------------
        //
    }
}
