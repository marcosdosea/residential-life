using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Models;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorAdministradora
    {
        /*
        private static GerenciadorAdministradora gAdm;

        private IUnitOfWork unitOfWork;
        private bool shared;

        public static GerenciadorAdministradora GetInstance()
        {
            if (gAdm == null)
            {
                gAdm = new GerenciadorAdministradora();
            }
            return gAdm;
        }

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAdministradora()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorAdministradora(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="administradoraModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AdministradoraModel administradoraModel)
        {
            tb_administradora administradoraModelE = new tb_administradora();
            Atribuir(administradoraModel, administradoraModelE);
            unitOfWork.RepositorioAdministradora.Inserir(administradoraModelE);
            unitOfWork.Commit(shared);
            return administradoraModelE.IdAdministradora;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="administradoraModel">Dados do modelo</param>
        public void Editar(AdministradoraModel administradoraModel)
        {
            tb_administradora administradoraModelE = new tb_administradora();
            Atribuir(administradoraModel, administradoraModelE);
            unitOfWork.RepositorioAdministradora.Editar(administradoraModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idAdministradora">Identificador do pagamento na base de dados</param>
        public void Remover(int idAdministradora)
        {
            unitOfWork.RepositorioAdministradora.Remover(Administradora => Administradora.IdAdministradora.Equals(idAdministradora));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<AdministradoraModel> GetQuery()
        {
            IQueryable<tb_administradora> tb_administradora = unitOfWork.RepositorioAdministradora.GetQueryable();
            var query = from Administradora in tb_administradora
                        select new AdministradoraModel
                        {
                            IdAdministradora = Administradora.IdAdministradora,
                            Nome = Administradora.Nome,
                            Login = Administradora.Login,
                            Senha = Administradora.Senha,
                            Email = Administradora.Email
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AdministradoraModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idAdministradora">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public AdministradoraModel Obter(int idAdministradora)
        {
            IEnumerable<AdministradoraModel> tipoVeiculoEs = GetQuery().Where(Administradora => Administradora.IdAdministradora.Equals(idAdministradora));
            return tipoVeiculoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idAdministradora">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>Tipo de Plano de Conta model</returns>
        public AdministradoraModel ObterPorNomeEmail(string Nome, string email)
        {
            IEnumerable<AdministradoraModel> adm = GetQuery().Where(Administradora => Administradora.Nome == Nome && Administradora.Email == email);
            return adm.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Administradora Model para o Administradora Entity
        /// </summary>
        /// <param name="administradoraModel">Objeto do modelo</param>
        /// <param name="administradoraE">Entity mapeada da base de dados</param>
        private void Atribuir(AdministradoraModel administradoraModel, tb_administradora administradoraE)
        {
            administradoraE.IdAdministradora = administradoraModel.IdAdministradora;
            administradoraE.Nome = administradoraModel.Nome;
            administradoraE.Login = administradoraModel.Login;
            administradoraE.Senha = administradoraModel.Senha;
            administradoraE.Email = administradoraModel.Email;
        } */
    }
}
