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
    ///This is a test class for GerenciadorBlocoTest and is intended
    ///to contain all GerenciadorBlocoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorBlocoTest
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
        

        private GerenciadorBloco gerenciadorBloco;

        [TestInitialize()]
        public void Inicializar()
        {
            gerenciadorBloco = new GerenciadorBloco();
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            BlocoModel actual = gerenciadorBloco.ObterTodos().ElementAtOrDefault(0);
            if (actual.Equals(null))
            {
                Assert.Fail("Não pode remover, por que não há blocos cadastrados.");
            }
            else
            {
                int idBloco = actual.IdBloco; // TODO: Initialize to an appropriate value
                gerenciadorBloco.Remover(idBloco);
                //Assert.
            }
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            IEnumerable<BlocoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<BlocoModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterPorCondominio
        ///</summary>
        [TestMethod()]
        public void ObterPorCondominioTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            int idCondominio = 0; // TODO: Initialize to an appropriate value
            IEnumerable<BlocoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<BlocoModel> actual;
            actual = target.ObterPorCondominio(idCondominio);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            int idBloco = 0; // TODO: Initialize to an appropriate value
            BlocoModel expected = null; // TODO: Initialize to an appropriate value
            BlocoModel actual;
            actual = target.Obter(idBloco);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            BlocoModel blocoModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(blocoModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /*
        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorBloco_Accessor target = new GerenciadorBloco_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<BlocoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<BlocoModel> actual;
            actual = target.GetQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        } 

        /// <summary>
        ///A test for GetInstance
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            GerenciadorBloco expected = null; // TODO: Initialize to an appropriate value
            GerenciadorBloco actual;
            actual = GerenciadorBloco.GetInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        } 

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            BlocoModel blocoModel = null; // TODO: Initialize to an appropriate value
            target.Editar(blocoModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /*
        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            BlocoModel blocoModel = null; // TODO: Initialize to an appropriate value
            tb_bloco blocoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(blocoModel, blocoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GerenciadorBloco Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorBlocoConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorBloco target = new GerenciadorBloco(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorBloco Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorBlocoConstructorTest1()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }*/
    }
}
