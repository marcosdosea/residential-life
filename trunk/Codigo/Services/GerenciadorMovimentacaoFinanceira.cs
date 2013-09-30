using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorMovimentacaoFinanceira
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorMovimentacaoFinanceira()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorMovimentacaoFinanceira(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="movimentacaoFinanceiraModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(MovimentacaoFinanceiraModel movimentacaoFinanceiraModel)
        {
            tb_movimentacaofinanceira movimentacaoFinanceiraModelE = new tb_movimentacaofinanceira();
            Atribuir(movimentacaoFinanceiraModel, movimentacaoFinanceiraModelE);
            unitOfWork.RepositorioMovimentacaoFinanceira.Inserir(movimentacaoFinanceiraModelE);
            unitOfWork.Commit(shared);
            return movimentacaoFinanceiraModelE.IdMovimentacaoFinanceira;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="movimentacaoFinanceiraModel">Dados do modelo</param>
        public void Editar(MovimentacaoFinanceiraModel movimentacaoFinanceiraModel)
        {
            tb_movimentacaofinanceira movimentacaoFinanceiraModelE = new tb_movimentacaofinanceira();
            Atribuir(movimentacaoFinanceiraModel, movimentacaoFinanceiraModelE);
            unitOfWork.RepositorioMovimentacaoFinanceira.Editar(movimentacaoFinanceiraModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idMovimentacaoFinanceira">Identificador do plano de conta na base de dados</param>
        public void Remover(int idMovimentacaoFinanceira)
        {
            unitOfWork.RepositorioMovimentacaoFinanceira.Remover(MovimentacaoFinanceira => MovimentacaoFinanceira.IdMovimentacaoFinanceira.Equals(idMovimentacaoFinanceira));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do planodeconta como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<MovimentacaoFinanceiraModel> GetQuery()
        {
            IQueryable<tb_movimentacaofinanceira> tb_movimentacaofinanceira = unitOfWork.RepositorioMovimentacaoFinanceira.GetQueryable();
            var query = from MovimentacaoFinanceira in tb_movimentacaofinanceira
                        select new MovimentacaoFinanceiraModel
                        {
                            IdMovimentacaoFinanceira = MovimentacaoFinanceira.IdMovimentacaoFinanceira,
                            Descricao = MovimentacaoFinanceira.Descricao,
                            IdAdministradora = MovimentacaoFinanceira.IdAdministradora,
                            NomeAdministradora = MovimentacaoFinanceira.tb_administradora.Nome,
                            Valor = Convert.ToDecimal(MovimentacaoFinanceira.Valor),
                            Data = MovimentacaoFinanceira.Data,
                            Competencia = MovimentacaoFinanceira.Competencia,
                            IdStatusMovimentacaoFinanceira = MovimentacaoFinanceira.IdStatusMovimentacaoFinanceira,
                            StatusMovimentacaoFinanceira = MovimentacaoFinanceira.tb_statusmovimentacaofinanceira.StatusMovimentacaoFinanceira,
                            IdPlanoDeConta = MovimentacaoFinanceira.IdPlanoDeConta,
                            PlanoDeConta = MovimentacaoFinanceira.tb_planodeconta.Descricao
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MovimentacaoFinanceiraModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idMovimentacaoFinanceira">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public MovimentacaoFinanceiraModel Obter(int idMovimentacaoFinanceira)
        {
            IEnumerable<MovimentacaoFinanceiraModel> planoDeContaEs = GetQuery().Where(MovimentacaoFinanceira => MovimentacaoFinanceira.IdMovimentacaoFinanceira.Equals(idMovimentacaoFinanceira));
            return planoDeContaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status MovimentacaoFinanceira Model para o MovimentacaoFinanceira Entity
        /// </summary>
        /// <param name="movimentacaoFinanceiraModel">Objeto do modelo</param>
        /// <param name="movimentacaoFinanceiraE">Entity mapeada da base de dados</param>
        private void Atribuir(MovimentacaoFinanceiraModel movimentacaoFinanceiraModel, tb_movimentacaofinanceira movimentacaoFinanceiraE)
        {
            movimentacaoFinanceiraE.IdMovimentacaoFinanceira = movimentacaoFinanceiraModel.IdMovimentacaoFinanceira;
            movimentacaoFinanceiraE.Descricao = movimentacaoFinanceiraModel.Descricao;
            movimentacaoFinanceiraE.IdAdministradora = movimentacaoFinanceiraModel.IdAdministradora;
            movimentacaoFinanceiraE.Valor = movimentacaoFinanceiraModel.Valor;
            movimentacaoFinanceiraE.Data = movimentacaoFinanceiraModel.Data;
            movimentacaoFinanceiraE.Competencia = movimentacaoFinanceiraModel.Competencia;
            movimentacaoFinanceiraE.IdStatusMovimentacaoFinanceira = movimentacaoFinanceiraModel.IdStatusMovimentacaoFinanceira;
            movimentacaoFinanceiraE.IdPlanoDeConta = movimentacaoFinanceiraModel.IdPlanoDeConta;
        }
    }
}
