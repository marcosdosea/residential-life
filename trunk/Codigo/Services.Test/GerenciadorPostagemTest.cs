using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using Persistence;

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
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            int idPostagem = 0; // TODO: Initialize to an appropriate value
            target.Remover(idPostagem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            int idPessoa = 0; // TODO: Initialize to an appropriate value
            IEnumerable<PostagemModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<PostagemModel> actual;
            actual = target.ObterTodosPorPessoa(idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            IEnumerable<PostagemModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<PostagemModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            int idPostagem = 0; // TODO: Initialize to an appropriate value
            PostagemModel expected = null; // TODO: Initialize to an appropriate value
            PostagemModel actual;
            actual = target.Obter(idPostagem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            PostagemModel PostagemModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(PostagemModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
        public void EditarTest()
        {
            GerenciadorPostagem target = new GerenciadorPostagem(); // TODO: Initialize to an appropriate value
            PostagemModel PostagemModel = null; // TODO: Initialize to an appropriate value
            target.Editar(PostagemModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
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
    }
}
