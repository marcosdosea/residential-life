using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using Persistence;
using System.Collections;

namespace Services.Test
{


    /// <summary>
    ///This is a test class for GerenciadorPostagemTest and is intended
    ///to contain all GerenciadorPostagemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorPostagemTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for GerenciadorPostagem Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPostagemConstructorTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorPostagem Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPostagemConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorPostagem target = new GerenciadorPostagem(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }


        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorPostagem_Accessor target = new GerenciadorPostagem_Accessor(); // TODO: Initialize to an appropriate value
            PostagemModel PostagemModel = null; // TODO: Initialize to an appropriate value
            tb_postagem PostagemE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(PostagemModel, PostagemE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverValidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            PostagemModel postagemActual = gerenciadorPostagem.Obter(4);
            gerenciadorPostagem.Remover(4);
            PostagemModel novaPostagem = gerenciadorPostagem.Obter(4);
            Assert.IsNull(novaPostagem);
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverInvalidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            try
            {
                gerenciadorPostagem.Remover(1);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            PostagemModel novaPostagem = gerenciadorPostagem.Obter(1);
            Assert.IsNotNull(novaPostagem);
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaValidoTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            int idPessoa = 17;
            IEnumerable<PostagemModel> actual = target.ObterTodosPorPessoa(idPessoa);
            Assert.Equals(2, actual.Count());
            foreach (var postagem in actual)
            {
                Assert.Equals(postagem.IdPessoa, idPessoa);
            }
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaInvalidoTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            int idPessoa = -1;
            IEnumerable<PostagemModel> actual = target.ObterTodosPorPessoa(idPessoa);
            Assert.Equals(0, actual.Count());
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            IEnumerable<PostagemModel> actual = target.ObterTodos();
            Assert.Equals(2, actual.Count());
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<PostagemModel>));
        }


        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            PostagemModel postagem = target.Obter(1);
            Assert.IsNotNull(postagem);
            Assert.Equals(postagem.IdPessoa, 17);
            Assert.Equals(postagem.IdPostagem, 1);
            Assert.Equals(postagem.Titulo, "Manuntenção Elevador");
            Assert.Equals(postagem.Descricao, "O elevador se encontra com problemas");
            Assert.Equals(postagem.DataPublicacao, "2014-12-09 10:52:22");
            Assert.Equals(postagem.DataExclusao, "2014-11-22 00:00:00");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem();
            PostagemModel postagemAlvo = target.Obter(-1);
            Assert.IsNull(postagemAlvo);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirValidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            PostagemModel postagem = new PostagemModel();
            postagem.DataPublicacao = DateTime.Now;
            postagem.DataExclusao = Convert.ToDateTime("22/12/2014");
            postagem.Descricao = "Problema com o porteiro.";
            postagem.Titulo = "Porteiro mal educado";
            int actual = gerenciadorPostagem.Inserir(postagem);
            Assert.IsTrue(actual > 0);
            PostagemModel postagemInserida = gerenciadorPostagem.Obter(actual);
            Assert.IsNotNull(postagemInserida);
            Assert.Equals(postagem.Titulo, postagemInserida.Titulo);
            Assert.Equals(postagem.Descricao, postagemInserida.Descricao);
            Assert.Equals(postagem.DataPublicacao, postagemInserida.DataPublicacao);
            Assert.Equals(postagem.DataExclusao, postagemInserida.DataExclusao);
            Assert.Equals(gerenciadorPostagem.ObterTodos().Count(), 3);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            PostagemModel postagem = new PostagemModel();
            postagem.DataPublicacao = DateTime.Now;
            postagem.DataExclusao = Convert.ToDateTime("22/12/2014");
            postagem.Descricao = null;
            postagem.Titulo = "Porteiro mal educado";
            int actual = 0;
            try
            {
                actual = gerenciadorPostagem.Inserir(postagem);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            PostagemModel postagemInserida = gerenciadorPostagem.Obter(actual);
            Assert.IsNull(postagemInserida);
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorPostagem_Accessor target = new GerenciadorPostagem_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<PostagemModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<PostagemModel> actual;
            actual = target.GetQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            PostagemModel postagemAlvo = gerenciadorPostagem.Obter(1);
            postagemAlvo.Titulo = "Mudar Porteiro.";
            postagemAlvo.Descricao = "O porteiro é muito antipático";
            gerenciadorPostagem.Editar(postagemAlvo);
            PostagemModel novaPostagem = gerenciadorPostagem.Obter(postagemAlvo.IdPostagem);
            Assert.IsNotNull(novaPostagem);
            Assert.Equals(postagemAlvo.Titulo, novaPostagem.Titulo);
            Assert.Equals(postagemAlvo.Descricao, novaPostagem.Descricao);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorPostagem gerenciadorPostagem = new GerenciadorPostagem();
            PostagemModel postagemActual = gerenciadorPostagem.Obter(1);
            postagemActual.Titulo = null;
            postagemActual.Descricao = "O porteiro é muito antipático";
            try
            {
                gerenciadorPostagem.Editar(postagemActual);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            PostagemModel nova = gerenciadorPostagem.Obter(1);
            Assert.IsNotNull(nova.Titulo);
        }
    }
}
