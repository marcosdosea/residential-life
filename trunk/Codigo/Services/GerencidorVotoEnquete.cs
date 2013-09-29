using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorVotoEnquete
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorVotoEnquete()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorVotoEnquete(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="votoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(VotoEnqueteModel votoModel)
        {
            tb_votoenquete opcoesEnqueteE = new tb_votoenquete();

            Atribuir(votoModel, opcoesEnqueteE);
            unitOfWork.RepositorioVotoEnquete.Inserir(opcoesEnqueteE);

            unitOfWork.Commit(shared);
            return opcoesEnqueteE.IdVoto;
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="votoModel">Identificador do voto na base de dados</param>
        public void Remover(int idVotoEnquete)
        {
            unitOfWork.RepositorioVotoEnquete.Remover(voto => voto.IdVoto.Equals(idVotoEnquete));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do voto como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<VotoEnqueteModel> GetQuery()
        {
            IQueryable<tb_votoenquete> tb_voto = unitOfWork.RepositorioVotoEnquete.GetQueryable();
            var query = from voto in tb_voto
                        select new VotoEnqueteModel
                        {
                            IdVoto = voto.IdVoto,
                            IdPessoa = voto.IdPessoa,
                            IdOpcao = voto.IdOpcao,
                            IdEnquete = voto.IdEnquete,
                            DataVoto = voto.DataVoto

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VotoEnqueteModel> ObterTodos()
        {
            return GetQuery();
        }

        public IEnumerable<VotoEnqueteModel> ObterOpcoesEnquete(int id)
        {
            return GetQuery().Where(opcoes => opcoes.IdEnquete.Equals(id));
        }



        /// <summary>
        /// Obtém um voto
        /// </summary>
        /// <param name="idVotoEnquete">Identificador do voto na base de dados</param>
        /// <returns>VotoEnquete model</returns>
        public VotoEnqueteModel Obter(int idVotoEnquete)
        {
            IEnumerable<VotoEnqueteModel> votoEs = GetQuery().Where(votoModel => votoModel.IdVoto.Equals(idVotoEnquete));
            return votoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do VotoEnquete Model para o VotoEnquete Entity
        /// </summary>
        /// <param name="votoModel">Objeto do modelo</param>
        /// <param name="votoE">Entity mapeada da base de dados</param>
        internal void Atribuir(VotoEnqueteModel votoModel, tb_votoenquete votoE)
        {
            votoE.IdVoto = votoModel.IdVoto;
            votoE.IdPessoa = votoModel.IdPessoa;
            votoE.IdOpcao = votoModel.IdOpcao;
            votoE.IdEnquete = votoModel.IdEnquete;
            votoE.DataVoto = votoModel.DataVoto;


        }
    }
}
