using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorAtendimento
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAtendimento()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorAtendimento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo atendimento na base de dados
        /// </summary>
        /// <param name="atendimentoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AtendimentoModel atendimentoModel)
        {
            tb_atendimento atendimentoModelE = new tb_atendimento();
            Atribuir(atendimentoModel, atendimentoModelE);
            unitOfWork.RepositorioAtendimento.Inserir(atendimentoModelE);
            unitOfWork.Commit(shared);
            return atendimentoModelE.IdAtendimento;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="atendimentoModel">Dados do modelo</param>
        public void Editar(AtendimentoModel atendimentoModel)
        {
            tb_atendimento atendimentoModelE = new tb_atendimento();
            Atribuir(atendimentoModel, atendimentoModelE);
            unitOfWork.RepositorioAtendimento.Editar(atendimentoModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idAtendimento">Identificador do pagamento na base de dados</param>
        public void Remover(int idAtendimento)
        {
            unitOfWork.RepositorioAtendimento.Remover(atendimento => atendimento.IdAtendimento.Equals(idAtendimento));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<AtendimentoModel> GetQuery()
        {
            IQueryable<tb_atendimento> tb_atendimento = unitOfWork.RepositorioAtendimento.GetQueryable();
            var query = from atendimento in tb_atendimento
                        select new AtendimentoModel
                        {
                            NomePessoa = atendimento.tb_pessoa.Nome,
                            IdAtendimento = atendimento.IdAtendimento,
                            IdPessoa = atendimento.IdPesssoa,
                            Titulo = atendimento.Titulo,
                            Descricao = atendimento.Descricao,
                            StatusAtendimento = (atendimento.StatusAtendimento == "Resolvido" ? Models.AtendimentoModel.ListaStatusAtendimento.Resolvido : AtendimentoModel.ListaStatusAtendimento.EmAnalise )
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AtendimentoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idAdministradora">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public AtendimentoModel Obter(int idAtendimento)
        {
            IEnumerable<AtendimentoModel> atendimento = GetQuery().Where(at => at.IdAtendimento.Equals(idAtendimento));
            return atendimento.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Administradora Model para o Administradora Entity
        /// </summary>
        /// <param name="AtendimentoModel">Objeto do modelo</param>
        /// <param name="administradoraE">Entity mapeada da base de dados</param>
        private void Atribuir(AtendimentoModel atendimentoModel, tb_atendimento atendimentoE)
        {
            atendimentoE.IdAtendimento = atendimentoModel.IdAtendimento;
            atendimentoE.IdPesssoa = atendimentoModel.IdPessoa;
            atendimentoE.Titulo = atendimentoModel.Titulo;
            atendimentoE.Descricao = atendimentoModel.Descricao;
            atendimentoE.StatusAtendimento = atendimentoModel.StatusAtendimento.ToString();
        }
    }
}
