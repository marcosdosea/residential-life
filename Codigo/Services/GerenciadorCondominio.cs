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
    /// Gerencia todas as regras de negócio da entidade Autor
    /// </summary>

    public class GerenciadorCondominio
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorCondominio()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorCondominio(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="condominioModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(CondominioModel condominioModel)
        {
            tb_condominio condominioE = new tb_condominio();
            Atribuir(condominioModel, condominioE);
            unitOfWork.RepositorioCondominio.Inserir(condominioE);
            unitOfWork.Commit(shared);
            return condominioE.IdCon;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="condominioModel"></param>
        public void Editar(CondominioModel condominioModel)
        {
            tb_condominio condominioE = new tb_condominio();
            Atribuir(condominioModel, condominioE);
            unitOfWork.RepositorioCondominio.Editar(condominioE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="condominioModel"></param>
        public void Remover(int idCondominio)
        {
            unitOfWork.RepositorioCondominio.Remover(condominio => condominio.IdCon.Equals(idCondominio));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<CondominioModel> GetQuery()
        {
            IQueryable<tb_condominio> tb_condominio = unitOfWork.RepositorioCondominio.GetQueryable();
            var query = from condominio in tb_condominio
                        select new CondominioModel
                        {
                            IDCondominio = condominio.IdCon,
                            Nome = condominio.Nome,
                            Rua = condominio.Rua


                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CondominioModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idAutor">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public CondominioModel Obter(int idCondominio)
        {
            IEnumerable<CondominioModel> condominioEs = GetQuery().Where(condominioModel => condominioModel.IDCondominio.Equals(idCondominio));
            return condominioEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="condominioModel">Objeto do modelo</param>
        /// <param name="condominioE">Entity mapeada da base de dados</param>
        private void Atribuir(CondominioModel condominioModel, tb_condominio condominioE)
        {
            condominioE.IdCon = condominioModel.IDCondominio;
            condominioE.IdSin = condominioModel.IDSindico;
            condominioE.Nome = condominioModel.Nome;
            condominioE.Rua = condominioModel.Rua;
            condominioE.Numero = condominioModel.Numero;
            condominioE.Bairro = condominioModel.Bairro;
            condominioE.Complemento = condominioModel.Complemento;
            condominioE.CEP = condominioModel.Cep;
            condominioE.Cidade = condominioModel.Cidade;
            condominioE.Estado = condominioModel.Estado;
        }
    }
}
