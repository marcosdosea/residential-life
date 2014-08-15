using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorMoradia
    {
        
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorMoradia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorMoradia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(MoradiaModel moradiaModel)
        {
            tb_moradia moradiaE = new tb_moradia();
            Atribuir(moradiaModel, moradiaE);
            unitOfWork.RepositorioMoradia.Inserir(moradiaE);
            unitOfWork.Commit(shared);
            return moradiaE.IdMoradia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="moradiaModel"></param>
        public void Editar(MoradiaModel moradiaModel)
        {
            tb_moradia moradiaE = new tb_moradia();
            Atribuir(moradiaModel, moradiaE);
            unitOfWork.RepositorioMoradia.Editar(moradiaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="reservaAmbienteModel"> </param>
        public void Remover(int IdRes)
        {
            unitOfWork.RepositorioMoradia.Remover(moradia => moradia.IdMoradia.Equals(IdRes));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<MoradiaModel> GetQuery()
        {
            IQueryable<tb_moradia> tb_moradia = unitOfWork.RepositorioMoradia.GetQueryable();
            var query = from moradia in tb_moradia
                        select new MoradiaModel
                        {
                            IdMoradia = moradia.IdMoradia,
                            IdBloco = moradia.IdBloco,
                            Andar = moradia.Andar,
                            Numero = moradia.Numero,
                            Condominio = moradia.tb_bloco.tb_condominio.Nome,
                            IdCondominio = moradia.tb_bloco.tb_condominio.IdCondominio,
                            NomeBloco = moradia.tb_bloco.Nome,
                            TipoMoradia = (moradia.TipoMoradia == "Cobertura" ? Models.MoradiaModel.ListaTipoMoradia.Cobertura : 
                            (moradia.TipoMoradia == "Casa" ? Models.MoradiaModel.ListaTipoMoradia.Casa : (moradia.TipoMoradia == "Duplex" ? 
                            Models.MoradiaModel.ListaTipoMoradia.Duplex : (moradia.TipoMoradia == "Padrao" ? 
                            Models.MoradiaModel.ListaTipoMoradia.Padrao : MoradiaModel.ListaTipoMoradia.Triplex))))

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MoradiaModel> ObterTodos()
        {
            return GetQuery();
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MoradiaModel> ObterTodosPorBloco(int idBloco)
        {
            return GetQuery().Where(moradiaModel => moradiaModel.IdBloco.Equals(idBloco));
        }


        /// <summary>
        /// Obter todos as entidades cadastradas por condominio
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MoradiaModel> ObterTodosPorCondominio(int idCondominio)
        {
            return GetQuery().Where(moradiaModel => moradiaModel.IdCondominio.Equals(idCondominio));
        }

        /// <summary>
        /// Obtém uma reserva de ambiente
        /// </summary>
        /// <param name="idRes">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public MoradiaModel Obter(int IdRes)
        {
            IEnumerable<MoradiaModel> moradiaE = GetQuery().Where(moradia => moradia.IdMoradia.Equals(IdRes));
            return moradiaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="reservaAmbienteModel">Objeto do modelo</param>
        /// <param name="reservaAmbienteE">Entity mapeada da base de dados</param>
        private void Atribuir(MoradiaModel moradiaModel, tb_moradia moradiaE)
        {
            moradiaE.IdMoradia = moradiaModel.IdMoradia;
            moradiaE.IdBloco = moradiaModel.IdBloco;
            moradiaE.Andar = moradiaModel.Andar;
            moradiaE.Numero = moradiaModel.Numero;
            moradiaE.TipoMoradia = moradiaModel.TipoMoradia.ToString();
        }
    }
}
