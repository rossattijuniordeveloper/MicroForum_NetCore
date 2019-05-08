using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroForum_NetCore.Models;

namespace MicroForum_NetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // apresenta o Menu Inicial
            return View();
        }
        //---------------------------------------------------------------------
        //
        //VIEWS DE ACESSO Login Logout
        //
        //---------------------------------------------------------------------

        //
        //---------------------------------------------------------------------
        //
        public IActionResult LogOut()
        {
            return View();
        }
        //
        //---------------------------------------------------------------------
        //
        public IActionResult Login()
        {
            return View();
        }
        //
        //---------------------------------------------------------------------
        //
        [HttpPost]
        public IActionResult LoginVerificar(Usuario u)
        {
            return View(u);
        }
        //
        //---------------------------------------------------------------------
        //
        //---------------------------------------------------------------------
        //    ADICIONAR Conta usuario.
        //---------------------------------------------------------------------
        //
        public IActionResult AdicionarConta()
        {
            //adicionar um novo Cliente
            return View();
        }
        //
        //---------------------------------------------------------------------
        //
        [HttpPost]
        public IActionResult AdicionarContas(Usuario u)
        {
            string IrparaOnde = "AdicionarConta";
            //chamar o metodo no Models para adicionar Usuario
            if( !MicroForum_NetCore.Models.Dados.PesquisarUsuario(u.Nome))
            {
                MicroForum_NetCore.Models.Dados.IncluirUsuario(u.Nome, u.Senha_1);
                IrparaOnde = "Login";
            }
            else
            {
                IrparaOnde = "AdicionarConta";
            }
            return RedirectToAction(IrparaOnde);
        }
        //
        //---------------------------------------------------------------------
        //
        public IActionResult ListarPosts()
        {
            // apresenta a lista de posts lançados pelo usuario            
            return View(Dados.PostsRetornar());

        }
        //---------------------------------------------------------------------
        //    ADICIONAR POSTS
        //---------------------------------------------------------------------
        //
        public IActionResult PostsAdicionar()
        {
            //adicionar um novo Produto
            return View();
        }
        //
        //---------------------------------------------------------------------
        //
        [HttpPost]
        public IActionResult PostsGravar(Posts po)
        {

            if (!MicroForum_NetCore.Models.Dados.IncluirPosts(po.titulo, po.mensagem))
                return RedirectToAction("ListarPosts");
            else
                return RedirectToAction("PostsAdicionar");

        }
        //---------------------------------------------------------------------
        //    APAGAR POSTS
        //---------------------------------------------------------------------
        //
        //
        //---------------------------------------------------------------------
        //
        public IActionResult ApagarPostPerguntar(int id)
        {
            return View(id);
        }
        //
        //---------------------------------------------------------------------                             
        //        
        public IActionResult ApagarPost(int iId)
        {
            if (iId == 0)
            {
                return View("Index");
            }
            else
            {
                MicroForum_NetCore.Models.Dados.mtdApagarPosts(iId);
//                return View("ListarPosts", Dados.PostsRetornar());
                return RedirectToAction("ListarPosts", Dados.PostsRetornar());
            }
        }
        //
        //---------------------------------------------------------------------
        //

/*
        //--------------------------------------------------------------------
        //               ANTIGO CODIGO ORIGINAL
        //
        //---------------------------------------------------------------------
        //
        //VIEWS DOS CLIENTES
        //
        //---------------------------------------------------------------------
        public IActionResult ListarClientes()
        {
            // apresenta a lista de clientes
            return View(Dados.ClientesRetornar());
        }
        //---------------------------------------------------------------------
        //    ADICIONAR CLIENTE
        //---------------------------------------------------------------------
        //
        public IActionResult AdicionarCliente()
        {
            //adicionar um novo Cliente
            return View();
        }
        //---------------------------------------------------------------------
        [HttpPost]
        public IActionResult AdicionarClientes(Cliente c)
        {
            //chamar o metodo no Models para adicionar cliente
            Dados.AdicionarCliente(c);
            return RedirectToAction("AdicionarCliente");
        }
        //---------------------------------------------------------------------
        //    ALTERAR CLIENTE
        //---------------------------------------------------------------------
        //
        public IActionResult AlterarCliente(int id)
        {
            // alterar o cliente selecionado
            return View(Dados.DadosCliente(id));            
        }
        //---------------------------------------------------------------------
        public IActionResult AlterarClienteGravar(Cliente c)
        {
            //VERIFICAR CLIENTE ALTERADO
            return View(c);
        }
        //---------------------------------------------------------------------
        [HttpPost]
        public IActionResult AlterarClienteGravar1(Cliente c)
        {
            return RedirectToAction("AlterarClienteGravar",c);
        }
        //---------------------------------------------------------------------
        //    EXCLUIR CLIENTE
        //---------------------------------------------------------------------
        //
        public IActionResult ApagarClientePerguntar(int id)
        {
            // alterar o cliente selecionado
            return View(id);
        }
        //---------------------------------------------------------------------
        public IActionResult ApagarCliente(int id)
        {
            Dados.ApagarCliente(id);
            return RedirectToAction("ListarClientes");
        }
        //
        //---------------------------------------------------------------------
        //           
 

        public IActionResult ProdutoListar()
        {
            // apresenta a lista de Produto
            return View(ProdutoDados.ProdutosRetornar());
        }
        //---------------------------------------------------------------------
        //    ADICIONAR PRODUTO
        //---------------------------------------------------------------------
        //
        public IActionResult ProdutoAdicionar()
        {
            //adicionar um novo Produto
            return View();
        }
        //---------------------------------------------------------------------
        [HttpPost]
        public IActionResult ProdutosAdicionar(Produto p)
        {
            //chamar o metodo no Models para adicionar Produto
            //ProdutoDados.ProdutoAdicionar(p);
            return RedirectToAction("ProdutoAdicionarGravar",p);
        }
        //---------------------------------------------------------------------
        public IActionResult ProdutoAdicionarGravar(Produto p)
        {
            //vERIFICAR PRODUTO ALTERADO
            return View(p);
        }
        //---------------------------------------------------------------------
        [HttpPost]
        public IActionResult ProdutoAdicionarGravar1(Produto p)
        {
            return RedirectToAction("ProdutoAdicionarGravar", p);
        }

        //---------------------------------------------------------------------
        //    ALTERAR PRODUTO
        //---------------------------------------------------------------------
        //
        public IActionResult ProdutoAlterar(int id)
        {
            // alterar o Produto selecionado
            return View(ProdutoDados.ProdutoRetornarDados(id));
        }
        //---------------------------------------------------------------------
        public IActionResult ProdutoAlterarGravar(Produto p)
        {
            //vERIFICAR PRODUTO ALTERADO
            return View(p);
        }
        //---------------------------------------------------------------------
        [HttpPost]
        public IActionResult ProdutoAlterarGravar1(Produto p)
        {
            return RedirectToAction("ProdutoAlterarGravar", p);
        }
        //---------------------------------------------------------------------
        //    EXCLUIR PRODUTO
        //---------------------------------------------------------------------
        //
        public IActionResult ProdutoApagarPerguntar(int id)
        {
            // alterar o Produto Selecionado
            return View(id);
        }
        //---------------------------------------------------------------------
        public IActionResult ProdutoApagar(int id)
        {
            ProdutoDados.ProdutoApagar(id);
            return RedirectToAction("ProdutoListar");
        }

*/
    }

}