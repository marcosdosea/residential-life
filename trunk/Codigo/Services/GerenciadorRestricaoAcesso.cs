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
                                ListaDia.Domingo,
                            HoraEntrada = restricaoAcesso.HoraEntrada == "ZeroHora" ? ListaHora.ZeroHora : restricaoAcesso.HoraEntrada ==
                                "UmaHora" ? ListaHora.UmaHora : restricaoAcesso.HoraEntrada == "TresHora" ? ListaHora.TresHora : 
                                restricaoAcesso.HoraEntrada == "QuatroHora" ? ListaHora.QuatroHora : restricaoAcesso.HoraEntrada ==
                                "CincoHora" ? ListaHora.CincoHora : restricaoAcesso.HoraEntrada == "SeisHora" ? ListaHora.SeisHora :
                                restricaoAcesso.HoraEntrada == "SeteHora" ? ListaHora.SeteHora : restricaoAcesso.HoraEntrada == "OitoHora" ?
                                ListaHora.OitoHora : restricaoAcesso.HoraEntrada == "NoveHora" ? ListaHora.NoveHora : 
                                restricaoAcesso.HoraEntrada == "DezHora" ? ListaHora.DezHora : restricaoAcesso.HoraEntrada == "OnzeHora" ?
                                ListaHora.OnzeHora : restricaoAcesso.HoraEntrada == "DozeHora" ? ListaHora.DozeHora :
                                restricaoAcesso.HoraEntrada == "TrezeHora" ? ListaHora.TrezeHora : restricaoAcesso.HoraEntrada ==
                                "QuatorzeHora" ? ListaHora.QuatorzeHora : restricaoAcesso.HoraEntrada == "QuinzeHora" ?  ListaHora.QuinzeHora :
                                restricaoAcesso.HoraEntrada == "DezesseisHora" ? ListaHora.DezesseisHora : restricaoAcesso.HoraEntrada ==
                                "DezesseteHora" ? ListaHora.DezesseteHora : restricaoAcesso.HoraEntrada == "DezoitoHora" ? 
                                ListaHora.DezoitoHora : restricaoAcesso.HoraEntrada == "DezenoveHora" ? ListaHora.DezenoveHora : 
                                restricaoAcesso.HoraEntrada == "VinteHora" ? ListaHora.VinteHora : restricaoAcesso.HoraEntrada == 
                                "VinteUmHora" ? ListaHora.VinteUmHora : restricaoAcesso.HoraEntrada == "VinteDuasHora" ? 
                                ListaHora.VinteDuasHora : restricaoAcesso.HoraEntrada == "VinteTresHora" ? ListaHora.VinteTresHora : 
                                ListaHora.VinteQuatroHora,
                            HoraSaida = restricaoAcesso.HoraSaida == "ZeroHora" ? ListaHora.ZeroHora : restricaoAcesso.HoraSaida ==
                                "UmaHora" ? ListaHora.UmaHora : restricaoAcesso.HoraSaida == "TresHora" ? ListaHora.TresHora :
                                restricaoAcesso.HoraSaida == "QuatroHora" ? ListaHora.QuatroHora : restricaoAcesso.HoraSaida ==
                                "CincoHora" ? ListaHora.CincoHora : restricaoAcesso.HoraSaida == "SeisHora" ? ListaHora.SeisHora :
                                restricaoAcesso.HoraSaida == "SeteHora" ? ListaHora.SeteHora : restricaoAcesso.HoraSaida == "OitoHora" ?
                                ListaHora.OitoHora : restricaoAcesso.HoraSaida == "NoveHora" ? ListaHora.NoveHora :
                                restricaoAcesso.HoraSaida == "DezHora" ? ListaHora.DezHora : restricaoAcesso.HoraSaida == "OnzeHora" ?
                                ListaHora.OnzeHora : restricaoAcesso.HoraSaida == "DozeHora" ? ListaHora.DozeHora :
                                restricaoAcesso.HoraSaida == "TrezeHora" ? ListaHora.TrezeHora : restricaoAcesso.HoraSaida ==
                                "QuatorzeHora" ? ListaHora.QuatorzeHora : restricaoAcesso.HoraSaida == "QuinzeHora" ? ListaHora.QuinzeHora :
                                restricaoAcesso.HoraSaida == "DezesseisHora" ? ListaHora.DezesseisHora : restricaoAcesso.HoraSaida ==
                                "DezesseteHora" ? ListaHora.DezesseteHora : restricaoAcesso.HoraSaida == "DezoitoHora" ?
                                ListaHora.DezoitoHora : restricaoAcesso.HoraSaida == "DezenoveHora" ? ListaHora.DezenoveHora :
                                restricaoAcesso.HoraSaida == "VinteHora" ? ListaHora.VinteHora : restricaoAcesso.HoraSaida ==
                                "VinteUmHora" ? ListaHora.VinteUmHora : restricaoAcesso.HoraSaida == "VinteDuasHora" ?
                                ListaHora.VinteDuasHora : restricaoAcesso.HoraSaida == "VinteTresHora" ? ListaHora.VinteTresHora :
                                ListaHora.VinteQuatroHora
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
