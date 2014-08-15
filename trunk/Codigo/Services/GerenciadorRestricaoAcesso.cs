using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorRestricaoAcesso
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorRestricaoAcesso()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorRestricaoAcesso(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="restricaoAcesso">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(RestricaoAcessoModel restricaoAcesso)
        {
            tb_restricaoacesso restricaoAcessoE = new tb_restricaoacesso();
            Atribuir(restricaoAcesso, restricaoAcessoE);
            unitOfWork.RepositorioRestricaoAcesso.Inserir(restricaoAcessoE);
            unitOfWork.Commit(shared);
            return restricaoAcessoE.IdRestricaoAcesso;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="restricaoAcesso"></param>
        public void Editar(RestricaoAcessoModel restricaoAcesso)
        {
            tb_restricaoacesso restricaoAcessoE = new tb_restricaoacesso();
            Atribuir(restricaoAcesso, restricaoAcessoE);
            unitOfWork.RepositorioRestricaoAcesso.Editar(restricaoAcessoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idRestricaoAcesso"> </param>
        public void Remover(int idRestricaoAcesso)
        {
            unitOfWork.RepositorioRestricaoAcesso.Remover(ac => ac.IdRestricaoAcesso.Equals(idRestricaoAcesso));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<RestricaoAcessoModel> GetQuery()
        {
            IQueryable<tb_restricaoacesso> tb_restricaoacesso = unitOfWork.RepositorioRestricaoAcesso.GetQueryable();
            var query = from restricaoAcesso in tb_restricaoacesso
                        select new RestricaoAcessoModel
                        {
                            IdRestricaoAcesso = restricaoAcesso.IdRestricaoAcesso,
                            IdCondominio = restricaoAcesso.IdCondominio,
                            IdPessoa = restricaoAcesso.IdPessoa,
                            Condominio = restricaoAcesso.tb_condominio.Nome,
                            NomePessoa = restricaoAcesso.tb_pessoa.Nome,
                            Dia = restricaoAcesso.Dia == "Segunda" ? ListaDia.Segunda : restricaoAcesso.Dia == "Terca" ? ListaDia.Terca : 
                            restricaoAcesso.Dia == "Quarta" ? ListaDia.Quarta : restricaoAcesso.Dia == "Quinta" ? ListaDia.Quinta : 
                            restricaoAcesso.Dia == "Sexta" ? ListaDia.Sexta : restricaoAcesso.Dia == "Sabado" ? ListaDia.Sabado : 
                            ListaDia.Domingo
                            // TODO
                            // colocar a hora de entrada e saida e os boolean
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RestricaoAcessoModel> ObterTodos()
        {
            return GetQuery();
        }


        /// <summary>
        /// Obter todos as entidades cadastradas por condominio e pessoa
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RestricaoAcessoModel> ObterPorCondominioPessoa(int idCondominio, int idPessoa)
        {
            return GetQuery().Where(ac => ac.IdCondominio.Equals(idCondominio) && ac.IdPessoa.Equals(idPessoa));
        }

        /// <summary>
        /// Obtém uma reserva de ambiente
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public RestricaoAcessoModel Obter(int idRestricaoAcesso)
        {
            IEnumerable<RestricaoAcessoModel> restricaoAcessoE = GetQuery().Where(ac => ac.IdRestricaoAcesso.Equals(idRestricaoAcesso));
            return restricaoAcessoE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="reservaAmbienteModel">Objeto do modelo</param>
        /// <param name="reservaAmbienteE">Entity mapeada da base de dados</param>
        private void Atribuir(RestricaoAcessoModel restricaoAcesso, tb_restricaoacesso restricaoAcessoE)
        {
            restricaoAcessoE.IdRestricaoAcesso = restricaoAcesso.IdRestricaoAcesso;
            restricaoAcessoE.IdCondominio = restricaoAcesso.IdCondominio;
            restricaoAcessoE.IdPessoa = restricaoAcesso.IdPessoa;
            restricaoAcessoE.Dia = restricaoAcesso.Dia.ToString();
            restricaoAcessoE.HoraEntrada = restricaoAcesso.HoraEntrada.ToString();
            restricaoAcessoE.HoraSaida = restricaoAcesso.HoraSaida.ToString();
            restricaoAcessoE.Restrito = restricaoAcesso.Restrito;
        }
    }
}
