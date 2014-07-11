using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorTipoOcorrencia
    {
        /*
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorTipoOcorrencia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorTipoOcorrencia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="statusOcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(TipoOcorrenciaModel tipoOcorrenciaModel)
        {
            tb_tipoocorrencia tipoOcorrenciaModelE = new tb_tipoocorrencia();
            Atribuir(tipoOcorrenciaModel, tipoOcorrenciaModelE);
            unitOfWork.RepositorioTipoOcorrencia.Inserir(tipoOcorrenciaModelE);
            unitOfWork.Commit(shared);
            return tipoOcorrenciaModelE.IdTipoOcorrencia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(TipoOcorrenciaModel tipoOcorrenciaModel)
        {
            tb_tipoocorrencia tipoOcorrenciaModelE = new tb_tipoocorrencia();
            Atribuir(tipoOcorrenciaModel, tipoOcorrenciaModelE);
            unitOfWork.RepositorioTipoOcorrencia.Editar(tipoOcorrenciaModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusPagamentoModel">Identificador do pagamento na base de dados</param>
        public void Remover(int idTipoOcorrencia)
        {
            unitOfWork.RepositorioTipoOcorrencia.Remover(tipoOcorrencia => tipoOcorrencia.IdTipoOcorrencia.Equals(idTipoOcorrencia));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<TipoOcorrenciaModel> GetQuery()
        {
            IQueryable<tb_tipoocorrencia> tb_tipoocorrencia = unitOfWork.RepositorioTipoOcorrencia.GetQueryable();
            var query = from tipoOcorrencia in tb_tipoocorrencia
                        select new TipoOcorrenciaModel
                        {
                            IdTipoOcorrencia = tipoOcorrencia.IdTipoOcorrencia,
                            TipoOcorrencia = tipoOcorrencia.TipoOcorrencia
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoOcorrenciaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pagamento
        /// </summary>
        /// <param name="idStatusOcorrencia">Identificador do pagamento na base de dados</param>
        /// <returns>Pagamento model</returns>
        public TipoOcorrenciaModel Obter(int idTipoOcorrencia)
        {
            IEnumerable<TipoOcorrenciaModel> tipoOcorrenciaEs = GetQuery().Where(tipoOcorrencia => tipoOcorrencia.IdTipoOcorrencia.Equals(idTipoOcorrencia));
            return tipoOcorrenciaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Pagamento Model para o Pagamento Entity
        /// </summary>
        /// <param name="statusPagamentoModel">Objeto do modelo</param>
        /// <param name="statusPagamentoE">Entity mapeada da base de dados</param>
        private void Atribuir(TipoOcorrenciaModel tipoOcorrenciaModel, tb_tipoocorrencia tipoOcorrenciaE)
        {
            tipoOcorrenciaE.IdTipoOcorrencia = tipoOcorrenciaModel.IdTipoOcorrencia;
            tipoOcorrenciaE.TipoOcorrencia = tipoOcorrenciaModel.TipoOcorrencia;
         
   
        }*/
    }
}
