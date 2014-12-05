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
    ///This is a test class for GerenciadorVeiculoTest and is intended
    ///to contain all GerenciadorVeiculoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorVeiculoTest
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
        ///A test for GerenciadorVeiculo Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorVeiculoConstructorTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorVeiculo Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorVeiculoConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorVeiculo target = new GerenciadorVeiculo(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorVeiculo_Accessor target = new GerenciadorVeiculo_Accessor(); // TODO: Initialize to an appropriate value
            VeiculoModel veiculoModel = null; // TODO: Initialize to an appropriate value
            tb_veiculo veiculoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(veiculoModel, veiculoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            VeiculoModel veiculoModel = null; // TODO: Initialize to an appropriate value
            target.Editar(veiculoModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetInstance
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            GerenciadorVeiculo expected = null; // TODO: Initialize to an appropriate value
            GerenciadorVeiculo actual;
            actual = GerenciadorVeiculo.GetInstance();
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
            GerenciadorVeiculo_Accessor target = new GerenciadorVeiculo_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<VeiculoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<VeiculoModel> actual;
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
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            VeiculoModel veiculoModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(veiculoModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            int idVeiculo = 0; // TODO: Initialize to an appropriate value
            VeiculoModel expected = null; // TODO: Initialize to an appropriate value
            VeiculoModel actual;
            actual = target.Obter(idVeiculo);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            IEnumerable<VeiculoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<VeiculoModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodosDePessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosDePessoaTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            int idPessoa = 0; // TODO: Initialize to an appropriate value
            IEnumerable<VeiculoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<VeiculoModel> actual;
            actual = target.ObterTodosDePessoa(idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo(); // TODO: Initialize to an appropriate value
            int idVeiculo = 0; // TODO: Initialize to an appropriate value
            target.Remover(idVeiculo);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
