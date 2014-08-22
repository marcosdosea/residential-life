using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;
namespace Services
{

    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Registrar Ocorrencia
    /// </summary>
    public class GerenciadorOcorrencia
    {
        
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorOcorrencia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorOcorrencia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="OcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(OcorrenciaModel ocorrenciaModel)
        {
            tb_ocorrencia OcorrenciaE = new tb_ocorrencia();
            Atribuir(ocorrenciaModel, OcorrenciaE);
            unitOfWork.RepositorioOcorrencia.Inserir(OcorrenciaE);
            unitOfWork.Commit(shared);
            return OcorrenciaE.IdOcorrencia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="OcorrenciaModel"></param>
        public void Editar(OcorrenciaModel OcorrenciaModel)
        {
            tb_ocorrencia OcorrenciaE = new tb_ocorrencia();
            Atribuir(OcorrenciaModel, OcorrenciaE);
            unitOfWork.RepositorioOcorrencia.Editar(OcorrenciaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="OcorrenciaModel"> Dados do modelo</param>
        public void Remover(int idOcorrencia)
        {
            unitOfWork.RepositorioOcorrencia.Remover(Ocorrencia => Ocorrencia.IdOcorrencia.Equals(idOcorrencia));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<OcorrenciaModel> GetQuery()
        {
            IQueryable<tb_pessoa> tb_pessoa = unitOfWork.RepositorioPessoa.GetQueryable();
            IQueryable<tb_ocorrencia> tb_ocorrencia = unitOfWork.RepositorioOcorrencia.GetQueryable();
            var query = from Ocorrencia in tb_ocorrencia
                        join Pessoa in tb_pessoa
                        on Ocorrencia.IdPessoa equals Pessoa.IdPessoa
                        select new OcorrenciaModel
                        {
                            IdOcorrencia = Ocorrencia.IdOcorrencia,
                            IdPessoa = Ocorrencia.IdPessoa,
                            Titulo = Ocorrencia.Titulo,
                            Descricao = Ocorrencia.Descricao,
                            Data = Ocorrencia.DataCriacao,
                            TipoOcorrencia = (Ocorrencia.TipoOcorrencia == "Barulho" ? Models.OcorrenciaModel.ListaTipoOcorrencia.Barulho : (Ocorrencia.TipoOcorrencia == "DanoAoPatrimonio" ? Models.OcorrenciaModel.ListaTipoOcorrencia.DanoAoPatrimonio : (Ocorrencia.TipoOcorrencia == "Outros" ? Models.OcorrenciaModel.ListaTipoOcorrencia.Outros : OcorrenciaModel.ListaTipoOcorrencia.Roubo))),
                            StatusOcorrencia = (Ocorrencia.StatusOcorrencia == "EmAnalise" ? Models.OcorrenciaModel.ListaStatusOcorrencia.EmAnalise : (Ocorrencia.StatusOcorrencia == "EmExecucao" ? Models.OcorrenciaModel.ListaStatusOcorrencia.EmExecucao : (Ocorrencia.StatusOcorrencia == "Finalizada" ? Models.OcorrenciaModel.ListaStatusOcorrencia.Finalizada : OcorrenciaModel.ListaStatusOcorrencia.Rresolvida))),
                            NomePessoa = Pessoa.Nome
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OcorrenciaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OcorrenciaModel> ObterTodosPorPessoa(int idPessoa)
        {
            return GetQuery().Where(ocorrencia => ocorrencia.IdPessoa.Equals(idPessoa));
        }


        /// <summary>
        /// Obtém o registro de uma ocorrencia
        /// </summary>
        /// <param name="idRegitroOcorrencia">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public OcorrenciaModel Obter(int idOcorrencia)
        {
            IEnumerable<OcorrenciaModel> OcorrenciaE = GetQuery().Where(OcorrenciaModel => OcorrenciaModel.IdOcorrencia.Equals(idOcorrencia));
            return OcorrenciaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="OcorrenciaModel">Objeto do modelo</param>
        /// <param name="OcorrenciaE">Entity mapeada da base de dados</param>
        private void Atribuir(OcorrenciaModel OcorrenciaModel, tb_ocorrencia OcorrenciaE)
        {
            OcorrenciaE.IdOcorrencia = OcorrenciaModel.IdOcorrencia;
            OcorrenciaE.IdPessoa = OcorrenciaModel.IdPessoa;
            OcorrenciaE.Titulo = OcorrenciaModel.Titulo;
            OcorrenciaE.Descricao = OcorrenciaModel.Descricao;            
            OcorrenciaE.DataCriacao = OcorrenciaModel.Data;
            OcorrenciaE.TipoOcorrencia = OcorrenciaModel.TipoOcorrencia.ToString();
            OcorrenciaE.StatusOcorrencia = OcorrenciaModel.StatusOcorrencia.ToString();

        }
    }
}
