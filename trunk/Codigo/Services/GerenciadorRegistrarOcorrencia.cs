using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;
namespace Services
{

    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Registrar Ocorrencia
    /// </summary>
    public class GerenciadorRegistrarOcorrencia
    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorRegistrarOcorrencia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorRegistrarOcorrencia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="RegistrarOcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(RegistrarOcorrenciaModel AreaPublicaModel)
        {
            tb_ocorrencia RegistrarOcorrenciaE = new tb_ocorrencia();
            Atribuir(AreaPublicaModel, RegistrarOcorrenciaE);
            unitOfWork.RepositorioRegistrarOcorrencia.Inserir(RegistrarOcorrenciaE);
            unitOfWork.Commit(shared);
            return RegistrarOcorrenciaE.IdOcorrencia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="RegistrarOcorrenciaModel"></param>
        public void Editar(RegistrarOcorrenciaModel RegistrarOcorrenciaModel)
        {
            tb_ocorrencia RegistrarOcorrenciaE = new tb_ocorrencia();
            Atribuir(RegistrarOcorrenciaModel, RegistrarOcorrenciaE);
            unitOfWork.RepositorioRegistrarOcorrencia.Editar(RegistrarOcorrenciaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="RegistrarOcorrenciaModel"> Dados do modelo</param>
        public void Remover(int idRegistrarOcorrencia)
        {
            unitOfWork.RepositorioRegistrarOcorrencia.Remover(RegistrarOcorrencia => RegistrarOcorrencia.IdOcorrencia.Equals(idRegistrarOcorrencia));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<RegistrarOcorrenciaModel> GetQuery()
        {
            IQueryable<tb_ocorrencia> tb_ocorrencia = unitOfWork.RepositorioRegistrarOcorrencia.GetQueryable();
            var query = from registrarOcorrencia in tb_ocorrencia
                        select new RegistrarOcorrenciaModel
                        {
                            IdOcorrencia = registrarOcorrencia.IdOcorrencia,
                            IdPessoa = registrarOcorrencia.IdPessoa,
                            Titulo = registrarOcorrencia.Titulo,
                            Descricao = registrarOcorrencia.Descricao,
                            Data = registrarOcorrencia.DataCriacao,
                            IdTipo = registrarOcorrencia.IdTipoOcorrencia,
                            IdStatus = registrarOcorrencia.IdStatusOcorrencia,

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RegistrarOcorrenciaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém o registro de uma ocorrencia
        /// </summary>
        /// <param name="idRegitroOcorrencia">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public RegistrarOcorrenciaModel Obter(int idRegistrarOcorrencia)
        {
            IEnumerable<RegistrarOcorrenciaModel> RegistrarOcorrenciaE = GetQuery().Where(RegistrarOcorrenciaModel => RegistrarOcorrenciaModel.IdOcorrencia.Equals(idRegistrarOcorrencia));
            return RegistrarOcorrenciaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="RegistrarOcorrenciaModel">Objeto do modelo</param>
        /// <param name="RegistrarOcorrenciaE">Entity mapeada da base de dados</param>
        private void Atribuir(RegistrarOcorrenciaModel RegistrarOcorrenciaModel, tb_ocorrencia RegistrarOcorrenciaE)
        {
            RegistrarOcorrenciaE.IdOcorrencia = RegistrarOcorrenciaModel.IdOcorrencia;
            RegistrarOcorrenciaE.IdPessoa = RegistrarOcorrenciaModel.IdPessoa;
            RegistrarOcorrenciaE.Titulo = RegistrarOcorrenciaModel.Titulo;
            RegistrarOcorrenciaE.Descricao = RegistrarOcorrenciaModel.Descricao;
            RegistrarOcorrenciaE.IdTipoOcorrencia = RegistrarOcorrenciaModel.IdTipo;
            RegistrarOcorrenciaE.DataCriacao = RegistrarOcorrenciaModel.Data;
            RegistrarOcorrenciaE.IdStatusOcorrencia = RegistrarOcorrenciaModel.IdStatus;

        }

    }
}
