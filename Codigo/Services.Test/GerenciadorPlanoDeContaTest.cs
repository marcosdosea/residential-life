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
    ///This is a test class for GerenciadorPlanoDeContaTest and is intended
    ///to contain all GerenciadorPlanoDeContaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorPlanoDeContaTest
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
        ///A test for GerenciadorPlanoDeConta Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPlanoDeContaConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorPlanoDeConta Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPlanoDeContaConstructorTest1()
        {
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorPlanoDeConta_Accessor target = new GerenciadorPlanoDeConta_Accessor(); // TODO: Initialize to an appropriate value
            PlanoDeContaModel planoDeContaModel = null; // TODO: Initialize to an appropriate value
            tb_planodeconta planoDeContaE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(planoDeContaModel, planoDeContaE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(); // TODO: Initialize to an appropriate value
            PlanoDeContaModel planoDeContaModel = null; // TODO: Initialize to an appropriate value
            target.Editar(planoDeContaModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorPlanoDeConta_Accessor target = new GerenciadorPlanoDeConta_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<PlanoDeContaModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<PlanoDeContaModel> actual;
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
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(); // TODO: Initialize to an appropriate value
            PlanoDeContaModel planoDeContaModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(planoDeContaModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(); // TODO: Initialize to an appropriate value
            int idPlanoDeConta = 0; // TODO: Initialize to an appropriate value
            PlanoDeContaModel expected = null; // TODO: Initialize to an appropriate value
            PlanoDeContaModel actual;
            actual = target.Obter(idPlanoDeConta);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(); // TODO: Initialize to an appropriate value
            IEnumerable<PlanoDeContaModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<PlanoDeContaModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorPlanoDeConta target = new GerenciadorPlanoDeConta(); // TODO: Initialize to an appropriate value
            int idPlanoDeConta = 0; // TODO: Initialize to an appropriate value
            target.Remover(idPlanoDeConta);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
