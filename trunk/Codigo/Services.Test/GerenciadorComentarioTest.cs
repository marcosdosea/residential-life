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
    ///This is a test class for GerenciadorComentarioTest and is intended
    ///to contain all GerenciadorComentarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorComentarioTest
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
            GerenciadorComentario target = new GerenciadorComentario();
            int idComentario = 1;
            target.Remover(idComentario);
            ComentarioModel comentario = target.Obter(idComentario);
            Assert.IsNull(comentario);
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaValidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPessoa = 17;
            IEnumerable<ComentarioModel> expected = target.ObterPorPostagem(idPessoa);
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagem(idPessoa);
            Assert.AreEqual(expected, actual);
            foreach (var comentario in actual)
            {
                Assert.Equals(idPessoa, comentario.IdPessoa);
            }
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaInvalidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPessoa = -1;
            IEnumerable<ComentarioModel> expected = null;
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagem(idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> expected = target.ObterTodos();
            IEnumerable<ComentarioModel> actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<ComentarioModel>));
        }

        /// <summary>
        ///A test for ObterPorPostagemPessoa
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemPessoaValidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPostagem = 1;
            int idPessoa = 17;
            IEnumerable<ComentarioModel> expected = target.ObterPorPostagemPessoa(idPostagem, idPessoa);
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagemPessoa(idPostagem, idPessoa);
            Assert.AreEqual(expected, actual);
            foreach (var comentario in actual)
            {
                Assert.Equals(idPostagem, comentario.IdPostagem);
            }
        }

        /// <summary>
        ///A test for ObterPorPostagemPessoa
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemPessoaInvalidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPostagem = 0;
            int idPessoa = 17;
            IEnumerable<ComentarioModel> expected = null;
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagemPessoa(idPostagem, idPessoa);
            Assert.IsNull(actual);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for ObterPorPostagem
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemValidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPostagem = 1;
            IEnumerable<ComentarioModel> expected = target.ObterPorPostagem(idPostagem);
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagem(idPostagem);
            Assert.AreEqual(expected, actual);
            foreach (var comentario in actual)
            {
                Assert.Equals(idPostagem, comentario.IdPostagem);
            }
        }

        /// <summary>
        ///A test for ObterPorPostagem
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemInvalidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            int idPostagem = -1;
            IEnumerable<ComentarioModel> expected = target.ObterPorPostagem(idPostagem);
            IEnumerable<ComentarioModel> actual = target.ObterPorPostagem(idPostagem);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            ComentarioModel comentario = target.Obter(1);
            ComentarioModel comentarioAlvo = target.Obter(1);
            Assert.IsNotNull(comentarioAlvo);
            Assert.Equals(comentarioAlvo.IdPostagem, comentario.IdPostagem);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            ComentarioModel comentario = target.Obter(-1);
            ComentarioModel esperado = null;
            Assert.IsNull(comentario);
            Assert.AreEqual(comentario, esperado);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirValidoTest()
        {
            GerenciadorComentario targetComentario = new GerenciadorComentario();
            ComentarioModel comentario = new ComentarioModel();
            comentario.Data = DateTime.Now;
            comentario.Comentario = "Vale a pena se o valor for baixo.";
            comentario.IdPessoa = 18;
            comentario.IdPostagem = 1;
            int actual = targetComentario.Inserir(comentario);
            Assert.IsTrue(actual > 0);
            ComentarioModel comentarioInserido = targetComentario.Obter(actual);
            Assert.IsNotNull(comentarioInserido);
            Assert.AreSame(comentario, comentarioInserido);
            Assert.Equals(comentario.Comentario, comentarioInserido.Comentario);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorComentario targetComentario = new GerenciadorComentario();
            ComentarioModel comentario = new ComentarioModel();
            comentario.Data = DateTime.Now;
            comentario.Comentario = null;
            comentario.IdPessoa = 18;
            comentario.IdPostagem = 1;
            int actual = 0;
            try
            {
                actual = targetComentario.Inserir(comentario);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            ComentarioModel comentarioInserido = targetComentario.Obter(actual);
            Assert.IsNull(comentarioInserido);
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorComentario_Accessor target = new GerenciadorComentario_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<ComentarioModel> actual;
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
            GerenciadorComentario target = new GerenciadorComentario();
            ComentarioModel comentario = target.Obter(1);
            ComentarioModel comentarioEsperado = comentario;
            comentarioEsperado.Comentario = "Quanto custa?";
            target.Editar(comentarioEsperado);
            ComentarioModel actual = target.Obter(1);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual, comentarioEsperado);
            Assert.AreSame(actual, comentarioEsperado);
            Assert.Equals(comentarioEsperado.Comentario, actual.Comentario);
            Assert.AreNotEqual(comentario, actual);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            ComentarioModel comentario = target.Obter(1);
            ComentarioModel comentarioEsperado = comentario;
            comentarioEsperado.Comentario = null;
            try
            {
                target.Editar(comentarioEsperado);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ServiceException));
            }
            ComentarioModel actual = target.Obter(1);
            Assert.Equals(actual.Comentario, comentario.Comentario);
            Assert.AreNotEqual(comentarioEsperado, actual);
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorComentario_Accessor target = new GerenciadorComentario_Accessor(); // TODO: Initialize to an appropriate value
            ComentarioModel comentarioModel = null; // TODO: Initialize to an appropriate value
            tb_comentario comentarioE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(comentarioModel, comentarioE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GerenciadorComentario Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorComentarioConstructorTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorComentario Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorComentarioConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorComentario target = new GerenciadorComentario(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
