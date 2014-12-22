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
        public void EditarValidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel veiculo = target.Obter(3);
            veiculo.Modelo = "Ferrari - GT";
            target.Editar(veiculo);
            VeiculoModel actual = target.Obter(3);
            Assert.IsNotNull(actual);
            Assert.Equals(actual.Modelo, veiculo.Modelo);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel veiculo = target.Obter(3);
            veiculo.Modelo = null;
            try
            {
                target.Editar(veiculo);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            VeiculoModel actual = target.Obter(3);
            Assert.IsNotNull(actual.Modelo);
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
        public void InserirValidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel veiculo = new VeiculoModel();
            veiculo.Cor = "Vermelho";
            veiculo.IdPessoa = 17;
            veiculo.IdMoradia = 13;
            veiculo.TipoVeiculo = ListaTipoVeiculo.Carro;
            veiculo.Modelo = "Fiat Uno";
            veiculo.Placa = "WZA1414";
            int idVeiculo = target.Inserir(veiculo);
            Assert.IsTrue(idVeiculo > 0);
            VeiculoModel veiculoInserido = target.Obter(idVeiculo);
            Assert.IsNotNull(veiculoInserido);
            Assert.AreSame(veiculo, veiculoInserido);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel veiculo = new VeiculoModel();
            veiculo.Cor = "Vermelho";
            veiculo.IdPessoa = 17;
            veiculo.IdMoradia = 13;
            veiculo.TipoVeiculo = ListaTipoVeiculo.Carro;
            veiculo.Modelo = null;
            veiculo.Placa = "WZA1414";
            int actual = 0;
            try
            {
                actual = target.Inserir(veiculo);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            VeiculoModel veiculoInserido = target.Obter(actual);
            Assert.IsNull(veiculoInserido);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel expected = target.Obter(4);
            Assert.Equals(expected.IdPessoa, 16);
            Assert.Equals(expected.Placa, "NVK1120");
            Assert.Equals(expected.Modelo, "Siena");
            Assert.Equals(expected.Cor, "Prata");
            Assert.Equals(expected.TipoVeiculo, "Carro");
            Assert.Equals(expected.IdMoradia, 12);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            VeiculoModel actual = target.Obter(-1);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            IEnumerable<VeiculoModel> expected = target.ObterTodos();
            Assert.IsInstanceOfType(expected, typeof(IEnumerable<VeiculoModel>));
            Assert.Equals(expected.Count(), 3);
        }

        /// <summary>
        ///A test for ObterTodosDePessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosDePessoaValidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            int idPessoa = 17;
            IEnumerable<VeiculoModel> expected = target.ObterTodosDePessoa(idPessoa);
            Assert.Equals(expected.Count(), 1);
            foreach (var veiculo in expected)
            {
                Assert.Equals(idPessoa, veiculo.IdPessoa);
            }
        }

        /// <summary>
        ///A test for ObterTodosDePessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosDePessoaInvalidoTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            IEnumerable<VeiculoModel> actual = target.ObterTodosDePessoa(-1);
            Assert.Equals(actual.Count(), 0);
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorVeiculo target = new GerenciadorVeiculo();
            int idVeiculo = 5;
            target.Remover(idVeiculo);
            VeiculoModel veiculo = target.Obter(idVeiculo);
            Assert.IsNull(veiculo);
        } 
    }
}
