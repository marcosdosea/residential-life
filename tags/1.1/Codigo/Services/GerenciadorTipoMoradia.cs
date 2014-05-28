using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorTipoMoradia
    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorTipoMoradia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorTipoMoradia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="tipomoradiaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(TipoMoradiaModel tipoMoradiaModel)
        {
            tb_tipomoradia tipoMoradiaModelE = new tb_tipomoradia();
            Atribuir(tipoMoradiaModel, tipoMoradiaModelE);
            unitOfWork.RepositorioTipoMoradia.Inserir(tipoMoradiaModelE);
            unitOfWork.Commit(shared);
            return tipoMoradiaModelE.IdTipoMoradia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="moradiaModel">Dados do modelo</param>
        public void Editar(TipoMoradiaModel tipoMoradiaModel)
        {
            tb_tipomoradia tipoMoradiaModelE = new tb_tipomoradia();
            Atribuir(tipoMoradiaModel, tipoMoradiaModelE);
            unitOfWork.RepositorioTipoMoradia.Editar(tipoMoradiaModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="moradiaModel">Identificador do pagamento na base de dados</param>
        public void Remover(int idTipoMoradia)
        {
            unitOfWork.RepositorioTipoMoradia.Remover(tipoMoradia => tipoMoradia.IdTipoMoradia.Equals(idTipoMoradia));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<TipoMoradiaModel> GetQuery()
        {
            IQueryable<tb_tipomoradia> tb_tipomoradia = unitOfWork.RepositorioTipoMoradia.GetQueryable();
            var query = from tipoMoradia in tb_tipomoradia
                        select new TipoMoradiaModel
                        {
                            IdTipoMoradia = tipoMoradia.IdTipoMoradia,
                            TipoMoradia = tipoMoradia.TipoMoradia
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoMoradiaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pagamento
        /// </summary>
        /// <param name="idTipoMoradia">Identificador do pagamento na base de dados</param>
        /// <returns>Pagamento model</returns>
        public TipoMoradiaModel Obter(int idTipoMoradia)
        {
            IEnumerable<TipoMoradiaModel> tipoMoradiaEs = GetQuery().Where(tipoMoradia => tipoMoradia.IdTipoMoradia.Equals(idTipoMoradia));
            return tipoMoradiaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Pagamento Model para o Pagamento Entity
        /// </summary>
        /// <param name="statusPagamentoModel">Objeto do modelo</param>
        /// <param name="statusPagamentoE">Entity mapeada da base de dados</param>
        private void Atribuir(TipoMoradiaModel tipoMoradiaModel, tb_tipomoradia tipoMoradiaE)
        {
            tipoMoradiaE.IdTipoMoradia = tipoMoradiaModel.IdTipoMoradia;
            tipoMoradiaE.TipoMoradia = tipoMoradiaModel.TipoMoradia;
         
   
        }
    }
}
