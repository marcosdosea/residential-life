using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorTipoVeiculo
    {
        /*
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorTipoVeiculo()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorTipoVeiculo(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="statusOcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(TipoVeiculoModel tipoVeiculoModel)
        {
            tb_tipoveiculo tipoVeiculoModelE = new tb_tipoveiculo();
            Atribuir(tipoVeiculoModel, tipoVeiculoModelE);
            unitOfWork.RepositorioTipoVeiculo.Inserir(tipoVeiculoModelE);
            unitOfWork.Commit(shared);
            return tipoVeiculoModelE.IdTipoVeiculo;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(TipoVeiculoModel tipoVeiculoModel)
        {
            tb_tipoveiculo tipoVeiculoModelE = new tb_tipoveiculo();
            Atribuir(tipoVeiculoModel, tipoVeiculoModelE);
            unitOfWork.RepositorioTipoVeiculo.Editar(tipoVeiculoModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusPagamentoModel">Identificador do pagamento na base de dados</param>
        public void Remover(int idTipoVeiculo)
        {
            unitOfWork.RepositorioTipoVeiculo.Remover(TipoVeiculo => TipoVeiculo.IdTipoVeiculo.Equals(idTipoVeiculo));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<TipoVeiculoModel> GetQuery()
        {
            IQueryable<tb_tipoveiculo> tb_tipoveiculo = unitOfWork.RepositorioTipoVeiculo.GetQueryable();
            var query = from TipoVeiculo in tb_tipoveiculo
                        select new TipoVeiculoModel
                        {
                            IdTipoVeiculo = TipoVeiculo.IdTipoVeiculo,
                            TipoVeiculo = TipoVeiculo.TipoVeiculo
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoVeiculoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pagamento
        /// </summary>
        /// <param name="idStatusOcorrencia">Identificador do pagamento na base de dados</param>
        /// <returns>Pagamento model</returns>
        public TipoVeiculoModel Obter(int idTipoVeiculo)
        {
            IEnumerable<TipoVeiculoModel> tipoVeiculoEs = GetQuery().Where(TipoVeiculo => TipoVeiculo.IdTipoVeiculo.Equals(idTipoVeiculo));
            return tipoVeiculoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Pagamento Model para o Pagamento Entity
        /// </summary>
        /// <param name="statusPagamentoModel">Objeto do modelo</param>
        /// <param name="statusPagamentoE">Entity mapeada da base de dados</param>
        private void Atribuir(TipoVeiculoModel tipoVeiculoModel, tb_tipoveiculo tipoVeiculoE)
        {
            tipoVeiculoE.IdTipoVeiculo = tipoVeiculoModel.IdTipoVeiculo;
            tipoVeiculoE.TipoVeiculo = tipoVeiculoModel.TipoVeiculo;
         
   
        }*/
    }
}
