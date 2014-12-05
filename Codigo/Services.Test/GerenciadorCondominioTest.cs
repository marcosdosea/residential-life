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
    ///This is a test class for GerenciadorCondominioTest and is intended
    ///to contain all GerenciadorCondominioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorCondominioTest
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
        ///A test for GerenciadorCondominio Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorCondominioConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorCondominio target = new GerenciadorCondominio(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorCondominio Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorCondominioConstructorTest1()
        {
            GerenciadorCondominio target = new GerenciadorCondominio();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorCondominio_Accessor target = new GerenciadorCondominio_Accessor(); // TODO: Initialize to an appropriate value
            CondominioModel condominioModel = null; // TODO: Initialize to an appropriate value
            tb_condominio condominioE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(condominioModel, condominioE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorCondominio target = new GerenciadorCondominio(); // TODO: Initialize to an appropriate value
            CondominioModel condominioModel = null; // TODO: Initialize to an appropriate value
            target.Editar(condominioModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetInstance
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            GerenciadorCondominio expected = null; // TODO: Initialize to an appropriate value
            GerenciadorCondominio actual;
            actual = GerenciadorCondominio.GetInstance();
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
            GerenciadorCondominio_Accessor target = new GerenciadorCondominio_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<CondominioModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<CondominioModel> actual;
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
            GerenciadorCondominio target = new GerenciadorCondominio(); // TODO: Initialize to an appropriate value
            CondominioModel condominioModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(condominioModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorCondominio target = new GerenciadorCondominio(); // TODO: Initialize to an appropriate value
            int idCondominio = 0; // TODO: Initialize to an appropriate value
            CondominioModel expected = null; // TODO: Initialize to an appropriate value
            CondominioModel actual;
            actual = target.Obter(idCondominio);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorCondominio target = new GerenciadorCondominio(); // TODO: Initialize to an appropriate value
            IEnumerable<CondominioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<CondominioModel> actual;
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
            GerenciadorCondominio target = new GerenciadorCondominio(); // TODO: Initialize to an appropriate value
            int idCondominio = 0; // TODO: Initialize to an appropriate value
            target.Remover(idCondominio);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
