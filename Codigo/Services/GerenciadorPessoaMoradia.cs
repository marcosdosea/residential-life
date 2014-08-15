using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorPessoaMoradia
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPessoaMoradia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorPessoaMoradia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public void Inserir(PessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            tb_pessoamoradia alocarPessoaMoradiaE = new tb_pessoamoradia();
            Atribuir(alocarPessoaMoradiaModel, alocarPessoaMoradiaE);
            unitOfWork.RepositorioPessoaMoradia.Inserir(alocarPessoaMoradiaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="alocarPessoaMoradiaModel"></param>
        public void Editar(PessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            tb_pessoamoradia alocarPessoaMoradiaE = new tb_pessoamoradia();
            Atribuir(alocarPessoaMoradiaModel, alocarPessoaMoradiaE);
            unitOfWork.RepositorioPessoaMoradia.Editar(alocarPessoaMoradiaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel"> </param>
        public void Remover(int IdPessoa, int IdMoradia, int idPerfil)
        {
            unitOfWork.RepositorioPessoaMoradia.Remover(pm => pm.IdPessoa.Equals(IdPessoa) && pm.IdMoradia.Equals(IdMoradia) &&
                pm.IdPerfil.Equals(idPerfil));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PessoaMoradiaModel> GetQuery()
        {
            IQueryable<tb_pessoamoradia> tb_pessoamoradiaE = unitOfWork.RepositorioPessoaMoradia.GetQueryable();
            var query = from pessoamoradia in tb_pessoamoradiaE
                        select new PessoaMoradiaModel
                        {
                            IdMoradia = pessoamoradia.IdMoradia,
                            IdPessoa = pessoamoradia.tb_pessoa.IdPessoa,
                            NomePessoa = pessoamoradia.tb_pessoa.Nome,
                            NumeroMoradia = pessoamoradia.tb_moradia.Numero,
                            Condominio = pessoamoradia.tb_moradia.tb_bloco.tb_condominio.Nome,
                            IdCondominio = pessoamoradia.tb_moradia.tb_bloco.tb_condominio.IdCondominio,
                            Bloco = pessoamoradia.tb_moradia.tb_bloco.Nome,
                            IdBloco = pessoamoradia.tb_moradia.tb_bloco.IdBloco,
                            IdPerfil = pessoamoradia.IdPerfil,
                            Perfil = pessoamoradia.my_aspnet_roles.name,
                            Ativo = pessoamoradia.Ativo
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém pessoa moradia pelo idPessoa
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public PessoaMoradiaModel ObterPessoaMoradia(int IdPessoa)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdPessoa.Equals(IdPessoa));
            return pessoaMoradiaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterTodosPorPessoa(int idPessoa)
        {
            return GetQuery().Where(alocarPessoaMoradiaModel => alocarPessoaMoradiaModel.IdPessoa.Equals(idPessoa));
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterTodosPorMoradia(int idMoradia)
        {
            return GetQuery().Where(alocarPessoaMoradiaModel => alocarPessoaMoradiaModel.IdMoradia.Equals(idMoradia));
        }


        /// <summary>
        /// Obtém uma reserva de ambiente
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public PessoaMoradiaModel Obter(int IdPessoa, int IdMoradia, int idPerfil)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdPessoa.Equals(IdPessoa) && 
                pm.IdMoradia.Equals(IdMoradia) && pm.IdPerfil.Equals(idPerfil));
            return pessoaMoradiaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém a pessoa moradia a partir da moradia e perfil
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public PessoaMoradiaModel ObterPorMoradiaPerfil(int IdMoradia, int idPerfil)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdMoradia.Equals(IdMoradia) && 
                pm.IdPerfil.Equals(idPerfil));
            return pessoaMoradiaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtem todas as pessoas de determinada moradia por perfil
        /// </summary>
        /// <param name="IdMoradia"></param>
        /// <param name="idPerfil"></param>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterTodosPorMoradiaPerfil(int IdMoradia, int idPerfil)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdMoradia.Equals(IdMoradia) &&
                pm.IdPerfil.Equals(idPerfil));
            return pessoaMoradiaE;
        }

        /// <summary>
        /// Obtem todos os registros de acordo com o perfil que estao ativos
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterPorPerfilAtivo(int idPerfil)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdPerfil.Equals(idPerfil) && 
                pm.Ativo == true);
            return pessoaMoradiaE;
        }

        /// <summary>
        /// Obtem todos os registros por perfil e moradia
        /// </summary>
        /// <param name="idMoradia"></param>
        /// <param name="idPerfil"></param>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterPorMoradiaPerfilAtivo(int idMoradia, int idPerfil)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdPerfil.Equals(idPerfil) &&
                pm.Ativo == true && pm.IdMoradia.Equals(idMoradia));
            return pessoaMoradiaE;
        }

        /// <summary>
        /// Obtem registros de acordo com o perfil e condominio ativo
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <param name="idCondominio"></param>
        /// <returns></returns>
        public IEnumerable<PessoaMoradiaModel> ObterPorPerfilCondominioAtivo(int idPerfil, int idCondominio)
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradiaE = GetQuery().Where(pm => pm.IdPerfil.Equals(idPerfil) &&
                pm.Ativo == true && pm.IdCondominio.Equals(idCondominio));
            return pessoaMoradiaE;
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="reservaAmbienteModel">Objeto do modelo</param>
        /// <param name="reservaAmbienteE">Entity mapeada da base de dados</param>
        private void Atribuir(PessoaMoradiaModel alocarPessoaMoradiaModel, tb_pessoamoradia alocarPessoaMoradiaE)
        {
            alocarPessoaMoradiaE.IdMoradia = alocarPessoaMoradiaModel.IdMoradia;
            alocarPessoaMoradiaE.IdPessoa = alocarPessoaMoradiaModel.IdPessoa;
            alocarPessoaMoradiaE.IdPerfil = alocarPessoaMoradiaModel.IdPerfil;
            alocarPessoaMoradiaE.Ativo = alocarPessoaMoradiaModel.Ativo;
        }

        /// <summary>
        /// Insere ou edita uma nova entidade
        /// </summary>
        /// <param name="pessoaMoradia"></param>
        public void InserirEditar(PessoaMoradiaModel pessoaMoradia)
        {
            PessoaMoradiaModel pm = Obter(pessoaMoradia.IdPessoa, pessoaMoradia.IdMoradia, pessoaMoradia.IdPerfil);
            if (pm == null)
            {
                Inserir(pessoaMoradia);
            }
            else
            {
                Editar(pessoaMoradia);
            }
        }
    }
}
