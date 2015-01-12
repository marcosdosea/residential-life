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
    ///This is a test class for GerenciadorGrupoPlanoDeContasTest and is intended
    ///to contain all GerenciadorGrupoPlanoDeContasTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorGrupoPlanoDeContasTest
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
        ///A test for GerenciadorGrupoPlanoDeContas Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorGrupoPlanoDeContasConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorGrupoPlanoDeContas Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorGrupoPlanoDeContasConstructorTest1()
        {
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorGrupoPlanoDeContas_Accessor target = new GerenciadorGrupoPlanoDeContas_Accessor(); // TODO: Initialize to an appropriate value
            GrupoPlanoDeContasModel grupoModel = null; // TODO: Initialize to an appropriate value
            tb_grupoplanocontas grupoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(grupoModel, grupoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            GrupoPlanoDeContasModel grupo = target.Obter(1);
            grupo.Descricao = "Despesas Natalinas";
            target.Editar(grupo);
            Assert.AreSame("Despesas Natalinas", grupo.Descricao);
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorGrupoPlanoDeContas_Accessor target = new GerenciadorGrupoPlanoDeContas_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<GrupoPlanoDeContasModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<GrupoPlanoDeContasModel> actual;
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
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            GrupoPlanoDeContasModel grupo = new GrupoPlanoDeContasModel();
            grupo.IdGrupoPlanoDeConta = 1;
            grupo.TipoPlanoDeConta = ListaTipoPlanoConta.Despesa;
            grupo.Descricao = "Despesas Administrativas";
            try
            {
                target.Inserir(grupo);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            GrupoPlanoDeContasModel obterGrupo = target.Obter(1);
            Assert.IsNotNull(obterGrupo);
            Assert.IsInstanceOfType(obterGrupo, typeof(GrupoPlanoDeContasModel));
            Assert.AreEqual(obterGrupo, grupo);  
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            GrupoPlanoDeContasModel grupo = target.Obter(1);
            GrupoPlanoDeContasModel actual = new GrupoPlanoDeContasModel();
            actual.IdGrupoPlanoDeConta = 1;
            actual.TipoPlanoDeConta = ListaTipoPlanoConta.Despesa;
            actual.Descricao = "Despesas Administrativas";
            actual = target.Obter(actual.IdGrupoPlanoDeConta);
            Assert.AreEqual(actual, grupo);
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            IEnumerable<GrupoPlanoDeContasModel> esperado = target.ObterTodos();
            List<GrupoPlanoDeContasModel> atual = new List<GrupoPlanoDeContasModel>();
            GrupoPlanoDeContasModel grupo = new GrupoPlanoDeContasModel();
            grupo.IdGrupoPlanoDeConta = 1;
            grupo.TipoPlanoDeConta = ListaTipoPlanoConta.Despesa;
            grupo.Descricao = "Despesas Administrativas";
            atual.Add(grupo);
            Assert.AreEqual(esperado, atual);
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorGrupoPlanoDeContas target = new GerenciadorGrupoPlanoDeContas();
            GrupoPlanoDeContasModel grupo = target.Obter(1);
            Assert.AreSame(grupo.IdGrupoPlanoDeConta, 1);
            grupo.IdGrupoPlanoDeConta = 1;
            target.Remover(grupo.IdGrupoPlanoDeConta);
        }
    }
}
