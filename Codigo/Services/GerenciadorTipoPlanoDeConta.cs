using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorTipoPlanoDeConta
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorTipoPlanoDeConta()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorTipoPlanoDeConta(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(TipoPlanoDeContaModel tipoPlanoDeContaModel)
        {
            tb_tipoplanodeconta tipoPlanoDeContaModelE = new tb_tipoplanodeconta();
            Atribuir(tipoPlanoDeContaModel, tipoPlanoDeContaModelE);
            unitOfWork.RepositorioTipoPlanoDeConta.Inserir(tipoPlanoDeContaModelE);
            unitOfWork.Commit(shared);
            return tipoPlanoDeContaModelE.IdTipoPlanoDeConta;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Dados do modelo</param>
        public void Editar(TipoPlanoDeContaModel tipoPlanoDeContaModel)
        {
            tb_tipoplanodeconta tipoPlanoDeContaModelE = new tb_tipoplanodeconta();
            Atribuir(tipoPlanoDeContaModel, tipoPlanoDeContaModelE);
            unitOfWork.RepositorioTipoPlanoDeConta.Editar(tipoPlanoDeContaModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idTipoPlanoDeConta">Identificador do pagamento na base de dados</param>
        public void Remover(int idTipoPlanoDeConta)
        {
            unitOfWork.RepositorioTipoPlanoDeConta.Remover(TipoPlanoDeConta => TipoPlanoDeConta.IdTipoPlanoDeConta.Equals(idTipoPlanoDeConta));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<TipoPlanoDeContaModel> GetQuery()
        {
            IQueryable<tb_tipoplanodeconta> tb_tipoplanodeconta = unitOfWork.RepositorioTipoPlanoDeConta.GetQueryable();
            var query = from TipoPlanoDeConta in tb_tipoplanodeconta
                        select new TipoPlanoDeContaModel
                        {
                            IdTipoPlanoDeConta = TipoPlanoDeConta.IdTipoPlanoDeConta,
                            TipoPlanoDeConta = TipoPlanoDeConta.TipoPlanoDeConta
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoPlanoDeContaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idTipoPlanoDeConta">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public TipoPlanoDeContaModel Obter(int idTipoPlanoDeConta)
        {
            IEnumerable<TipoPlanoDeContaModel> tipoVeiculoEs = GetQuery().Where(TipoPlanoDeConta => TipoPlanoDeConta.IdTipoPlanoDeConta.Equals(idTipoPlanoDeConta));
            return tipoVeiculoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status TipoPlanoDeConta Model para o TipoPlanoDeConta Entity
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Objeto do modelo</param>
        /// <param name="tipoPlanoDeContaE">Entity mapeada da base de dados</param>
        private void Atribuir(TipoPlanoDeContaModel tipoPlanoDeContaModel, tb_tipoplanodeconta tipoPlanoDeContaE)
        {
            tipoPlanoDeContaE.IdTipoPlanoDeConta = tipoPlanoDeContaModel.IdTipoPlanoDeConta;
            tipoPlanoDeContaE.TipoPlanoDeConta = tipoPlanoDeContaModel.TipoPlanoDeConta;
        }
    }
}
