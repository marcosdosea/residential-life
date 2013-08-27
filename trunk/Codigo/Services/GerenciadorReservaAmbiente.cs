using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Persistence;
using Models.Models;


namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade ReservaAmbiente
    /// </summary>
    
    public class GerenciadorReservaAmbiente

    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorReservaAmbiente()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorReservaAmbiente(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(ReservaAmbienteModel reservaAmbienteModel)
        {
            tb_reservaambiente reservaAmbienteE = new tb_reservaambiente();
            Atribuir(reservaAmbienteModel, reservaAmbienteE);
            unitOfWork.RepositorioReservaAmbiente.Inserir(reservaAmbienteE);
            unitOfWork.Commit(shared);
            return reservaAmbienteE.IdReservaAmbiente;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel"></param>
        public void Editar(ReservaAmbienteModel reservaAmbienteModel)
        {
            tb_reservaambiente reservaAmbienteE = new tb_reservaambiente(); 
            Atribuir(reservaAmbienteModel, reservaAmbienteE);
            unitOfWork.RepositorioReservaAmbiente.Editar(reservaAmbienteE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel"> </param>
        public void Remover(int IdRes)
        {
            unitOfWork.RepositorioReservaAmbiente.Remover(reservaAmbiente => reservaAmbiente.IdReservaAmbiente.Equals(IdRes));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<ReservaAmbienteModel> GetQuery()
        {
            IQueryable<tb_reservaambiente> tb_reservaambiente = unitOfWork.RepositorioReservaAmbiente.GetQueryable();
            var query = from reservaAmbiente in tb_reservaambiente 
                        select new ReservaAmbienteModel
                        {
                            IdReservaAmbiente = reservaAmbiente.IdPesssoa,
                            IdPesssoa = reservaAmbiente.IdPesssoa,
                            IdAreaPublica = reservaAmbiente.IdAreaPublica,
                            NomeAreaPublica = reservaAmbiente.tb_areapublica.Nome,
                            DataInicio = reservaAmbiente.DataInicio,
                            DataFim = reservaAmbiente.DataFim,
                            IdStatusPagamento = reservaAmbiente.IdStatusPagamento,
                            StatusPagamento = reservaAmbiente.tb_statuspagamento.StatusPagamento,
                          
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReservaAmbienteModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém uma reserva de ambiente
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public ReservaAmbienteModel Obter(int IdRes)
        {
            IEnumerable<ReservaAmbienteModel> reservaAmbienteE = GetQuery().Where(reservaAmbienteModel => reservaAmbienteModel.IdReservaAmbiente.Equals(IdRes));
            return reservaAmbienteE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="reservaAmbienteModel">Objeto do modelo</param>
        /// <param name="reservaAmbienteE">Entity mapeada da base de dados</param>
        private void Atribuir(ReservaAmbienteModel reservaAmbienteModel, tb_reservaambiente reservaAmbienteE)
        {
            reservaAmbienteE.IdReservaAmbiente = reservaAmbienteModel.IdReservaAmbiente;
            reservaAmbienteE.IdPesssoa = reservaAmbienteModel.IdPesssoa;
            reservaAmbienteE.IdAreaPublica = reservaAmbienteModel.IdAreaPublica;
            reservaAmbienteE.DataInicio = reservaAmbienteModel.DataInicio;
            reservaAmbienteE.DataFim = reservaAmbienteModel.DataFim;
            reservaAmbienteE.IdStatusPagamento = reservaAmbienteModel.IdStatusPagamento;
           
            
        }
    }
}
