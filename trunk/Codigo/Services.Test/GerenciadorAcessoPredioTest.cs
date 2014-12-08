using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Persistence;
using Models;
using System.Linq;
using System.Collections.Generic;

namespace Services.Test
{
    
    
    /// <summary>
    ///This is a test class for GerenciadorAcessoPredioTest and is intended
    ///to contain all GerenciadorAcessoPredioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorAcessoPredioTest
    {

        /*
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
        ///A test for GerenciadorAcessoPredio Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorAcessoPredioConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorAcessoPredio Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorAcessoPredioConstructorTest1()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorAcessoPredio_Accessor target = new GerenciadorAcessoPredio_Accessor(); // TODO: Initialize to an appropriate value
            AcessoPredioModel AcessoPredioModel = null; // TODO: Initialize to an appropriate value
            tb_acessocondominio AcessoPredioE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(AcessoPredioModel, AcessoPredioE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            AcessoPredioModel acessoPredioModel = null; // TODO: Initialize to an appropriate value
            target.Editar(acessoPredioModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorAcessoPredio_Accessor target = new GerenciadorAcessoPredio_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<AcessoPredioModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<AcessoPredioModel> actual;
            actual = target.GetQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            AcessoPredioModel acessoPredioModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(acessoPredioModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            int idAcessoPredio = 0; // TODO: Initialize to an appropriate value
            AcessoPredioModel expected = null; // TODO: Initialize to an appropriate value
            AcessoPredioModel actual;
            actual = target.Obter(idAcessoPredio);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            IEnumerable<AcessoPredioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<AcessoPredioModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            int idPessoa = 0; // TODO: Initialize to an appropriate value
            IEnumerable<AcessoPredioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<AcessoPredioModel> actual;
            actual = target.ObterTodosPorPessoa(idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorAcessoPredio target = new GerenciadorAcessoPredio(); // TODO: Initialize to an appropriate value
            int idAcessoPredio = 0; // TODO: Initialize to an appropriate value
            target.Remover(idAcessoPredio);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        } */
    }
}
