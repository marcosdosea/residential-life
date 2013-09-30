using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorPlanoDeConta
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPlanoDeConta()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPlanoDeConta(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PlanoDeContaModel tipoPlanoDeContaModel)
        {
            tb_planodeconta tipoPlanoDeContaModelE = new tb_planodeconta();
            Atribuir(tipoPlanoDeContaModel, tipoPlanoDeContaModelE);
            unitOfWork.RepositorioPlanoDeConta.Inserir(tipoPlanoDeContaModelE);
            unitOfWork.Commit(shared);
            return tipoPlanoDeContaModelE.IdPlanoDeConta;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Dados do modelo</param>
        public void Editar(PlanoDeContaModel tipoPlanoDeContaModel)
        {
            tb_planodeconta tipoPlanoDeContaModelE = new tb_planodeconta();
            Atribuir(tipoPlanoDeContaModel, tipoPlanoDeContaModelE);
            unitOfWork.RepositorioPlanoDeConta.Editar(tipoPlanoDeContaModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPlanoDeConta">Identificador do plano de conta na base de dados</param>
        public void Remover(int idPlanoDeConta)
        {
            unitOfWork.RepositorioPlanoDeConta.Remover(PlanoDeConta => PlanoDeConta.IdPlanoDeConta.Equals(idPlanoDeConta));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do planodeconta como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PlanoDeContaModel> GetQuery()
        {
            IQueryable<tb_planodeconta> tb_planodeconta = unitOfWork.RepositorioPlanoDeConta.GetQueryable();
            var query = from PlanoDeConta in tb_planodeconta
                        select new PlanoDeContaModel
                        {
                            IdPlanoDeConta = PlanoDeConta.IdPlanoDeConta,
                            Descricao = PlanoDeConta.Descricao,
                            TipoPlanoDeConta = PlanoDeConta.tb_tipoplanodeconta.TipoPlanoDeConta,
                            IdTipoPlanoDeConta = PlanoDeConta.IdTipoPlanoDeConta
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PlanoDeContaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idPlanoDeConta">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public PlanoDeContaModel Obter(int idPlanoDeConta)
        {
            IEnumerable<PlanoDeContaModel> planoDeContaEs = GetQuery().Where(PlanoDeConta => PlanoDeConta.IdPlanoDeConta.Equals(idPlanoDeConta));
            return planoDeContaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status PlanoDeConta Model para o PlanoDeConta Entity
        /// </summary>
        /// <param name="tipoPlanoDeContaModel">Objeto do modelo</param>
        /// <param name="tipoPlanoDeContaE">Entity mapeada da base de dados</param>
        private void Atribuir(PlanoDeContaModel tipoPlanoDeContaModel, tb_planodeconta tipoPlanoDeContaE)
        {
            tipoPlanoDeContaE.IdPlanoDeConta = tipoPlanoDeContaModel.IdPlanoDeConta;
            tipoPlanoDeContaE.Descricao = tipoPlanoDeContaModel.Descricao;
            tipoPlanoDeContaE.IdTipoPlanoDeConta = tipoPlanoDeContaModel.IdTipoPlanoDeConta;
        }
    }
}
