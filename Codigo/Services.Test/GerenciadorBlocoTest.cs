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
            GerenciadorBloco target = new GerenciadorBloco();
            int idBloco = 5;
            target.Remover(idBloco);
            BlocoModel bloco = target.Obter(idBloco);
            Assert.IsNull(bloco);
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            IEnumerable<BlocoModel> expected = target.ObterTodos();
            Assert.IsInstanceOfType(expected, typeof(IEnumerable<BlocoModel>));
            Assert.Equals(expected.Count(), 5);
        }

        /// <summary>
        ///A test for ObterPorCondominio
        ///</summary>
        [TestMethod()]
        public void ObterPorCondominioValidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            int idCondominio = 4;
            IEnumerable<BlocoModel> actual = target.ObterPorCondominio(idCondominio);
            Assert.Equals(actual.Count(), 2);
            foreach (var bloco in actual)
            {
                Assert.Equals(idCondominio, bloco.IdCondominio);
            }
        }

        /// <summary>
        ///A test for ObterPorCondominio
        ///</summary>
        [TestMethod()]
        public void ObterPorCondominioInvalidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            int idCondominio = -1;
            IEnumerable<BlocoModel> actual = target.ObterPorCondominio(idCondominio);
            Assert.Equals(actual.Count(), 0);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel actual = target.Obter(3);
            Assert.IsNotNull(actual);
            Assert.Equals(actual.IdCondominio, 3);
            Assert.Equals(actual.Nome, "Olimpo");
            Assert.Equals(actual.QuantidadeAndares, 12);
            Assert.Equals(actual.QuantidadeMoradias, 48);
            Assert.IsInstanceOfType(actual, typeof(BlocoModel));
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel actual = target.Obter(-1);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirValidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel bloco = new BlocoModel();
            bloco.IdCondominio = 3;
            bloco.Nome = "Templo de Era";
            bloco.QuantidadeAndares = 1;
            bloco.QuantidadeMoradias = 8;
            int idBloco = target.Inserir(bloco);
            Assert.IsTrue(idBloco > 0);
            BlocoModel blocoInserido = target.Obter(idBloco);
            Assert.IsNotNull(blocoInserido);
            Assert.Equals(bloco.IdCondominio, blocoInserido.IdCondominio);
            Assert.Equals(bloco.Nome, blocoInserido.Nome);
            Assert.Equals(bloco.QuantidadeAndares, blocoInserido.QuantidadeAndares);
            Assert.Equals(bloco.QuantidadeMoradias, blocoInserido.QuantidadeMoradias);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel bloco = new BlocoModel();
            bloco.IdCondominio = 3;
            bloco.Nome = null;
            bloco.QuantidadeAndares = 1;
            bloco.QuantidadeMoradias = 8;
            int actual = 0;
            try
            {
                actual = target.Inserir(bloco);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            BlocoModel blocoInserido = target.Obter(actual);
            Assert.IsNull(blocoInserido);
        }
        
        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorBloco_Accessor target = new GerenciadorBloco_Accessor();
            IQueryable<BlocoModel> expected = null;
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
        public void EditarValidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel bloco = target.Obter(6);
            bloco.Nome = "Rosa";
            target.Editar(bloco);
            BlocoModel actual = target.Obter(6);
            Assert.IsNotNull(actual);
            Assert.Equals(bloco.Nome, actual.Nome);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorBloco target = new GerenciadorBloco();
            BlocoModel bloco = target.Obter(6);
            bloco.Nome = null;
            try
            {
                target.Editar(bloco);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            BlocoModel actual = target.Obter(3);
            Assert.Equals(actual.Nome, bloco.Nome);
        }
        
        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorBloco target = new GerenciadorBloco(); // TODO: Initialize to an appropriate value
            //BlocoModel blocoModel = null; // TODO: Initialize to an appropriate value
            //tb_bloco blocoE = null; // TODO: Initialize to an appropriate value
            //target.Atribuir(blocoModel, blocoE);
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
        }
    }
}
